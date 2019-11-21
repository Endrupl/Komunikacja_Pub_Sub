using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using NetMQ;
using NetMQ.Sockets;

namespace ProgramPubSubServer
{
    public partial class PubSubServer : Form
    {
        public PubSubServer()
        {
            InitializeComponent();
        }

        void publicData()
        {
            using (var pubSocket = new PublisherSocket())
            {
                pubSocket.Bind("tcp://*:12345");
                while (true)
                {
                    if(publicDate.Checked)
                    {
                        string messageTopic = "date";
                        string messageContent = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                        pubSocket.SendMoreFrame(messageTopic).SendFrame(messageContent);
                        MethodInvoker methodInvoker = () => sendLogs(messageTopic, messageContent);
                        Invoke(methodInvoker);
                    }
                    if(publicTime.Checked)
                    {
                        string messageTopic = "time";
                        string messageContent = DateTime.Now.ToString("HH:mm:ss");
                        pubSocket.SendMoreFrame(messageTopic).SendFrame(messageContent);
                        MethodInvoker methodInvoker = () => sendLogs(messageTopic, messageContent);
                        Invoke(methodInvoker);
                    }
                    if (publicText.Checked)
                    {
                        string messageTopic = "text";
                        string messageContent = textContent.Text;
                        pubSocket.SendMoreFrame(messageTopic).SendFrame(messageContent);
                          MethodInvoker methodInvoker = () => sendLogs(messageTopic, messageContent);
                          Invoke(methodInvoker);
                    }
                    try
                    {
                        Thread.Sleep(Int32.Parse(timeText.Text) * 1000);
                    }
                    catch (FormatException fe)
                    {
                        MessageBox.Show(fe.Message);
                        MethodInvoker mi = new MethodInvoker(() => timeText.Text = "10");
                        Invoke(mi);
                    }
                }
            }
        }

        void sendLogs(string message, string messageText)
        {
            messageText = null;
            switch (message)
            {
                case "date":
                    messageText = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Wysyłanie daty: " + messageText);
                    break;
                case "time":
                    messageText = DateTime.Now.ToString("HH:mm:ss");
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Wysyłanie czasu: " + messageText);
                    break;
                case "text":
                    messageText = textContent.Text;
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Wysyłanie treści: " + messageText);
                    break;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            SettingBox.Enabled = false;
            Task task = Task.Run(() => publicData());
        }
    }
}
