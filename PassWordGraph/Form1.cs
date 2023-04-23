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

namespace PassWordGraph
{
    public partial class Form1 : MaterialForm
    {
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
            
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Setting_Click(object sender, EventArgs e)
        {
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
            if (bit <= 8 || bit >= 128)
                MessageBox.Show(this,"至少得是个8,且不能超过128");
            materialTabControl1.SelectedTab = tabPage1;


        }

        private void passworddis_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialSlider1_Click(object sender, EventArgs e)
        {

        }

        private void password_bit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar =='\b' || char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void password_bit_Leave(object sender, EventArgs e)
        {
            int bit = 0;
            if (!(int.TryParse((password_bit).Text, out bit)))
            {

                MessageBox.Show(this, "必须得是数字");
                return;
            }
            if (bit <= 8 || bit >= 128)
                MessageBox.Show(this, "至少得是个8,且不能超过128");
        }
    }
}
