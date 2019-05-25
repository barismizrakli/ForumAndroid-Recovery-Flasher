namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.recoveryoluTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.Qualcomm = new System.Windows.Forms.RadioButton();
            this.MT67XX = new System.Windows.Forms.RadioButton();
            this.MT65XX = new System.Windows.Forms.RadioButton();
            this.console = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.kalıcıCheckBox = new System.Windows.Forms.CheckBox();
            this.tekseferlikCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Seç >";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // recoveryoluTextBox
            // 
            this.recoveryoluTextBox.Enabled = false;
            this.recoveryoluTextBox.Location = new System.Drawing.Point(82, 19);
            this.recoveryoluTextBox.Name = "recoveryoluTextBox";
            this.recoveryoluTextBox.Size = new System.Drawing.Size(224, 20);
            this.recoveryoluTextBox.TabIndex = 1;
            this.recoveryoluTextBox.Text = "< Recovery Yolu >";
            this.recoveryoluTextBox.TextChanged += new System.EventHandler(this.recoveryoluTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.recoveryoluTextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recovery Seçiniz >";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recovery Seçimiz Bekleniyor...";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkRed;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(141, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 23);
            this.button5.TabIndex = 73;
            this.button5.Text = "Normal Aç >";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(6, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "FastBoot Mode Geç >";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.Qualcomm);
            this.groupBox2.Controls.Add(this.MT67XX);
            this.groupBox2.Controls.Add(this.MT65XX);
            this.groupBox2.Location = new System.Drawing.Point(12, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 49);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemci Seçiniz >";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkRed;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(356, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 23);
            this.button6.TabIndex = 74;
            this.button6.Text = "Seçimlerimi Temizle";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Qualcomm
            // 
            this.Qualcomm.AutoSize = true;
            this.Qualcomm.Location = new System.Drawing.Point(104, 20);
            this.Qualcomm.Name = "Qualcomm";
            this.Qualcomm.Size = new System.Drawing.Size(138, 17);
            this.Qualcomm.TabIndex = 2;
            this.Qualcomm.TabStop = true;
            this.Qualcomm.Text = "Qualcomm SnapDragon";
            this.Qualcomm.UseVisualStyleBackColor = true;
            this.Qualcomm.CheckedChanged += new System.EventHandler(this.Qualcomm_CheckedChanged);
            // 
            // MT67XX
            // 
            this.MT67XX.AutoSize = true;
            this.MT67XX.Location = new System.Drawing.Point(6, 20);
            this.MT67XX.Name = "MT67XX";
            this.MT67XX.Size = new System.Drawing.Size(73, 17);
            this.MT67XX.TabIndex = 1;
            this.MT67XX.TabStop = true;
            this.MT67XX.Text = "MediaTek";
            this.MT67XX.UseVisualStyleBackColor = true;
            this.MT67XX.CheckedChanged += new System.EventHandler(this.MT67XX_CheckedChanged);
            // 
            // MT65XX
            // 
            this.MT65XX.AutoSize = true;
            this.MT65XX.Location = new System.Drawing.Point(256, 19);
            this.MT65XX.Name = "MT65XX";
            this.MT65XX.Size = new System.Drawing.Size(50, 17);
            this.MT65XX.TabIndex = 0;
            this.MT65XX.TabStop = true;
            this.MT65XX.Text = "Diğer";
            this.MT65XX.UseVisualStyleBackColor = true;
            this.MT65XX.CheckedChanged += new System.EventHandler(this.MT65XX_CheckedChanged);
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(12, 317);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(451, 99);
            this.console.TabIndex = 4;
            this.console.Text = "";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(368, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Recovery Yükle >";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kalıcıCheckBox
            // 
            this.kalıcıCheckBox.AutoSize = true;
            this.kalıcıCheckBox.BackColor = System.Drawing.Color.Red;
            this.kalıcıCheckBox.ForeColor = System.Drawing.Color.White;
            this.kalıcıCheckBox.Location = new System.Drawing.Point(153, 290);
            this.kalıcıCheckBox.Name = "kalıcıCheckBox";
            this.kalıcıCheckBox.Size = new System.Drawing.Size(95, 17);
            this.kalıcıCheckBox.TabIndex = 8;
            this.kalıcıCheckBox.Text = "Kalıcı Yükleme";
            this.kalıcıCheckBox.UseVisualStyleBackColor = false;
            this.kalıcıCheckBox.CheckedChanged += new System.EventHandler(this.kalıcıCheckBox_CheckedChanged);
            // 
            // tekseferlikCheckBox
            // 
            this.tekseferlikCheckBox.AutoSize = true;
            this.tekseferlikCheckBox.BackColor = System.Drawing.Color.Red;
            this.tekseferlikCheckBox.ForeColor = System.Drawing.Color.White;
            this.tekseferlikCheckBox.Location = new System.Drawing.Point(18, 290);
            this.tekseferlikCheckBox.Name = "tekseferlikCheckBox";
            this.tekseferlikCheckBox.Size = new System.Drawing.Size(113, 17);
            this.tekseferlikCheckBox.TabIndex = 7;
            this.tekseferlikCheckBox.Text = "Tek Seferlik Yükle";
            this.tekseferlikCheckBox.UseVisualStyleBackColor = false;
            this.tekseferlikCheckBox.CheckedChanged += new System.EventHandler(this.tekseferlikCheckBox_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.pictureBox1);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox9.Location = new System.Drawing.Point(12, 422);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(599, 57);
            this.groupBox9.TabIndex = 71;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Cihaz Algılayıcı";
            this.groupBox9.Enter += new System.EventHandler(this.groupBox9_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(336, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 17);
            this.label12.TabIndex = 67;
            this.label12.Text = "Android Versiyon :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(90, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 65;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(490, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 17);
            this.label13.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(177, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 66;
            this.label11.Text = "Model :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(34, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 64;
            this.label9.Text = "Marka :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(242, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 62;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FloralWhite;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(469, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 50);
            this.button4.TabIndex = 72;
            this.button4.Text = "Cihaz Durumunu Güncelle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(525, 484);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Barış MIZRAKLI";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(493, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = ">_";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.barismizrakli;
            this.pictureBox2.Location = new System.Drawing.Point(-607, -220);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1863, 365);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(627, 502);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kalıcıCheckBox);
            this.Controls.Add(this.tekseferlikCheckBox);
            this.Controls.Add(this.console);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GSM Turkey Recovery Tool V1.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox recoveryoluTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Qualcomm;
        private System.Windows.Forms.RadioButton MT67XX;
        private System.Windows.Forms.RadioButton MT65XX;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox kalıcıCheckBox;
        private System.Windows.Forms.CheckBox tekseferlikCheckBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

