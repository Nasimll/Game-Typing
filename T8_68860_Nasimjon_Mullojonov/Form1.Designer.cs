﻿namespace T8_68860_Nasimjon_Mullojonov
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
            this.label1 = new System.Windows.Forms.Label();
            this.wordOnly = new System.Windows.Forms.RadioButton();
            this.sentenceOnly = new System.Windows.Forms.RadioButton();
            this.both = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Game Type";
            // 
            // wordOnly
            // 
            this.wordOnly.AutoSize = true;
            this.wordOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordOnly.Location = new System.Drawing.Point(30, 78);
            this.wordOnly.Name = "wordOnly";
            this.wordOnly.Size = new System.Drawing.Size(108, 20);
            this.wordOnly.TabIndex = 1;
            this.wordOnly.Text = "Words Only";
            this.wordOnly.UseVisualStyleBackColor = true;
            
            // 
            // sentenceOnly
            // 
            this.sentenceOnly.AutoSize = true;
            this.sentenceOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sentenceOnly.Location = new System.Drawing.Point(162, 78);
            this.sentenceOnly.Name = "sentenceOnly";
            this.sentenceOnly.Size = new System.Drawing.Size(136, 20);
            this.sentenceOnly.TabIndex = 2;
            this.sentenceOnly.Text = "Sentances Only";
            this.sentenceOnly.UseVisualStyleBackColor = true;
            // 
            // both
            // 
            this.both.AutoSize = true;
            this.both.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.both.Location = new System.Drawing.Point(321, 78);
            this.both.Name = "both";
            this.both.Size = new System.Drawing.Size(59, 20);
            this.both.TabIndex = 3;
            this.both.Text = "Both";
            this.both.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(29, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(258, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "START";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(468, 187);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.both);
            this.Controls.Add(this.sentenceOnly);
            this.Controls.Add(this.wordOnly);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton wordOnly;
        private System.Windows.Forms.RadioButton sentenceOnly;
        private System.Windows.Forms.RadioButton both;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

