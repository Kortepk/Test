using System.IO.Ports;

namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                if (serialPort.IsOpen) serialPort.Close();
                components.Dispose();
            }
            base.Dispose(disposing);
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 


        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.Clr = new System.Windows.Forms.PictureBox();
            this.textrgb = new System.Windows.Forms.Label();
            this.UPD = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.Label();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.Clr)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get COM-port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox
            // 
            this.comboBox.Location = new System.Drawing.Point(25, 64);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 23);
            this.comboBox.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 28);
            this.button3.TabIndex = 0;
            this.button3.Text = "Off";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(25, 150);
            this.vScrollBar1.Maximum = 255;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 100);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Value = 255;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // Clr
            // 
            this.Clr.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clr.Location = new System.Drawing.Point(173, 150);
            this.Clr.Name = "Clr";
            this.Clr.Size = new System.Drawing.Size(100, 100);
            this.Clr.TabIndex = 1;
            this.Clr.TabStop = false;
            // 
            // textrgb
            // 
            this.textrgb.AutoSize = true;
            this.textrgb.Location = new System.Drawing.Point(199, 117);
            this.textrgb.Name = "textrgb";
            this.textrgb.Size = new System.Drawing.Size(31, 15);
            this.textrgb.TabIndex = 2;
            this.textrgb.Text = "0 0 0";
            // 
            // UPD
            // 
            this.UPD.Location = new System.Drawing.Point(189, 263);
            this.UPD.Name = "UPD";
            this.UPD.Size = new System.Drawing.Size(57, 28);
            this.UPD.TabIndex = 0;
            this.UPD.Text = "Update";
            this.UPD.UseVisualStyleBackColor = true;
            this.UPD.Click += new System.EventHandler(this.UPD_Click);
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Location = new System.Drawing.Point(267, 270);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(13, 15);
            this.txt2.TabIndex = 2;
            this.txt2.Text = "0";
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(127, 150);
            this.vScrollBar3.Maximum = 255;
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(20, 100);
            this.vScrollBar3.TabIndex = 0;
            this.vScrollBar3.Value = 255;
            this.vScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar3_Scroll);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(77, 150);
            this.vScrollBar2.Maximum = 255;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(20, 100);
            this.vScrollBar2.TabIndex = 0;
            this.vScrollBar2.Value = 255;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 313);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.textrgb);
            this.Controls.Add(this.Clr);
            this.Controls.Add(this.vScrollBar3);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.UPD);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Clr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private Button button1;
        private ComboBox comboBox;
        private Button button2;
        private Button button3;
        private VScrollBar vScrollBar1;
        private PictureBox Clr;
        private Label textrgb;
        private Button UPD;
        private Label txt2;
        private VScrollBar vScrollBar3;
        private VScrollBar vScrollBar2;
    }
}