using NetMQ;
using NetMQ.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramPubSubKlient
{
    public partial class PubSubKlient : Form
    {
        bool subscription = false;

        public PubSubKlient()
        {
            InitializeComponent();
        }

        void subscribeData()
        {
            using (var subSocket = new SubscriberSocket())
            {
                try
                {
                    subSocket.Connect("tcp://localhost:12345");
                }
                catch(SocketException se)
                {
                    MessageBox.Show(se.Message);
                    MethodInvoker methodInvoker = new MethodInvoker(() =>
                    {
                        btnStart.Enabled = true;
                        btnStop.Enabled = false;
                        subscription = false;
                        subDate.Enabled = true;
                        subTime.Enabled = true;
                        subText.Enabled = true;
                        btnStart.Enabled = true;
                    });
                    Invoke(methodInvoker);
                }
                
                if (subDate.Checked)
                {
                    subSocket.Subscribe("date");
                }
                if (subTime.Checked)
                {
                    subSocket.Subscribe("time");
                }
                if (subText.Checked)
                {
                    subSocket.Subscribe("text");
                }

                while (subscription)
                {
                    string messageTopic = subSocket.ReceiveFrameString();
                    string messageReceive = subSocket.ReceiveFrameString();
                    MethodInvoker methodInvoker = () => receiveLogs(messageTopic, messageReceive);
                    Invoke(methodInvoker);
                }
            }
        }
        void receiveLogs(string messageTopic, string messageText)
        {
            switch (messageTopic)
            {
                case "date":
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Odebranie daty: " + messageText);
                    break;
                case "time":
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Odebranie czasu: " + messageText);
                    break;
                case "text":
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Odebranie treści: " + messageText);
                    break;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            subDate.Enabled = false;
            subTime.Enabled = false;
            subText.Enabled = false;
            btnStart.Enabled = false;
            subscription = true;
            Task task = Task.Run(() => subscribeData());
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            subDate.Enabled = true;
            subTime.Enabled = true;
            subText.Enabled = true;
            btnStart.Enabled = true;
            subscription = false;
        }
    }
}
