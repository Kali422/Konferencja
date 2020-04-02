namespace Konferencja
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
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Sale = new System.Windows.Forms.Label();
            this.tablica = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 327);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ilość dostępnych sal:";
            // 
            // Sale
            // 
            this.Sale.AutoSize = true;
            this.Sale.Location = new System.Drawing.Point(124, 9);
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(0, 13);
            this.Sale.TabIndex = 23;
            // 
            // tablica
            // 
            this.tablica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablica.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tablica.Location = new System.Drawing.Point(9, 25);
            this.tablica.Name = "tablica";
            this.tablica.ReadOnly = true;
            this.tablica.Size = new System.Drawing.Size(283, 297);
            this.tablica.TabIndex = 24;
            this.tablica.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 365);
            this.Controls.Add(this.tablica);
            this.Controls.Add(this.Sale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan konferencji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label Sale;
        public System.Windows.Forms.RichTextBox tablica;
    }
}