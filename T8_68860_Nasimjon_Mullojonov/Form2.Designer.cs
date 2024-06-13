namespace T8_68860_Nasimjon_Mullojonov
{
    partial class Form2
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
            this.timeDouble = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wordsMixed = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.caution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeDouble
            // 
            this.timeDouble.AutoSize = true;
            this.timeDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeDouble.Location = new System.Drawing.Point(57, 27);
            this.timeDouble.Name = "timeDouble";
            this.timeDouble.Size = new System.Drawing.Size(84, 38);
            this.timeDouble.TabIndex = 0;
            this.timeDouble.Text = "10.0";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.points.Location = new System.Drawing.Point(640, 27);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(40, 38);
            this.points.TabIndex = 1;
            this.points.Text = "P";
            this.points.TextChanged += new System.EventHandler(labelChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(616, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.MyEvent);
            // 
            // wordsMixed
            // 
            this.wordsMixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordsMixed.Location = new System.Drawing.Point(139, 117);
            this.wordsMixed.Name = "wordsMixed";
            this.wordsMixed.Size = new System.Drawing.Size(475, 25);
            this.wordsMixed.TabIndex = 3;
            this.wordsMixed.Text = "smth";
            this.wordsMixed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // caution
            // 
            this.caution.ForeColor = System.Drawing.Color.Red;
            this.caution.Location = new System.Drawing.Point(292, 27);
            this.caution.Name = "caution";
            this.caution.Size = new System.Drawing.Size(180, 50);
            this.caution.TabIndex = 4;
            this.caution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(763, 281);
            this.Controls.Add(this.caution);
            this.Controls.Add(this.wordsMixed);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.points);
            this.Controls.Add(this.timeDouble);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeDouble;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label wordsMixed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label caution;
    }
}