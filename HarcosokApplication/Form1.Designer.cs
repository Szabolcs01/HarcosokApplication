namespace HarcosokApplication
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
            this.btn_létrehoz = new System.Windows.Forms.Button();
            this.btn_hozzaad = new System.Windows.Forms.Button();
            this.btn_modosit = new System.Windows.Forms.Button();
            this.btn_Törlés = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_harcosNeve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_kepességekneve = new System.Windows.Forms.TextBox();
            this.textBox_leírás = new System.Windows.Forms.TextBox();
            this.comboBox_használó = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_képességekleírása = new System.Windows.Forms.TextBox();
            this.listBox_harcosok = new System.Windows.Forms.ListBox();
            this.listBox_képességek = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_létrehoz
            // 
            this.btn_létrehoz.Location = new System.Drawing.Point(173, 35);
            this.btn_létrehoz.Name = "btn_létrehoz";
            this.btn_létrehoz.Size = new System.Drawing.Size(75, 23);
            this.btn_létrehoz.TabIndex = 0;
            this.btn_létrehoz.Text = "LétreHozzás";
            this.btn_létrehoz.UseVisualStyleBackColor = true;
            this.btn_létrehoz.Click += new System.EventHandler(this.btn_létrehoz_Click);
            // 
            // btn_hozzaad
            // 
            this.btn_hozzaad.Location = new System.Drawing.Point(12, 185);
            this.btn_hozzaad.Name = "btn_hozzaad";
            this.btn_hozzaad.Size = new System.Drawing.Size(75, 23);
            this.btn_hozzaad.TabIndex = 1;
            this.btn_hozzaad.Text = "Hozzáad";
            this.btn_hozzaad.UseVisualStyleBackColor = true;
            this.btn_hozzaad.Click += new System.EventHandler(this.btn_hozzaad_Click);
            // 
            // btn_modosit
            // 
            this.btn_modosit.Location = new System.Drawing.Point(403, 284);
            this.btn_modosit.Name = "btn_modosit";
            this.btn_modosit.Size = new System.Drawing.Size(75, 23);
            this.btn_modosit.TabIndex = 2;
            this.btn_modosit.Text = "Módósít";
            this.btn_modosit.UseVisualStyleBackColor = true;
            this.btn_modosit.Click += new System.EventHandler(this.btn_modosit_Click);
            // 
            // btn_Törlés
            // 
            this.btn_Törlés.Location = new System.Drawing.Point(189, 426);
            this.btn_Törlés.Name = "btn_Törlés";
            this.btn_Törlés.Size = new System.Drawing.Size(75, 23);
            this.btn_Törlés.TabIndex = 3;
            this.btn_Törlés.Text = "Törlés";
            this.btn_Törlés.UseVisualStyleBackColor = true;
            this.btn_Törlés.Click += new System.EventHandler(this.btn_Törlés_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Harcos létrehozzása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Név";
            // 
            // text_harcosNeve
            // 
            this.text_harcosNeve.Location = new System.Drawing.Point(45, 35);
            this.text_harcosNeve.Name = "text_harcosNeve";
            this.text_harcosNeve.Size = new System.Drawing.Size(100, 20);
            this.text_harcosNeve.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "KépességekHOzzáadása";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Használó:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Leírás";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Név";
            // 
            // textBox_kepességekneve
            // 
            this.textBox_kepességekneve.Location = new System.Drawing.Point(72, 150);
            this.textBox_kepességekneve.Name = "textBox_kepességekneve";
            this.textBox_kepességekneve.Size = new System.Drawing.Size(100, 20);
            this.textBox_kepességekneve.TabIndex = 11;
            // 
            // textBox_leírás
            // 
            this.textBox_leírás.Location = new System.Drawing.Point(278, 114);
            this.textBox_leírás.Name = "textBox_leírás";
            this.textBox_leírás.Size = new System.Drawing.Size(200, 20);
            this.textBox_leírás.TabIndex = 12;
            // 
            // comboBox_használó
            // 
            this.comboBox_használó.FormattingEnabled = true;
            this.comboBox_használó.Location = new System.Drawing.Point(72, 116);
            this.comboBox_használó.Name = "comboBox_használó";
            this.comboBox_használó.Size = new System.Drawing.Size(121, 21);
            this.comboBox_használó.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Képességek Leírása";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Képességei:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Harcosok:";
            // 
            // textBox_képességekleírása
            // 
            this.textBox_képességekleírása.Location = new System.Drawing.Point(278, 258);
            this.textBox_képességekleírása.Name = "textBox_képességekleírása";
            this.textBox_képességekleírása.Size = new System.Drawing.Size(200, 20);
            this.textBox_képességekleírása.TabIndex = 17;
            // 
            // listBox_harcosok
            // 
            this.listBox_harcosok.FormattingEnabled = true;
            this.listBox_harcosok.Location = new System.Drawing.Point(15, 248);
            this.listBox_harcosok.Name = "listBox_harcosok";
            this.listBox_harcosok.Size = new System.Drawing.Size(91, 160);
            this.listBox_harcosok.TabIndex = 18;
            // 
            // listBox_képességek
            // 
            this.listBox_képességek.FormattingEnabled = true;
            this.listBox_képességek.Location = new System.Drawing.Point(159, 248);
            this.listBox_képességek.Name = "listBox_képességek";
            this.listBox_képességek.Size = new System.Drawing.Size(105, 160);
            this.listBox_képességek.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 461);
            this.Controls.Add(this.listBox_képességek);
            this.Controls.Add(this.listBox_harcosok);
            this.Controls.Add(this.textBox_képességekleírása);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_használó);
            this.Controls.Add(this.textBox_leírás);
            this.Controls.Add(this.textBox_kepességekneve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_harcosNeve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Törlés);
            this.Controls.Add(this.btn_modosit);
            this.Controls.Add(this.btn_hozzaad);
            this.Controls.Add(this.btn_létrehoz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_létrehoz;
        private System.Windows.Forms.Button btn_hozzaad;
        private System.Windows.Forms.Button btn_modosit;
        private System.Windows.Forms.Button btn_Törlés;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_harcosNeve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_kepességekneve;
        private System.Windows.Forms.TextBox textBox_leírás;
        private System.Windows.Forms.ComboBox comboBox_használó;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_képességekleírása;
        private System.Windows.Forms.ListBox listBox_harcosok;
        private System.Windows.Forms.ListBox listBox_képességek;
    }
}

