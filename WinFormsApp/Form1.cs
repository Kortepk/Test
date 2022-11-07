using System.IO.Ports;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        static SerialPort serialPort;
        int r=0, g=0, b=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox.Items.Clear();
            // Получаем список COM портов доступных в системе
            string[] portnames = SerialPort.GetPortNames();
            // Проверяем есть ли доступные
            if (portnames.Length == 0)
            {
                MessageBox.Show("COM PORT not found");
            }
            foreach (string portName in portnames)
            {
                //добавляем доступные COM порты в список           
                comboBox.Items.Add(portName);
                Console.WriteLine(portnames.Length);
                if (portnames[0] != null)
                {
                    comboBox.SelectedItem = portnames[0];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                MessageBox.Show("COM PORT not found");
                isConnected = false;
                serialPort.Close();
                button2.Text = "Connect";

                r = 0; g = 0; b = 0;
                vScrollBar1.Value = 255; vScrollBar2.Value = 255; vScrollBar3.Value = 255;
            }
            else
            {
                isConnected = true;
                string selectedPort = comboBox.GetItemText(comboBox.SelectedItem);

                serialPort = new SerialPort();

                serialPort.PortName = selectedPort;
                serialPort.Open();
                button2.Text = "Disconnect";
            }
        }

        private void send_rgb()
        {
            string sr = r.ToString(), sg = g.ToString(), sb = b.ToString();
            while (sr.Length < 3)
                sr = '0' + sr;
            while (sg.Length < 3)
                sg = '0' + sg;
            while (sb.Length < 3)
                sb = '0' + sb;
            serialPort.Write(sr+","+sg + "," + sb);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (isConnected)
            {
                r = 255 - vScrollBar1.Value;
                send_rgb();
                //erialPort.Write("r"+r.ToString());
                Clr.BackColor = Color.FromArgb(r, g, b);
                //textrgb.Text = (vScrollBar1.Value.ToString() + " " + vScrollBar2.Value.ToString() + " " + vScrollBar3.Value.ToString());
                textrgb.Text = (r.ToString() + " " + g.ToString() + " " + b.ToString());
            }
        }
        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            if (isConnected)
            {
                g = 255 - vScrollBar2.Value;
                send_rgb();
                Clr.BackColor = Color.FromArgb(r, g, b);
                textrgb.Text = (r.ToString() + " " + g.ToString() + " " + b.ToString());
            }
        }

        private void UPD_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                txt2.Text = serialPort.ReadExisting();
            }
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            if (isConnected)
            {
                b = 255 - vScrollBar3.Value;
                send_rgb();
                Clr.BackColor = Color.FromArgb(r, g, b);
                textrgb.Text = (r.ToString() + " " + g.ToString() + " " + b.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                r = 0; g = 0; b = 0;
                vScrollBar1.Value = 255; vScrollBar2.Value = 255; vScrollBar3.Value = 255;
                send_rgb();

                Clr.BackColor = Color.FromArgb(r, g, b);
                textrgb.Text = (r.ToString() + " " + g.ToString() + " " + b.ToString());
            }
        }
    }
}