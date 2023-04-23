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
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.Setting = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(82, 174);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.ReadOnly = true;
            this.materialTextBox1.Size = new System.Drawing.Size(161, 50);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "password";
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // Setting
            // 
            this.Setting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Setting.BackColor = System.Drawing.SystemColors.Control;
            this.Setting.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Setting.Depth = 0;
            this.Setting.HighEmphasis = true;
            this.Setting.Icon = null;
            this.Setting.Location = new System.Drawing.Point(249, 26);
            this.Setting.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Setting.MouseState = MaterialSkin.MouseState.HOVER;
            this.Setting.Name = "Setting";
            this.Setting.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Setting.Size = new System.Drawing.Size(81, 36);
            this.Setting.TabIndex = 1;
            this.Setting.Text = "Setting";
            this.Setting.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Setting.UseAccentColor = false;
            this.Setting.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.materialTextBox1);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form1";
            this.Text = "密码生成器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton Setting;
    }
}

