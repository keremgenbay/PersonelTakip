﻿namespace PersonelTakip
{
    partial class FrmPozisyonBilgileri
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
            this.txtPozisyon = new System.Windows.Forms.TextBox();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(125, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pozisyon Adı:";
            // 
            // txtPozisyon
            // 
            this.txtPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPozisyon.Location = new System.Drawing.Point(341, 75);
            this.txtPozisyon.Name = "txtPozisyon";
            this.txtPozisyon.Size = new System.Drawing.Size(341, 38);
            this.txtPozisyon.TabIndex = 0;
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(341, 173);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(341, 39);
            this.cmbDepartman.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(125, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Departman Adı:";
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(422, 292);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(247, 72);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(118, 292);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(247, 72);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // FrmPozisyonBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.txtPozisyon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPozisyonBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pozisyon Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPozisyon;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
    }
}