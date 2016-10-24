using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.IO;
namespace Miniproject
{
    public partial class Form1 : Form
    {

        Socket sck;
        EndPoint eplocal, epremote;

        public Form1()
        {
            InitializeComponent();











          



            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();



            listBox1.Items.Add("Interface information for " + computerProperties.HostName + computerProperties.DomainName);
            if (nics == null || nics.Length < 1)
            {
                listBox1.Items.Add("  No network interfaces found.");
                return;
            }

            listBox1.Items.Add(nics.Length);
            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties(); //  .GetIPInterfaceProperties();
                listBox1.Items.Add("");
                listBox1.Items.Add(adapter.Description);
                listBox1.Items.Add(String.Empty.PadLeft(adapter.Description.Length, '='));
                listBox1.Items.Add(adapter.NetworkInterfaceType);
                listBox1.Items.Add("  Physical address ........................ : ");
                PhysicalAddress address = adapter.GetPhysicalAddress();
                byte[] bytes = address.GetAddressBytes();
                string str1 = "";
                for (int i = 0; i < bytes.Length; i++)
                {

                    str1 = str1 + bytes[i].ToString("X2");
                    // Display the physical address in hexadecimal.
                    //listBox1.Items.Add(bytes[i].ToString("X2"));
                    // Insert a hyphen after each byte, unless we are at the end of the  
                    // address. 
                    if (i != bytes.Length - 1)
                    {
                        str1 = str1 + "-";
                        //listBox1.Items.Add("-");
                    }
                }
                listBox1.Items.Add(str1);
            }











            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //to get the ip addresses into the textboxes
            //local ip address
            textLocalip.Text = getLocalIP();
            //receiver ip address
            //textFriendIp.Text = getLocalIP();
            // IPList2();

            //computername of this system 
            string computerName = System.Net.Dns.GetHostName();
            listBox1.Items.Add(computerName);

            





            System.Net.IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(computerName);
            System.Net.IPAddress[] ipAddress = ipEntry.AddressList;
            try
            {
                listBox1.Items.Add(ipAddress[2]);
            }
            catch (Exception e)
            {
                MessageBox.Show("No lan connection! \n" + e);
            }


            for (int i = 0; i < ipAddress.Length; i++)
            {
                listBox1.Items.Add(ipAddress[i]);
            }
            computerName = computerName + "\t" + ipAddress[0].ToString();
            listBox1.Items.Add(computerName);





            //Read file to byte array

          

       }























        private static PhysicalAddress GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress();
                }
            }
            return null;
        }


















        private static IPAddress GetIPAddress()
        {
            String strHostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            foreach (IPAddress ip in addr)
            {
                if (!ip.IsIPv6LinkLocal)
                {
                    return (ip);
                }
            }
            return addr.Length > 0 ? addr[0] : null;
        }














        private static bool IsMulticast(IPAddress ip)
        {
            bool result = true;
            if (!ip.IsIPv6Multicast)
            {
                byte highIP = ip.GetAddressBytes()[0];
                if (highIP < 224 || highIP > 239)
                {
                    result = false;
                }
            }
            return result;
        }

        //for ipaddresses of lan connected systems
        /*
        private delegate void MyPing(int id);
                public string IPList2()
                {

                    string myipsplit = string.Empty;
                    string localhostname = Dns.GetHostName();
                    IPAddress[] paddresses = Dns.GetHostAddresses(localhostname);
                    string myip = paddresses.Where(ip => ip.AddressFamily == AddressFamily.InterNetwork).FirstOrDefault().ToString();
                    string[] myiparray = myip.Split(new[] { '.' });
                    for (int j = 1; j < myiparray.Length; j++)
                        myipsplit += myiparray[j - 1] + ".";
                    Trace.WriteLine(DateTime.Now);
                    var results = new string[0x100];
                    MyPing ping = 
                     id =>
                    {
                        string ls = myipsplit + id;
                        var pingSender = new Ping();
                        PingReply reply = pingSender.Send(ls, 100);
                        if (reply != null)
                            if (reply.Status == IPStatus.Success)
                                results[id] = reply.Address.ToString();
                    };
                    var asyncResults = new IAsyncResult[0x100];
                    for (int i = 1; i < 0x100; i++)
                    {
                        asyncResults[i] = ping.BeginInvoke(i, null, null);
                    }
                    for (int i = 1; i < 0x100; i++)
                    {
                        ping.EndInvoke(asyncResults[i]);
                    }
                    Trace.WriteLine(DateTime.Now);
                    var sb = new StringBuilder();
                    for (int i = 1; i < 0x100; i++)
                    {
                        if (results[i] != null)
                            listBox1.Items.Add(results[i]);
                            sb.AppendFormat("{0} ", results[i]);
                    }
                    return sb.ToString();
                }
              */

        private string getLocalIP()
        {
            // method for getting ip address
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {

                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    //network ip address is returned in the form of string
                    return ip.ToString();
                }
            }
            //if nothing is there to be returned then this is returned
            return "127.0.0.1";
        }





        private void messageCallBack(IAsyncResult aResult)
        {
            //method for callback
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epremote);

                //if there is inf or not
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];

                    receivedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    //converts the received bytes into string
                    using (Stream file = File.OpenWrite(@"e:\filescopy"))
                    {
                        file.Write(receivedData, 0, receivedData.Length);
                    }
                    //string receivedMessage = eEncoding.GetString(receivedData);
                    //displaying the message in the listbox
                   // listmessage.Items.Add("friend:" + receivedMessage);
                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epremote, new AsyncCallback(messageCallBack), buffer);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //convert into bytes
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textmsg.Text);
                
                //send the msg to other client in the form of bytes
                //Read file to byte array

                FileStream stream = File.OpenRead(textmsg.Text);
                byte[] fileBytes = new byte[stream.Length];
                stream.Read(fileBytes, 0, fileBytes.Length);

                sck.Send(fileBytes);

               // sck.Send(msg);
                // we need to see msg in list box
                listmessage.Items.Add("you:" + textmsg.Text);
                //clear the text 
                textmsg.Clear();

            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                eplocal = new IPEndPoint(IPAddress.Parse(textLocalip.Text), Convert.ToInt32(textLocalport.Text));
                sck.Bind(eplocal);

                //receiving
                epremote = new IPEndPoint(IPAddress.Parse(textFriendIp.Text), Convert.ToInt32(textFreindport.Text));
                sck.Connect(epremote);
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epremote, new AsyncCallback(messageCallBack), buffer);
                // click start button ip is connected message should be shown
                button1.Text = "connected";
                button1.Enabled = false;
                button2.Enabled = true;
                textmsg.Focus();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*// Create a new instance of FolderBrowserDialog.
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            // A new folder button will display in FolderBrowserDialog.
            folderBrowserDlg.ShowNewFolderButton = true;
            //Show FolderBrowserDialog
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                //Show selected folder path in textbox1.
               // textBox1.Text = folderBrowserDlg.SelectedPath;
                //Browsing start from root folder.
                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;*/
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"E:\";
            openFileDialog1.Title = "Browse Text Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textmsg.Text = openFileDialog1.FileName;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void listmessage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}

