namespace Routing
{
    partial class MainForm
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
            this.labelParA = new System.Windows.Forms.Label();
            this.labelParB = new System.Windows.Forms.Label();
            this.labelParC = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelParA
            // 
            this.labelParA.AutoSize = true;
            this.labelParA.Location = new System.Drawing.Point(12, 9);
            this.labelParA.Name = "labelParA";
            this.labelParA.Size = new System.Drawing.Size(14, 13);
            this.labelParA.TabIndex = 0;
            this.labelParA.Text = "A";
            // 
            // labelParB
            // 
            this.labelParB.AutoSize = true;
            this.labelParB.Location = new System.Drawing.Point(12, 77);
            this.labelParB.Name = "labelParB";
            this.labelParB.Size = new System.Drawing.Size(14, 13);
            this.labelParB.TabIndex = 1;
            this.labelParB.Text = "B";
            // 
            // labelParC
            // 
            this.labelParC.AutoSize = true;
            this.labelParC.Location = new System.Drawing.Point(9, 155);
            this.labelParC.Name = "labelParC";
            this.labelParC.Size = new System.Drawing.Size(35, 13);
            this.labelParC.TabIndex = 2;
            this.labelParC.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 361);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelParC);
            this.Controls.Add(this.labelParB);
            this.Controls.Add(this.labelParA);
            this.Name = "MainForm";
            this.Text = "Routing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelParA;
        private System.Windows.Forms.Label labelParB;
        private System.Windows.Forms.Label labelParC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

