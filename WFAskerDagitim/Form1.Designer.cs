namespace WFAskerDagitim
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
            this.lstAskerList = new System.Windows.Forms.ListBox();
            this.txtAskerEkle = new System.Windows.Forms.TextBox();
            this.btnAskerEkle = new System.Windows.Forms.Button();
            this.lstBolgeList = new System.Windows.Forms.ListBox();
            this.lstDagitim = new System.Windows.Forms.ListBox();
            this.btnDagitimYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimgeDurumu = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAskerList
            // 
            this.lstAskerList.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lstAskerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstAskerList.ForeColor = System.Drawing.SystemColors.Menu;
            this.lstAskerList.FormattingEnabled = true;
            this.lstAskerList.ItemHeight = 16;
            this.lstAskerList.Location = new System.Drawing.Point(13, 34);
            this.lstAskerList.Name = "lstAskerList";
            this.lstAskerList.Size = new System.Drawing.Size(181, 212);
            this.lstAskerList.TabIndex = 0;
            // 
            // txtAskerEkle
            // 
            this.txtAskerEkle.Location = new System.Drawing.Point(13, 252);
            this.txtAskerEkle.Name = "txtAskerEkle";
            this.txtAskerEkle.Size = new System.Drawing.Size(100, 20);
            this.txtAskerEkle.TabIndex = 1;
            this.txtAskerEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAskerEkle_KeyPress);
            // 
            // btnAskerEkle
            // 
            this.btnAskerEkle.Location = new System.Drawing.Point(119, 250);
            this.btnAskerEkle.Name = "btnAskerEkle";
            this.btnAskerEkle.Size = new System.Drawing.Size(75, 23);
            this.btnAskerEkle.TabIndex = 2;
            this.btnAskerEkle.Text = "Asker Ekle";
            this.btnAskerEkle.UseVisualStyleBackColor = true;
            this.btnAskerEkle.Click += new System.EventHandler(this.btnAskerEkle_Click);
            // 
            // lstBolgeList
            // 
            this.lstBolgeList.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lstBolgeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstBolgeList.ForeColor = System.Drawing.SystemColors.Menu;
            this.lstBolgeList.FormattingEnabled = true;
            this.lstBolgeList.ItemHeight = 16;
            this.lstBolgeList.Location = new System.Drawing.Point(214, 34);
            this.lstBolgeList.Name = "lstBolgeList";
            this.lstBolgeList.Size = new System.Drawing.Size(181, 212);
            this.lstBolgeList.TabIndex = 0;
            // 
            // lstDagitim
            // 
            this.lstDagitim.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lstDagitim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstDagitim.ForeColor = System.Drawing.SystemColors.Menu;
            this.lstDagitim.FormattingEnabled = true;
            this.lstDagitim.ItemHeight = 16;
            this.lstDagitim.Location = new System.Drawing.Point(429, 34);
            this.lstDagitim.Name = "lstDagitim";
            this.lstDagitim.Size = new System.Drawing.Size(283, 212);
            this.lstDagitim.TabIndex = 0;
            // 
            // btnDagitimYap
            // 
            this.btnDagitimYap.Location = new System.Drawing.Point(429, 250);
            this.btnDagitimYap.Name = "btnDagitimYap";
            this.btnDagitimYap.Size = new System.Drawing.Size(283, 23);
            this.btnDagitimYap.TabIndex = 2;
            this.btnDagitimYap.Text = "Dağıtım Yap";
            this.btnDagitimYap.UseVisualStyleBackColor = true;
            this.btnDagitimYap.Click += new System.EventHandler(this.btnDagitimYap_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Asker Listesi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(211, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şehir Listesi :";
            // 
            // btnSimgeDurumu
            // 
            this.btnSimgeDurumu.BackgroundImage = global::WFAskerDagitim.Properties.Resources.minimize;
            this.btnSimgeDurumu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSimgeDurumu.Location = new System.Drawing.Point(714, 4);
            this.btnSimgeDurumu.Name = "btnSimgeDurumu";
            this.btnSimgeDurumu.Size = new System.Drawing.Size(25, 25);
            this.btnSimgeDurumu.TabIndex = 4;
            this.btnSimgeDurumu.UseVisualStyleBackColor = true;
            this.btnSimgeDurumu.Click += new System.EventHandler(this.btnSimgeDurumu_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = global::WFAskerDagitim.Properties.Resources.exit;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Location = new System.Drawing.Point(742, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(25, 25);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAskerEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(776, 320);
            this.Controls.Add(this.btnSimgeDurumu);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDagitimYap);
            this.Controls.Add(this.btnAskerEkle);
            this.Controls.Add(this.txtAskerEkle);
            this.Controls.Add(this.lstDagitim);
            this.Controls.Add(this.lstBolgeList);
            this.Controls.Add(this.lstAskerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAskerList;
        private System.Windows.Forms.TextBox txtAskerEkle;
        private System.Windows.Forms.Button btnAskerEkle;
        private System.Windows.Forms.ListBox lstBolgeList;
        private System.Windows.Forms.ListBox lstDagitim;
        private System.Windows.Forms.Button btnDagitimYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSimgeDurumu;
    }
}

