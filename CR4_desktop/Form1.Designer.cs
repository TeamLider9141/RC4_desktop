namespace CR4_desktop
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
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            textData = new TextBox();
            label3 = new Label();
            textKey = new TextBox();
            textShow = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(83, 74);
            label2.Name = "label2";
            label2.Size = new Size(173, 23);
            label2.TabIndex = 7;
            label2.Text = "Ma'lumotni kiriting:";
            label2.UseWaitCursor = true;
            // 
            // textData
            // 
            textData.Location = new Point(262, 73);
            textData.Name = "textData";
            textData.Size = new Size(449, 27);
            textData.TabIndex = 11;
            textData.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(124, 185);
            label3.Name = "label3";
            label3.Size = new Size(132, 23);
            label3.TabIndex = 12;
            label3.Text = "Kalitni kiriting:";
            label3.UseWaitCursor = true;
            // 
            // textKey
            // 
            textKey.Location = new Point(262, 184);
            textKey.Name = "textKey";
            textKey.Size = new Size(449, 27);
            textKey.TabIndex = 13;
            textKey.UseWaitCursor = true;
            // 
            // textShow
            // 
            textShow.Location = new Point(262, 275);
            textShow.Name = "textShow";
            textShow.Size = new Size(449, 27);
            textShow.TabIndex = 14;
            textShow.UseWaitCursor = true;
            textShow.TextChanged += textShow_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(140, 275);
            button1.Name = "button1";
            button1.Size = new Size(105, 29);
            button1.TabIndex = 15;
            button1.Text = "Shifrlash\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.MidnightBlue;
            button2.Location = new Point(140, 350);
            button2.Name = "button2";
            button2.Size = new Size(105, 29);
            button2.TabIndex = 16;
            button2.Text = "Deshifrlash";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 318);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 17;
            label1.Text = "show:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 350);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(449, 27);
            textBox1.TabIndex = 18;
            textBox1.UseWaitCursor = true;
            textBox1.TextChanged += textShow2_TextChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(357, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 19;
            button3.Text = "Exit\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textShow);
            Controls.Add(textKey);
            Controls.Add(label3);
            Controls.Add(textData);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "RC4 algoritmi yordamida yaratilgan shifrlash va deshifrlash dasturi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textData;
        private Label label3;
        private TextBox textKey;
        private TextBox textShow;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
    }
}