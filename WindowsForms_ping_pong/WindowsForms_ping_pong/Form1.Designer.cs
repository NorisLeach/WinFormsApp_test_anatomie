namespace WindowsForms_ping_pong
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
            this.button1_mouse = new System.Windows.Forms.Button();
            this.button1_tastatura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_mouse
            // 
            this.button1_mouse.Location = new System.Drawing.Point(250, 294);
            this.button1_mouse.Name = "button1_mouse";
            this.button1_mouse.Size = new System.Drawing.Size(75, 23);
            this.button1_mouse.TabIndex = 0;
            this.button1_mouse.Text = "Mouse";
            this.button1_mouse.UseVisualStyleBackColor = true;
            this.button1_mouse.Click += new System.EventHandler(this.button1_mouse_Click);
            // 
            // button1_tastatura
            // 
            this.button1_tastatura.Location = new System.Drawing.Point(472, 294);
            this.button1_tastatura.Name = "button1_tastatura";
            this.button1_tastatura.Size = new System.Drawing.Size(100, 23);
            this.button1_tastatura.TabIndex = 1;
            this.button1_tastatura.Text = "Tastatura";
            this.button1_tastatura.UseVisualStyleBackColor = true;
            this.button1_tastatura.Click += new System.EventHandler(this.button1_tastatura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alege modalitatea de joc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_tastatura);
            this.Controls.Add(this.button1_mouse);
            this.Name = "Form1";
            this.Text = "PING PONG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_mouse;
        private System.Windows.Forms.Button button1_tastatura;
        private System.Windows.Forms.Label label1;
    }
}

