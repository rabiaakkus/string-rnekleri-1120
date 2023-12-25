namespace string_ornekleri_1120
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
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnBuyut = new System.Windows.Forms.Button();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnKucult = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSay = new System.Windows.Forms.Button();
            this.btnBirlestir = new System.Windows.Forms.Button();
            this.btnSiraGetir = new System.Windows.Forms.Button();
            this.btnKacis = new System.Windows.Forms.Button();
            this.btnKarsilastir = new System.Windows.Forms.Button();
            this.btnBicim = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(194, 36);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(226, 24);
            this.lblMesaj.TabIndex = 0;
            this.lblMesaj.Text = "merhaba dünya,ben rabia";
            // 
            // btnBuyut
            // 
            this.btnBuyut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuyut.Location = new System.Drawing.Point(12, 90);
            this.btnBuyut.Name = "btnBuyut";
            this.btnBuyut.Size = new System.Drawing.Size(210, 48);
            this.btnBuyut.TabIndex = 1;
            this.btnBuyut.Text = "Hepsini büyük yap ";
            this.btnBuyut.UseVisualStyleBackColor = true;
            this.btnBuyut.Click += new System.EventHandler(this.btnBuyut_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(28, 36);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(140, 20);
            this.txtMesaj.TabIndex = 2;
            // 
            // btnKucult
            // 
            this.btnKucult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKucult.Location = new System.Drawing.Point(253, 90);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(210, 48);
            this.btnKucult.TabIndex = 3;
            this.btnKucult.Text = "hepsini küçük yap";
            this.btnKucult.UseVisualStyleBackColor = true;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "karakter sayısını getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSay
            // 
            this.btnSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSay.Location = new System.Drawing.Point(253, 164);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(210, 48);
            this.btnSay.TabIndex = 5;
            this.btnSay.Text = "mesaj ver";
            this.btnSay.UseVisualStyleBackColor = true;
            this.btnSay.Click += new System.EventHandler(this.btnMesajVer_Click);
            // 
            // btnBirlestir
            // 
            this.btnBirlestir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirlestir.Location = new System.Drawing.Point(12, 241);
            this.btnBirlestir.Name = "btnBirlestir";
            this.btnBirlestir.Size = new System.Drawing.Size(210, 48);
            this.btnBirlestir.TabIndex = 6;
            this.btnBirlestir.Text = "Metin birleştir";
            this.btnBirlestir.UseVisualStyleBackColor = true;
            this.btnBirlestir.Click += new System.EventHandler(this.btnBirlestir_Click);
            // 
            // btnSiraGetir
            // 
            this.btnSiraGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiraGetir.Location = new System.Drawing.Point(253, 241);
            this.btnSiraGetir.Name = "btnSiraGetir";
            this.btnSiraGetir.Size = new System.Drawing.Size(210, 48);
            this.btnSiraGetir.TabIndex = 7;
            this.btnSiraGetir.Text = "sira getir";
            this.btnSiraGetir.UseVisualStyleBackColor = true;
            this.btnSiraGetir.Click += new System.EventHandler(this.btnSiraGetir_Click);
            // 
            // btnKacis
            // 
            this.btnKacis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKacis.Location = new System.Drawing.Point(486, 90);
            this.btnKacis.Name = "btnKacis";
            this.btnKacis.Size = new System.Drawing.Size(210, 48);
            this.btnKacis.TabIndex = 8;
            this.btnKacis.Text = "kacis karakter";
            this.btnKacis.UseVisualStyleBackColor = true;
            this.btnKacis.Click += new System.EventHandler(this.btnKacis_Click);
            // 
            // btnKarsilastir
            // 
            this.btnKarsilastir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKarsilastir.Location = new System.Drawing.Point(486, 164);
            this.btnKarsilastir.Name = "btnKarsilastir";
            this.btnKarsilastir.Size = new System.Drawing.Size(210, 48);
            this.btnKarsilastir.TabIndex = 9;
            this.btnKarsilastir.Text = "karşilaştır";
            this.btnKarsilastir.UseVisualStyleBackColor = true;
            this.btnKarsilastir.Click += new System.EventHandler(this.btnKarsilastir_Click);
            // 
            // btnBicim
            // 
            this.btnBicim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBicim.Location = new System.Drawing.Point(486, 241);
            this.btnBicim.Name = "btnBicim";
            this.btnBicim.Size = new System.Drawing.Size(210, 48);
            this.btnBicim.TabIndex = 10;
            this.btnBicim.Text = "string bicimlendirme";
            this.btnBicim.UseVisualStyleBackColor = true;
            this.btnBicim.Click += new System.EventHandler(this.btnBicim_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCompare.Location = new System.Drawing.Point(12, 320);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(210, 48);
            this.btnCompare.TabIndex = 11;
            this.btnCompare.Text = "compare kullanımı";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.Location = new System.Drawing.Point(253, 320);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(210, 48);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "remove kullanımı ";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnContains
            // 
            this.btnContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContains.Location = new System.Drawing.Point(486, 320);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(210, 48);
            this.btnContains.TabIndex = 13;
            this.btnContains.Text = "contains kullanımı";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReplace.Location = new System.Drawing.Point(12, 397);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(210, 48);
            this.btnReplace.TabIndex = 14;
            this.btnReplace.Text = "replace kullanımı";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(725, 457);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnBicim);
            this.Controls.Add(this.btnKarsilastir);
            this.Controls.Add(this.btnKacis);
            this.Controls.Add(this.btnSiraGetir);
            this.Controls.Add(this.btnBirlestir);
            this.Controls.Add(this.btnSay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKucult);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.btnBuyut);
            this.Controls.Add(this.lblMesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnBuyut;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSay;
        private System.Windows.Forms.Button btnBirlestir;
        private System.Windows.Forms.Button btnSiraGetir;
        private System.Windows.Forms.Button btnKacis;
        private System.Windows.Forms.Button btnKarsilastir;
        private System.Windows.Forms.Button btnBicim;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnReplace;
    }
}

