namespace WinFormsApp_test_anatomie_
{
    partial class Form4
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
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 28.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(668, 35);
            label1.Name = "label1";
            label1.Size = new Size(234, 101);
            label1.TabIndex = 0;
            label1.Text = "TEST";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Palatino Linotype", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(53, 197);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1464, 140);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.Font = new Font("Palatino Linotype", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(16, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(568, 95);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.Font = new Font("Palatino Linotype", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(898, 31);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(491, 95);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.Appearance = Appearance.Button;
            radioButton3.Font = new Font("Palatino Linotype", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(16, 214);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(568, 95);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.Appearance = Appearance.Button;
            radioButton4.Font = new Font("Palatino Linotype", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(898, 214);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(491, 95);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Palatino Linotype", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(668, 810);
            button1.Name = "button1";
            button1.Size = new Size(266, 96);
            button1.TabIndex = 6;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Palatino Linotype", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(668, 810);
            button2.Name = "button2";
            button2.Size = new Size(266, 96);
            button2.TabIndex = 7;
            button2.Text = "NEXT";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton4);
            panel1.Location = new Point(53, 365);
            panel1.Name = "panel1";
            panel1.Size = new Size(1447, 392);
            panel1.TabIndex = 8;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1541, 992);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Test";
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button1;
        private Button button2;
        private Panel panel1;
    }
}