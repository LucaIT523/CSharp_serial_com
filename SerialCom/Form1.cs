using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;
using static System.Windows.Forms.AxHost;
using System.Security.Policy;
using System.Net;
using System.Security.Authentication;
using System.IO;

namespace SerialCom
{
    public partial class Form1 : Form
    {
        private HttpClient client;
        private SerialPort serialPort;
        private bool isOpen;
        private byte[] recieveData;
        private int length;
        private int state;
        private string weight;
        private string serverURL;
        private double TotalValue;
        private double AvgValue;
        private int avgCount;
        private int avgNum;
        public Form1()
        {
            InitializeComponent();
            serverURL = "http://localhost:3000/balance";

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            HttpClientHandler handler = new HttpClientHandler();
            handler.SslProtocols = SslProtocols.Tls12;
            client = new HttpClient(handler);

            serialPort = null;
            isOpen = false;

            recieveData = new byte[256];
            length = 0;
            state = -1;

            TotalValue = 0.0;
            AvgValue= 0.0;
            avgCount = 30;
            avgNum = 0;

            comCtrl.SelectedIndex = 1;
            baudrateCtrl.SelectedIndex = 4;
            databitsCtrl.SelectedIndex = 2;
            parityCtrl.SelectedIndex = 2;
            stopbitsCtrl.SelectedIndex = 1;
            averageCtrl.SelectedIndex = 4;
            
        }
        private async void SendDataToServer(string data)
        {
            var content = new StringContent($"{{\"weight\": \"{data}\"}}", System.Text.Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(serverURL, content);
                response.EnsureSuccessStatusCode(); // Ensure the response is successful
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Response: " + responseBody);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Error sending POST request: " + ex.Message);
            }
        }
        private async void SendGetDataToServer(string data)
        {            
            //handler.SslProtocols = SslProtocols.Tls13;
            // Create HttpClient instance
            //specify to use TLS 1.2 as default connection
            try
            {
                // Build the URL with the number value as a query parameter
                string url = $"{serverURL}?reading={data}";
                Invoke((Action)(() => urlTxt.Text = url));
                // Send GET request without expecting a response
                HttpResponseMessage response = await client.GetAsync(url);

                    
                // Check if request was successful
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Update the UI control on the UI thread
                    Invoke((Action)(() => urlTxt.Text = responseBody));

                    // Output the response body
                    Console.WriteLine(responseBody);
                }
                else
                {
                    Invoke((Action)(() => urlTxt.Text = "No Response!"));
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
        private async void SendWebGetDataToServer(string data)
        {            
            try
            {
                if (string.IsNullOrEmpty(data) || int.Parse(data) == 0)
                    return;
                // Build the URL with the number value as a query parameter
                string url = $"{serverURL}?reading={data}";
                // Update the UI control on the UI thread
                Invoke((Action)(() => urlTxt.Text = url));
                // Create a WebRequest
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";

                // Send the request and get the response
                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                {
                    // Check if the response is successful
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        // Read the response content
                        using (Stream responseStream = response.GetResponseStream())
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                string responseBody = await reader.ReadToEndAsync();

                                // Update the UI control on the UI thread
                                Invoke((Action)(() => urlTxt.Text = responseBody));

                                // Output the response body
                                Console.WriteLine(responseBody);
                            }
                        }
                    }
                    else
                    {
                        // Update the UI control on the UI thread
                        Invoke((Action)(() => urlTxt.Text = "No Response!"));

                        Console.WriteLine($"Error: {response.StatusCode} - {response.StatusDescription}");
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine($"WebException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                // Read each byte from the serial port
                int bytesToRead = sp.BytesToRead;
                byte[] buffer = new byte[bytesToRead];
                sp.Read(buffer, 0, bytesToRead);
                for (int i = 0; i < bytesToRead; i++)
                {
                    if (buffer[i] == 0x02)
                    {
                        state = 0;
                    }
                    else if (state == 0 && buffer[i] == 0x31)
                    {
                        state = 1;
                    }
                    else if (state == 1 && buffer[i] == 0x30)
                    {
                        state = 2; length = 0; weight = "";
                    }
                    else if (state == 2 && buffer[i] == 0x0D)
                    {
                        avgNum++;
                        TotalValue += int.Parse(weight);
                        if (avgNum >= avgCount)
                        {
                            AvgValue = TotalValue / avgNum;
                            TotalValue = 0;
                            avgNum = 0;
                            string strAvg = "0";
                            if (AvgValue != 0.0)
                                strAvg = AvgValue.ToString("F2");
                            //SendDataToServer(strAvg);
                            SendGetDataToServer(strAvg);
                            //SendWebGetDataToServer(strAvg);                        
                            avgTxt.Invoke(new Action(() =>
                            {
                                avgTxt.Text = null;
                                avgTxt.AppendText(strAvg);
                            }));
                        }
                        // Update the TextBox control with the received data
                        resultTxt.Invoke(new Action(() => {
                            resultTxt.Text = null;
                            resultTxt.AppendText(weight);
                        }));
                        weight = "";
                        state = 3;
                    }
                    else if (state == 2 && length < 8)
                    {
                        length++;
                        //recieveData[length++] = buffer[i];
                        if (buffer[i] != 0x20)
                            weight += Convert.ToChar(buffer[i]);
                    }
                }
                // Convert each byte to its hexadecimal representation
                StringBuilder hexString = new StringBuilder();
                foreach (byte b in buffer)
                {
                    hexString.AppendFormat("{0:X2} ", b);
                }
                string hexData = hexString.ToString().Trim();


                // Update the ListBox control with the received data
                resultList.Invoke(new Action(() => {
                    if (resultList.Items.Count > 300)
                        resultList.Items.RemoveAt(0);
                    resultList.Items.Add(hexString);
                    // Scroll to the bottom of the ListBox
                    resultList.SelectedIndex = resultList.Items.Count - 1;
                    resultList.TopIndex = resultList.SelectedIndex;
                }));
            }
            catch (Exception ex) { }            
        }
        private void openBtn_Click(object sender, EventArgs e)
        {
            if (!isOpen)
            {
                if(serverURLTxt.Text != "local")
                    serverURL = serverURLTxt.Text;
                avgCount = int.Parse(averageCtrl.Text);
                string comNum = comCtrl.Text;
                int baudRate = int.Parse(baudrateCtrl.Text);
                Parity parity = (Parity)parityCtrl.SelectedIndex;
                int dataBits = databitsCtrl.SelectedIndex + 5;
                StopBits stopBits = (StopBits)stopbitsCtrl.SelectedIndex;
                serialPort = new SerialPort(comNum, baudRate, parity, dataBits, stopBits);
                try
                {
                    // Open the serial port
                    serialPort.Open();
                    serialPort.DataReceived += SerialPort_DataReceived;
                    isOpen = true;
                    openBtn.Text = "Close";
                    Set_groupBox.Enabled = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                // Close the serial port
                serialPort.Close();
                serialPort = null;
                isOpen = false;
                openBtn.Text = "Open";
                Set_groupBox.Enabled = true;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            // Clear all items from the ListBox
            resultList.Items.Clear();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (isOpen)
                serialPort.Close();
        }

        private void testBTN_Click(object sender, EventArgs e)
        {
            if (serverURLTxt.Text != "local")
                serverURL = serverURLTxt.Text;
            if (string.IsNullOrEmpty(avgTxt.Text))
                MessageBox.Show("Please enter weight value!");
            else
                SendGetDataToServer(avgTxt.Text);
        }
    }
}
