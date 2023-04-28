namespace PassWordGraph
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Setting = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.time_left_DIE = new MaterialSkin.Controls.MaterialProgressBar();
            this.passworddis = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.password_bit = new MaterialSkin.Controls.MaterialTextBox2();
            this.SB = new MaterialSkin.Controls.MaterialButton();
            this.PassWordType = new MaterialSkin.Controls.MaterialComboBox();
            this.tiktok = new System.Windows.Forms.Timer(this.components);
            this.showTimer = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Setting
            // 
            this.Setting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Setting.BackColor = System.Drawing.SystemColors.Control;
            this.Setting.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Setting.Depth = 0;
            this.Setting.HighEmphasis = true;
            this.Setting.Icon = null;
            this.Setting.Location = new System.Drawing.Point(122, 230);
            this.Setting.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Setting.MouseState = MaterialSkin.MouseState.HOVER;
            this.Setting.Name = "Setting";
            this.Setting.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Setting.Size = new System.Drawing.Size(81, 36);
            this.Setting.TabIndex = 1;
            this.Setting.Text = "Setting";
            this.Setting.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Setting.UseAccentColor = false;
            this.Setting.UseVisualStyleBackColor = false;
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(321, 377);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.time_left_DIE);
            this.tabPage1.Controls.Add(this.passworddis);
            this.tabPage1.Controls.Add(this.Setting);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(313, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // time_left_DIE
            // 
            this.time_left_DIE.Depth = 0;
            this.time_left_DIE.Location = new System.Drawing.Point(23, 144);
            this.time_left_DIE.MouseState = MaterialSkin.MouseState.HOVER;
            this.time_left_DIE.Name = "time_left_DIE";
            this.time_left_DIE.Size = new System.Drawing.Size(269, 5);
            this.time_left_DIE.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.time_left_DIE.TabIndex = 3;
            // 
            // passworddis
            // 
            this.passworddis.AnimateReadOnly = false;
            this.passworddis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passworddis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passworddis.Depth = 0;
            this.passworddis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passworddis.HideSelection = true;
            this.passworddis.LeadingIcon = null;
            this.passworddis.Location = new System.Drawing.Point(23, 90);
            this.passworddis.MaxLength = 32767;
            this.passworddis.MouseState = MaterialSkin.MouseState.OUT;
            this.passworddis.Name = "passworddis";
            this.passworddis.PasswordChar = '\0';
            this.passworddis.PrefixSuffixText = null;
            this.passworddis.ReadOnly = true;
            this.passworddis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passworddis.SelectedText = "";
            this.passworddis.SelectionLength = 0;
            this.passworddis.SelectionStart = 0;
            this.passworddis.ShortcutsEnabled = true;
            this.passworddis.Size = new System.Drawing.Size(269, 48);
            this.passworddis.TabIndex = 2;
            this.passworddis.TabStop = false;
            this.passworddis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passworddis.TrailingIcon = null;
            this.passworddis.UseSystemPasswordChar = false;
            this.passworddis.Click += new System.EventHandler(this.passworddis_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.password_bit);
            this.tabPage2.Controls.Add(this.SB);
            this.tabPage2.Controls.Add(this.PassWordType);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(313, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // password_bit
            // 
            this.password_bit.AnimateReadOnly = false;
            this.password_bit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.password_bit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.password_bit.Depth = 0;
            this.password_bit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password_bit.HideSelection = true;
            this.password_bit.LeadingIcon = null;
            this.password_bit.Location = new System.Drawing.Point(53, 36);
            this.password_bit.MaxLength = 32767;
            this.password_bit.MouseState = MaterialSkin.MouseState.OUT;
            this.password_bit.Name = "password_bit";
            this.password_bit.PasswordChar = '\0';
            this.password_bit.PrefixSuffixText = null;
            this.password_bit.ReadOnly = false;
            this.password_bit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.password_bit.SelectedText = "";
            this.password_bit.SelectionLength = 0;
            this.password_bit.SelectionStart = 0;
            this.password_bit.ShortcutsEnabled = true;
            this.password_bit.Size = new System.Drawing.Size(217, 48);
            this.password_bit.TabIndex = 2;
            this.password_bit.TabStop = false;
            this.password_bit.Text = "请输入密码位数，至少8位";
            this.password_bit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password_bit.TrailingIcon = null;
            this.password_bit.UseSystemPasswordChar = false;
            this.password_bit.Click += new System.EventHandler(this.materialTextBox1_TextChanged);
            this.password_bit.DoubleClick += new System.EventHandler(this.password_bit_DoubleClick);
            this.password_bit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_bit_KeyPress);
            // 
            // SB
            // 
            this.SB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SB.Depth = 0;
            this.SB.HighEmphasis = true;
            this.SB.Icon = null;
            this.SB.Location = new System.Drawing.Point(165, 298);
            this.SB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SB.MouseState = MaterialSkin.MouseState.HOVER;
            this.SB.Name = "SB";
            this.SB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SB.Size = new System.Drawing.Size(133, 36);
            this.SB.TabIndex = 1;
            this.SB.Text = "Save and Back";
            this.SB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.SB.UseAccentColor = false;
            this.SB.UseVisualStyleBackColor = true;
            this.SB.Click += new System.EventHandler(this.SB_Click);
            // 
            // PassWordType
            // 
            this.PassWordType.AutoResize = false;
            this.PassWordType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PassWordType.Depth = 0;
            this.PassWordType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.PassWordType.DropDownHeight = 174;
            this.PassWordType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PassWordType.DropDownWidth = 121;
            this.PassWordType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.PassWordType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PassWordType.FormattingEnabled = true;
            this.PassWordType.IntegralHeight = false;
            this.PassWordType.ItemHeight = 43;
            this.PassWordType.Items.AddRange(new object[] {
            "classic",
            "rolling",
            "disorder"});
            this.PassWordType.Location = new System.Drawing.Point(53, 120);
            this.PassWordType.MaxDropDownItems = 4;
            this.PassWordType.MouseState = MaterialSkin.MouseState.OUT;
            this.PassWordType.Name = "PassWordType";
            this.PassWordType.Size = new System.Drawing.Size(217, 49);
            this.PassWordType.StartIndex = 0;
            this.PassWordType.TabIndex = 0;
            // 
            // tiktok
            // 
            this.tiktok.Enabled = true;
            this.tiktok.Interval = 30000;
            this.tiktok.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // showTimer
            // 
            this.showTimer.Enabled = true;
            this.showTimer.Interval = 1000;
            this.showTimer.Tick += new System.EventHandler(this.showTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.materialTabControl1);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码生成器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton Setting;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialComboBox PassWordType;
        private MaterialSkin.Controls.MaterialButton SB;
        private MaterialSkin.Controls.MaterialTextBox2 passworddis;
        private MaterialSkin.Controls.MaterialTextBox2 password_bit;
        private System.Windows.Forms.Timer tiktok;
        private MaterialSkin.Controls.MaterialProgressBar time_left_DIE;
        private System.Windows.Forms.Timer showTimer;
    }
}

