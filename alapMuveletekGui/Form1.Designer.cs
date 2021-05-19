
namespace alapMuveletekGui
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Ellenorzes = new System.Windows.Forms.Button();
            this.OsztasGomb = new System.Windows.Forms.Button();
            this.KivonasGomb = new System.Windows.Forms.Button();
            this.OsszeadasGomb = new System.Windows.Forms.Button();
            this.SzorzasGomb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KerdesBox = new System.Windows.Forms.TextBox();
            this.ValaszBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Ellenorzes);
            this.groupBox1.Controls.Add(this.OsztasGomb);
            this.groupBox1.Controls.Add(this.KivonasGomb);
            this.groupBox1.Controls.Add(this.OsszeadasGomb);
            this.groupBox1.Controls.Add(this.SzorzasGomb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.KerdesBox);
            this.groupBox1.Controls.Add(this.ValaszBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feladat";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Megoldás";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Új feladat";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Ellenorzes
            // 
            this.Ellenorzes.Location = new System.Drawing.Point(84, 159);
            this.Ellenorzes.Name = "Ellenorzes";
            this.Ellenorzes.Size = new System.Drawing.Size(255, 23);
            this.Ellenorzes.TabIndex = 9;
            this.Ellenorzes.Text = "Ellenőrzés";
            this.Ellenorzes.UseVisualStyleBackColor = true;
            this.Ellenorzes.Click += new System.EventHandler(this.Ellenorzes_Click);
            // 
            // OsztasGomb
            // 
            this.OsztasGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OsztasGomb.Location = new System.Drawing.Point(358, 35);
            this.OsztasGomb.Name = "OsztasGomb";
            this.OsztasGomb.Size = new System.Drawing.Size(84, 44);
            this.OsztasGomb.TabIndex = 8;
            this.OsztasGomb.Text = "/";
            this.OsztasGomb.UseVisualStyleBackColor = true;
            this.OsztasGomb.Click += new System.EventHandler(this.btnOsztas_Click);
            // 
            // KivonasGomb
            // 
            this.KivonasGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KivonasGomb.Location = new System.Drawing.Point(255, 35);
            this.KivonasGomb.Name = "KivonasGomb";
            this.KivonasGomb.Size = new System.Drawing.Size(84, 44);
            this.KivonasGomb.TabIndex = 7;
            this.KivonasGomb.Text = "-";
            this.KivonasGomb.UseVisualStyleBackColor = true;
            this.KivonasGomb.Click += new System.EventHandler(this.btnKivonas_Click);
            // 
            // OsszeadasGomb
            // 
            this.OsszeadasGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OsszeadasGomb.Location = new System.Drawing.Point(146, 35);
            this.OsszeadasGomb.Name = "OsszeadasGomb";
            this.OsszeadasGomb.Size = new System.Drawing.Size(84, 44);
            this.OsszeadasGomb.TabIndex = 6;
            this.OsszeadasGomb.Text = "+";
            this.OsszeadasGomb.UseVisualStyleBackColor = true;
            this.OsszeadasGomb.Click += new System.EventHandler(this.btnOsszeadas_Click);
            // 
            // SzorzasGomb
            // 
            this.SzorzasGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SzorzasGomb.Location = new System.Drawing.Point(38, 35);
            this.SzorzasGomb.Name = "SzorzasGomb";
            this.SzorzasGomb.Size = new System.Drawing.Size(86, 44);
            this.SzorzasGomb.TabIndex = 5;
            this.SzorzasGomb.Text = "*";
            this.SzorzasGomb.UseVisualStyleBackColor = true;
            this.SzorzasGomb.Click += new System.EventHandler(this.btnSzorzas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kérdés:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(206, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // KerdesBox
            // 
            this.KerdesBox.Location = new System.Drawing.Point(84, 124);
            this.KerdesBox.Name = "KerdesBox";
            this.KerdesBox.Size = new System.Drawing.Size(100, 20);
            this.KerdesBox.TabIndex = 2;
            // 
            // ValaszBox
            // 
            this.ValaszBox.Location = new System.Drawing.Point(255, 124);
            this.ValaszBox.Name = "ValaszBox";
            this.ValaszBox.Size = new System.Drawing.Size(100, 20);
            this.ValaszBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statisztika";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "0";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Próbálkozások száma: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kérdések száma összesen: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Eredmény %-ban: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "100%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Szorzás: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Összeadás:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Kivonás:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Osztás:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(280, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(291, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(280, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(279, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Alapműveletek Gyakorló Program";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OsztasGomb;
        private System.Windows.Forms.Button KivonasGomb;
        private System.Windows.Forms.Button OsszeadasGomb;
        private System.Windows.Forms.Button SzorzasGomb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KerdesBox;
        private System.Windows.Forms.TextBox ValaszBox;
        private System.Windows.Forms.Button Ellenorzes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

