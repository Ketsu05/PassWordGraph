using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Configuration;

namespace PassWordGraph
{
    public partial class Form1 : MaterialForm
    {
        int tc = 0;//倒计时显示变量
        public Form1()
        {
            InitializeComponent();

            var msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
            msm.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            PassWordType.Text = cfa.AppSettings.Settings["type"].Value;
            password_bit.Text = cfa.AppSettings.Settings["bit"].Value;
            timer1_Tick(tiktok,new EventArgs());
            time_left_DIE.Maximum = tiktok.Interval / showTimer.Interval;
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Setting_Click(object sender, EventArgs e)
        {
            tiktok.Enabled = false;
            showTimer.Enabled = false;
            materialTabControl1.SelectedTab = tabPage2;
            
        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {

        }

        private void SB_Click(object sender, EventArgs e)
        {
            int bit = 0;
            if (!(int.TryParse((password_bit).Text, out  bit))) 
            {
                
                MessageBox.Show(this,"必须得是数字");
                return;
            }
            if (bit < 8 || bit > 128)
            {
                MessageBox.Show(this, "至少得是个8,且不能超过128");
                return;

            }
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings["type"].Value = PassWordType.Text;
            cfa.AppSettings.Settings["bit"].Value = password_bit.Text;

            cfa.Save();
            materialTabControl1.SelectedTab = tabPage1;
            timer1_Tick(tiktok, new EventArgs());
            tiktok.Enabled = true;
            showTimer.Enabled = true;
            tc = 0;
        }

        private void passworddis_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(passworddis.Text);
            MessageBox.Show(this,"已复制密码，去注册界面粘贴吧");
        }

        

       

        private void password_bit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar =='\b' || char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void password_bit_DoubleClick(object sender, EventArgs e)
        {
            password_bit.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);            
            string type = cfa.AppSettings.Settings["type"].Value;
            string bit = cfa.AppSettings.Settings["bit"].Value;

            switch (type)
            {
                case "classic":
                    passworddis.Text = DefaultPassWord(bit);                    
                    break;
                case "disorder":
                    passworddis.Text = RandomBitPassWord(bit);
                    break;
                case "rolling":
                    passworddis.Text = RollBitPassWord(bit);
                    break;
            }
            
                
            


        }
        public string DefaultPassWord(string bit)
        {

            string passwd = "";
            char[] spChars = { '$', '~', '!', '@', '#', '%', '^', '&', '`', '-' };            
            int passwdLen = Convert.ToInt32(bit);
            Random r = new Random();



            while (passwd.Length < passwdLen)
            {
                switch (passwd.Length % 4)
                {
                    case 0:
                        char upC = (char)r.Next(65, 90);
                        passwd += upC;
                        break;

                    case 1:

                        char lowC = (char)r.Next(97, 122);
                        passwd += lowC;
                        break;

                    case 2:

                        char numC = (char)r.Next(49, 57);
                        passwd += numC;
                        break;

                    case 3:
                        int num = r.Next(10);
                        char spC = spChars[num];
                        passwd += spC;
                        break;
                }

            }           
            
            return passwd;

        }
        public string RandomBitPassWord(string bit)
        {
            
            string passwd = "";
            char[] spChars = { '$', '~', '!', '@', '#', '%', '^', '&', '`', '-' };
            int passwdLen = Convert.ToInt32(bit);
            Random r = new Random();
            while (passwd.Length < passwdLen)
            {


                if (passwd.Length == passwdLen)
                {
                    break;
                }
                else
                {
                    
                    char rChar = (char)r.Next(33, 126);
                    passwd += rChar;
                }

            }
                        
            return passwd;
        }
        public string RollBitPassWord(string bit)
        {
            
            string passwd = "";
            char[] spChars = { '$', '~', '!', '@', '#', '%', '^', '&', '`', '-' };
            int passwdLen = Convert.ToInt32(bit);
            Random r = new Random();
            int pbit = 0;


            while (passwd.Length < passwdLen)
            {

                switch ((passwd.Length + pbit) % 4)
                {
                    case 0:
                        char upC = (char)r.Next(65, 90);
                        passwd += upC;
                        break;

                    case 1:

                        char lowC = (char)r.Next(97, 122);
                        passwd += lowC;
                        break;

                    case 2:

                        char numC = (char)r.Next(49, 57);
                        passwd += numC;
                        break;

                    case 3:
                        int num = r.Next(10);
                        char spC = spChars[num];
                        passwd += spC;
                        break;
                }
                if (passwd.Length % 4 == 0)

                {
                    pbit += 1;
                }

            }
           
            return passwd;
        }

        private void showTimer_Tick(object sender, EventArgs e)
        {
            tc++;
            if (tc >= tiktok.Interval/showTimer.Interval)
            {
                tc = 0;
            }
            time_left_DIE.Value = tc;
        }

       
            
                
            


        }
       