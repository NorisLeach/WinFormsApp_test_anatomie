namespace WindowsForms_ping_pong
{
    partial class Form2_Tastatura
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_Tastatura));
            this.panel1_playground = new System.Windows.Forms.Panel();
            this.pictureBox_Ronaldo = new System.Windows.Forms.PictureBox();
            this.pictureBox_Ballon = new System.Windows.Forms.PictureBox();
            this.label1_punctaj = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1_playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ronaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ballon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_playground
            // 
            this.panel1_playground.Controls.Add(this.label1_punctaj);
            this.panel1_playground.Controls.Add(this.pictureBox_Ballon);
            this.panel1_playground.Controls.Add(this.pictureBox_Ronaldo);
            this.panel1_playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_playground.Location = new System.Drawing.Point(0, 0);
            this.panel1_playground.Name = "panel1_playground";
            this.panel1_playground.Size = new System.Drawing.Size(800, 450);
            this.panel1_playground.TabIndex = 0;
            // 
            // pictureBox_Ronaldo
            // 
            this.pictureBox_Ronaldo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Ronaldo.Image")));
            this.pictureBox_Ronaldo.Location = new System.Drawing.Point(335, 290);
            this.pictureBox_Ronaldo.Name = "pictureBox_Ronaldo";
            this.pictureBox_Ronaldo.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_Ronaldo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Ronaldo.TabIndex = 0;
            this.pictureBox_Ronaldo.TabStop = false;
            this.pictureBox_Ronaldo.Click += new System.EventHandler(this.pictureBox_Ronaldo_Click);
            // 
            // pictureBox_Ballon
            // 
            this.pictureBox_Ballon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Ballon.Image")));
            this.pictureBox_Ballon.Location = new System.Drawing.Point(366, 78);
            this.pictureBox_Ballon.Name = "pictureBox_Ballon";
            this.pictureBox_Ballon.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_Ballon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Ballon.TabIndex = 1;
            this.pictureBox_Ballon.TabStop = false;
            this.pictureBox_Ballon.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1_punctaj
            // 
            this.label1_punctaj.AutoSize = true;
            this.label1_punctaj.Location = new System.Drawing.Point(32, 23);
            this.label1_punctaj.Name = "label1_punctaj";
            this.label1_punctaj.Size = new System.Drawing.Size(0, 16);
            this.label1_punctaj.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2_Tastatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1_playground);
            this.Name = "Form2_Tastatura";
            this.Text = "Form2_Tastatura";
            this.panel1_playground.ResumeLayout(false);
            this.panel1_playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ronaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ballon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_playground;
        private System.Windows.Forms.Label label1_punctaj;
        private System.Windows.Forms.PictureBox pictureBox_Ballon;
        private System.Windows.Forms.PictureBox pictureBox_Ronaldo;
        private System.Windows.Forms.Timer timer1;
    }
}