namespace Uppgift8._2
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
            this.tbxRed = new System.Windows.Forms.TextBox();
            this.tbxGreen = new System.Windows.Forms.TextBox();
            this.tbxBlue = new System.Windows.Forms.TextBox();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxRed
            // 
            this.tbxRed.Location = new System.Drawing.Point(191, 130);
            this.tbxRed.Name = "tbxRed";
            this.tbxRed.Size = new System.Drawing.Size(100, 26);
            this.tbxRed.TabIndex = 0;
            // 
            // tbxGreen
            // 
            this.tbxGreen.Location = new System.Drawing.Point(349, 130);
            this.tbxGreen.Name = "tbxGreen";
            this.tbxGreen.Size = new System.Drawing.Size(100, 26);
            this.tbxGreen.TabIndex = 1;
            // 
            // tbxBlue
            // 
            this.tbxBlue.Location = new System.Drawing.Point(494, 130);
            this.tbxBlue.Name = "tbxBlue";
            this.tbxBlue.Size = new System.Drawing.Size(100, 26);
            this.tbxBlue.TabIndex = 2;
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(624, 120);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(141, 36);
            this.btnChangeColor.TabIndex = 3;
            this.btnChangeColor.Text = "Change color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(218, 107);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(39, 20);
            this.lblRed.TabIndex = 4;
            this.lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(369, 107);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(54, 20);
            this.lblGreen.TabIndex = 5;
            this.lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(525, 107);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(39, 20);
            this.lblBlue.TabIndex = 6;
            this.lblBlue.Text = "blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.tbxBlue);
            this.Controls.Add(this.tbxGreen);
            this.Controls.Add(this.tbxRed);
            this.Name = "Form1";
            this.Text = "Uppgift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRed;
        private System.Windows.Forms.TextBox tbxGreen;
        private System.Windows.Forms.TextBox tbxBlue;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
    }
}

