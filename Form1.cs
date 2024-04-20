using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Qbit_SanalMakine
{
    public partial class Form1 : Form
    {
        private const string LogFilePath = "d:\\log_test_200.txt";
        private const int PortNumber = 3384;
        private TcpClient tcpClient;
        private NetworkStream stream;
        private StreamReader fileReader;
        private long lastPosition = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Başlangıçta bağlantıyı başlat
            textBox3.Text = "1,32,70,5,0,1.5,2.8,0.8,0,0,0,0,0,R11,R20,R30,R40,R51,R60,0,0,192.168.1.101,80:1F:12:A8:84:1E,275,0";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (fileReader == null)
                {
                    fileReader = new StreamReader(LogFilePath);
                    // En son konum neredeyse oradan okumaya başla
                    fileReader.BaseStream.Seek(lastPosition, SeekOrigin.Begin);
                }

                string line = fileReader.ReadLine();
                if (line != null)
                {
                    textBox1.Text = line;
                    byte[] data = Encoding.UTF8.GetBytes(line);
                    TcpSend(line);
                    if (check1.Checked == true)
                        check1.Checked = false;
                    else
                        check1.Checked = true;
                }
                else
                {
                    // Dosya sonuna ulaşıldığında dosyayı sıfırla
                    fileReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    lastPosition = 0;
                }
            }
            catch (Exception ex)
            {
                label1.Text = $"Dosya okuma hatası: {ex.Message}";
                // Bağlantıyı yeniden başlat
                Connect();
            }
        }

        public void Connect()
        {
            try
            {
                // TCP bağlantısını kur
                tcpClient = new TcpClient();
                tcpClient.Connect(txtIP.Text, Convert.ToInt16(txtPort.Text));
                stream = tcpClient.GetStream();

                // Log dosyasını okumak için bir StreamReader oluştur
                fileReader = new StreamReader(LogFilePath);
            }
            catch (Exception ex)
            {
                label1.Text = $"Bağlantı hatası: {ex.Message}";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string ipAddress = txtIP.Text; // Bağlanmak istediğiniz IP adresini buraya girin
                int port = 8000; // Bağlanmak istediğiniz port numarasını buraya girin

                try
                {
                    using (TcpClient client = new TcpClient(ipAddress, port))
                    using (NetworkStream stream = client.GetStream())
                    {
                        // Bağlantı kurulduğunda burada istediğiniz işlemleri gerçekleştirebilirsiniz.
                        // Örneğin, bir mesaj göndermek için:
                        
                        string message = textBox3.Text ;
                        byte[] data = Encoding.UTF8.GetBytes(message);
                        stream.Write(data, 0, data.Length);

                        //MessageBox.Show("Mesaj gönderildi: " + message, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    label1.Text = "Bağlantı hatası: " + ex.Message;
                }
            }
        }

        private bool TcpSend(string sendData, int timeoutMilliseconds = 1000)
        {
            string ipAddress = txtIP.Text;
            int port = Convert.ToInt16(txtPort.Text);

            try
            {
                using (TcpClient mac_client = new TcpClient(ipAddress, port))
                using (NetworkStream stream = mac_client.GetStream())
                {
                    if (mac_client.Connected)
                    {
                        string dataToSend = sendData.Trim();
                        byte[] data = Encoding.UTF8.GetBytes(dataToSend);
                        stream.Write(data, 0, data.Length);
                        Console.WriteLine(" TCP/IP Veri gönderildi: " + dataToSend, "Başarılı");
                        return true;
                    }
                    else
                    {
                        label1.Text = "Makineye Bağlantı YOK";
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = "Hata: " + ex.Message;
                return false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            fileReader?.Close();
            stream?.Close();
            tcpClient?.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Interval = Convert.ToInt16(textBox2.Text);
            if (timer.Enabled == true)
            {
                timer.Enabled = false;
                timer.Stop();
                textBox1.Text = "";
            }
            else
            {
                timer.Enabled = true;
                timer.Start();
            }
        }
    }
}
