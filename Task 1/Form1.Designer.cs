namespace Task_1
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
            this.Bakubtt = new System.Windows.Forms.Button();
            this.londonbtt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bakubtt
            // 
            this.Bakubtt.AutoSize = true;
            this.Bakubtt.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bakubtt.Location = new System.Drawing.Point(591, 321);
            this.Bakubtt.Name = "Bakubtt";
            this.Bakubtt.Size = new System.Drawing.Size(246, 118);
            this.Bakubtt.TabIndex = 0;
            this.Bakubtt.Text = "Baku";
            this.Bakubtt.UseVisualStyleBackColor = true;
            this.Bakubtt.Click += new System.EventHandler(this.Bakubtt_Click);
            // 
            // londonbtt
            // 
            this.londonbtt.AutoSize = true;
            this.londonbtt.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.londonbtt.Location = new System.Drawing.Point(71, 342);
            this.londonbtt.Name = "londonbtt";
            this.londonbtt.Size = new System.Drawing.Size(258, 91);
            this.londonbtt.TabIndex = 1;
            this.londonbtt.Text = "London";
            this.londonbtt.UseVisualStyleBackColor = true;
            this.londonbtt.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1005, 526);
            this.Controls.Add(this.londonbtt);
            this.Controls.Add(this.Bakubtt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bakubtt;
        private System.Windows.Forms.Button londonbtt;
    }
}

