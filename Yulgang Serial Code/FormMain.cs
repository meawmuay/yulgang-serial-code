using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace Yulgang_Serial_Code
{
    public partial class FormMain : Form
    {
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern IntPtr GetForegroundWindow();
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int GetWindowText(System.IntPtr hWnd, System.Text.StringBuilder lpString, int cch);

        private Bot _bot;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Set title
            this.Text = @"Yulgang Serial Code " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            //Set Bot
            _bot = new Bot();

            //Game Window
            foreach (SerialCode.GameWindow gameWindow in SerialCode.GameWindowList(0) )
            {
                comboBoxGameWindow.Items.Add(gameWindow.Width.ToString() + "x"+gameWindow.Height.ToString());
            }

            comboBoxGameWindow.SelectedIndex = 0;
            comboBoxNpcZoom.SelectedIndex = 0;
            comboBoxNpcMenu.SelectedIndex = 1;

        }
        private void timerTyping_Tick(object sender, EventArgs e)
        {
            System.Text.StringBuilder title = new System.Text.StringBuilder(256);
            IntPtr handleWindow = GetForegroundWindow();
            GetWindowText(handleWindow, title, title.Capacity);
            Status("รอเลือกหน้าจอเกม...");

            if( title.ToString().StartsWith("YGOnline") )
            {
                Status("บอทกำลังทำงาน...");
                //Bot
                SerialCode.GameWindow gameWindow = SerialCode.GameWindowList(comboBoxNpcMenu.SelectedIndex)[comboBoxGameWindow.SelectedIndex];
                _bot.Run(handleWindow, gameWindow, comboBoxNpcZoom.SelectedIndex == 0);
            }
            //Update Status
            UpdateStatus();

            //Stop bot
            if( _bot.BotStop )
            {
                Status("สิ้นสุดการทำงาน");
                Stop();
            }
        }

        private void UpdateStatus()
        {
            //Update Status
            labelCode.Text = _bot.RunCode;
            labelCodeIndex.Text = _bot.RunIndex;
        }

        private void Start()
        {
            //Warning
            MessageBox.Show(@"หลังจากเลือกหน้าจอเกม กรุณาอย่าขยับเมาส์หรือใช้งานคีย์บอร์ด เพราะโปรแกรมจะทำงานให้คุณแทน", 
                @"คำแนะนำ", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Console.WriteLine("START");
            Status("เริ่มทำงาน...");

            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            textBoxSerialCode.Enabled = false;
            comboBoxGameWindow.Enabled = false;
            comboBoxNpcZoom.Enabled = false;

            _bot.Reset();
            UpdateStatus();
            SetIndex();
            _bot.SetCode(textBoxSerialCode.Text);
            timerTyping.Start();
        }

        private void Stop()
        {
            Console.WriteLine("STOP");
            Status("หยุดทำงาน");
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
            textBoxSerialCode.Enabled = true;
            comboBoxGameWindow.Enabled = true;
            comboBoxNpcZoom.Enabled = true;
            timerTyping.Stop();
        }

        private void Status(String message)
        {
            toolStripStatusLabel.Text = message;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void buttonIndex_Click(object sender, EventArgs e)
        {
            SetIndex();
        }

        public void SetIndex()
        {
            String lines = textBoxSerialCode.Text;
            StringBuilder  stringBuilder = new StringBuilder();

            using( StringReader reader = new StringReader(lines) )
            {
                string line;
                int index = 1;
                while( ( line = reader.ReadLine() ) != null )
                {
                    if( !line.Contains('|') )
                    {
                        string indexString = index.ToString().PadLeft(3, '0');
                        line = indexString + '|' + line;
                    }
                    stringBuilder.AppendLine(line);
                    index++;
                }
            }

            textBoxSerialCode.Text = stringBuilder.ToString();
        }

        private void ToolStripMenuItemUpdate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/meawmuay/yulgang-serial-code");
        }

        private void ToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("โปรแกรมนี้สร้างโดย แมวหมวย\nหากคุณพบปัญหา กรุณาติดต่อเราเพื่อแก้ไข", "เกี่ยวกับ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
