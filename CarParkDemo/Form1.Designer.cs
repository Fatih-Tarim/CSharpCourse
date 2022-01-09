
namespace CarParkDemo
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
            this.dgwGiris = new System.Windows.Forms.DataGridView();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.tbxPlaka = new System.Windows.Forms.TextBox();
            this.tbxTarih = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.tbxSaat = new System.Windows.Forms.TextBox();
            this.lblSaat = new System.Windows.Forms.Label();
            this.gbxgiris = new System.Windows.Forms.GroupBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGiris)).BeginInit();
            this.gbxgiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwGiris
            // 
            this.dgwGiris.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGiris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGiris.Location = new System.Drawing.Point(41, 25);
            this.dgwGiris.Name = "dgwGiris";
            this.dgwGiris.RowHeadersWidth = 51;
            this.dgwGiris.RowTemplate.Height = 24;
            this.dgwGiris.Size = new System.Drawing.Size(1050, 220);
            this.dgwGiris.TabIndex = 1;
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(29, 35);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(50, 20);
            this.lblPlaka.TabIndex = 2;
            this.lblPlaka.Text = "Plaka";
            // 
            // tbxPlaka
            // 
            this.tbxPlaka.Location = new System.Drawing.Point(140, 35);
            this.tbxPlaka.Name = "tbxPlaka";
            this.tbxPlaka.Size = new System.Drawing.Size(142, 27);
            this.tbxPlaka.TabIndex = 3;
            // 
            // tbxTarih
            // 
            this.tbxTarih.Location = new System.Drawing.Point(140, 80);
            this.tbxTarih.Name = "tbxTarih";
            this.tbxTarih.Size = new System.Drawing.Size(142, 27);
            this.tbxTarih.TabIndex = 5;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(29, 80);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(47, 20);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "Tarih";
            // 
            // tbxSaat
            // 
            this.tbxSaat.Location = new System.Drawing.Point(140, 121);
            this.tbxSaat.Name = "tbxSaat";
            this.tbxSaat.Size = new System.Drawing.Size(142, 27);
            this.tbxSaat.TabIndex = 7;
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(29, 121);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(43, 20);
            this.lblSaat.TabIndex = 6;
            this.lblSaat.Text = "Saat";
            // 
            // gbxgiris
            // 
            this.gbxgiris.Controls.Add(this.btnekle);
            this.gbxgiris.Controls.Add(this.tbxSaat);
            this.gbxgiris.Controls.Add(this.lblPlaka);
            this.gbxgiris.Controls.Add(this.tbxPlaka);
            this.gbxgiris.Controls.Add(this.lblSaat);
            this.gbxgiris.Controls.Add(this.lblTarih);
            this.gbxgiris.Controls.Add(this.tbxTarih);
            this.gbxgiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxgiris.Location = new System.Drawing.Point(41, 261);
            this.gbxgiris.Name = "gbxgiris";
            this.gbxgiris.Size = new System.Drawing.Size(320, 203);
            this.gbxgiris.TabIndex = 9;
            this.gbxgiris.TabStop = false;
            this.gbxgiris.Text = "Araç Girişi";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(192, 163);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(90, 34);
            this.btnekle.TabIndex = 8;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(936, 270);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(155, 46);
            this.btncikis.TabIndex = 10;
            this.btncikis.Text = "Araç Çıkışı";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 486);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.gbxgiris);
            this.Controls.Add(this.dgwGiris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGiris)).EndInit();
            this.gbxgiris.ResumeLayout(false);
            this.gbxgiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwGiris;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.TextBox tbxPlaka;
        private System.Windows.Forms.TextBox tbxTarih;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox tbxSaat;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.GroupBox gbxgiris;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btncikis;
    }
}

