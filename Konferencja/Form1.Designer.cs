namespace Konferencja
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nazwaSesjiTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dodaj = new System.Windows.Forms.Button();
            this.zaplanuj = new System.Windows.Forms.Button();
            this.wyczysc = new System.Windows.Forms.Button();
            this.zledane = new System.Windows.Forms.Label();
            this.godzinaRTextbox = new System.Windows.Forms.TextBox();
            this.minutaRTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minutaZTextbox = new System.Windows.Forms.TextBox();
            this.godzinaZTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.wyjdzButton = new System.Windows.Forms.Button();
            this.wypisanesesje = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wpisz nazwy oraz godziny sesji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Godzina rozpoczęcia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Godzina zakończenia";
            // 
            // nazwaSesjiTextbox
            // 
            this.nazwaSesjiTextbox.Location = new System.Drawing.Point(153, 32);
            this.nazwaSesjiTextbox.MaxLength = 100;
            this.nazwaSesjiTextbox.Name = "nazwaSesjiTextbox";
            this.nazwaSesjiTextbox.Size = new System.Drawing.Size(159, 20);
            this.nazwaSesjiTextbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Wpisane sesje";
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(24, 168);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 34);
            this.dodaj.TabIndex = 9;
            this.dodaj.Text = "Dodaj sesję";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // zaplanuj
            // 
            this.zaplanuj.Location = new System.Drawing.Point(24, 233);
            this.zaplanuj.Name = "zaplanuj";
            this.zaplanuj.Size = new System.Drawing.Size(75, 34);
            this.zaplanuj.TabIndex = 10;
            this.zaplanuj.Text = "Zaplanuj konferencję";
            this.zaplanuj.UseVisualStyleBackColor = true;
            this.zaplanuj.Click += new System.EventHandler(this.zaplanuj_Click);
            // 
            // wyczysc
            // 
            this.wyczysc.Location = new System.Drawing.Point(236, 168);
            this.wyczysc.Name = "wyczysc";
            this.wyczysc.Size = new System.Drawing.Size(75, 34);
            this.wyczysc.TabIndex = 11;
            this.wyczysc.Text = "Wyczyść wpisane sesje";
            this.wyczysc.UseVisualStyleBackColor = true;
            this.wyczysc.Click += new System.EventHandler(this.wyczysc_Click);
            // 
            // zledane
            // 
            this.zledane.AutoSize = true;
            this.zledane.Location = new System.Drawing.Point(22, 141);
            this.zledane.Name = "zledane";
            this.zledane.Size = new System.Drawing.Size(0, 13);
            this.zledane.TabIndex = 12;
            // 
            // godzinaRTextbox
            // 
            this.godzinaRTextbox.Location = new System.Drawing.Point(153, 62);
            this.godzinaRTextbox.MaxLength = 2;
            this.godzinaRTextbox.Name = "godzinaRTextbox";
            this.godzinaRTextbox.Size = new System.Drawing.Size(33, 20);
            this.godzinaRTextbox.TabIndex = 14;
            // 
            // minutaRTextbox
            // 
            this.minutaRTextbox.Location = new System.Drawing.Point(208, 62);
            this.minutaRTextbox.MaxLength = 2;
            this.minutaRTextbox.Name = "minutaRTextbox";
            this.minutaRTextbox.Size = new System.Drawing.Size(33, 20);
            this.minutaRTextbox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = ":";
            // 
            // minutaZTextbox
            // 
            this.minutaZTextbox.Location = new System.Drawing.Point(208, 91);
            this.minutaZTextbox.MaxLength = 2;
            this.minutaZTextbox.Name = "minutaZTextbox";
            this.minutaZTextbox.Size = new System.Drawing.Size(33, 20);
            this.minutaZTextbox.TabIndex = 18;
            // 
            // godzinaZTextbox
            // 
            this.godzinaZTextbox.Location = new System.Drawing.Point(153, 91);
            this.godzinaZTextbox.MaxLength = 2;
            this.godzinaZTextbox.Name = "godzinaZTextbox";
            this.godzinaZTextbox.Size = new System.Drawing.Size(33, 20);
            this.godzinaZTextbox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "Ustaw liczbę sal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wyjdzButton
            // 
            this.wyjdzButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.wyjdzButton.Location = new System.Drawing.Point(129, 233);
            this.wyjdzButton.Margin = new System.Windows.Forms.Padding(2);
            this.wyjdzButton.Name = "wyjdzButton";
            this.wyjdzButton.Size = new System.Drawing.Size(75, 34);
            this.wyjdzButton.TabIndex = 23;
            this.wyjdzButton.Text = "Wyjdź";
            this.wyjdzButton.UseVisualStyleBackColor = true;
            this.wyjdzButton.Click += new System.EventHandler(this.wyjdzButton_Click);
            // 
            // wypisanesesje
            // 
            this.wypisanesesje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wypisanesesje.Cursor = System.Windows.Forms.Cursors.Default;
            this.wypisanesesje.DetectUrls = false;
            this.wypisanesesje.HideSelection = false;
            this.wypisanesesje.Location = new System.Drawing.Point(379, 32);
            this.wypisanesesje.Name = "wypisanesesje";
            this.wypisanesesje.ReadOnly = true;
            this.wypisanesesje.Size = new System.Drawing.Size(182, 241);
            this.wypisanesesje.TabIndex = 24;
            this.wypisanesesje.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 288);
            this.Controls.Add(this.wypisanesesje);
            this.Controls.Add(this.wyjdzButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minutaZTextbox);
            this.Controls.Add(this.godzinaZTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minutaRTextbox);
            this.Controls.Add(this.godzinaRTextbox);
            this.Controls.Add(this.zledane);
            this.Controls.Add(this.wyczysc);
            this.Controls.Add(this.zaplanuj);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nazwaSesjiTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaplanowanie konferencji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nazwaSesjiTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button zaplanuj;
        private System.Windows.Forms.Button wyczysc;
        private System.Windows.Forms.Label zledane;
        private System.Windows.Forms.TextBox godzinaRTextbox;
        private System.Windows.Forms.TextBox minutaRTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox minutaZTextbox;
        private System.Windows.Forms.TextBox godzinaZTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button wyjdzButton;
        private System.Windows.Forms.RichTextBox wypisanesesje;
    }
}

