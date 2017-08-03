namespace DesignPatterns
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
            this.label2 = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbFirst = new System.Windows.Forms.Label();
            this.lbLast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(210, 75);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(100, 22);
            this.txName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbFirst
            // 
            this.lbFirst.AutoSize = true;
            this.lbFirst.Location = new System.Drawing.Point(72, 214);
            this.lbFirst.Name = "lbFirst";
            this.lbFirst.Size = new System.Drawing.Size(35, 17);
            this.lbFirst.TabIndex = 3;
            this.lbFirst.Text = "First";
            // 
            // lbLast
            // 
            this.lbLast.AutoSize = true;
            this.lbLast.Location = new System.Drawing.Point(72, 265);
            this.lbLast.Name = "lbLast";
            this.lbLast.Size = new System.Drawing.Size(35, 17);
            this.lbLast.TabIndex = 4;
            this.lbLast.Text = "Last";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(371, 321);
            this.Controls.Add(this.lbLast);
            this.Controls.Add(this.lbFirst);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txFirst;
        private System.Windows.Forms.Label txLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbFirst;
        private System.Windows.Forms.Label lbLast;
    }
}

