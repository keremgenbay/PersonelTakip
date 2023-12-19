using BLL;
using DAL;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PersonelTakip
{
    public partial class FrmPersonelBilgileri : Form
    {
        public FrmPersonelBilgileri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))  //İlgili Textbox'a harf girişi engelleme için.
            {
                e.Handled = true;
            }
        }

        private void txtUserNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))  //İlgili Textbox'a harf girişi engelleme için.
            {
                e.Handled = true;
            }
        }

        PersonelDTO dto = new PersonelDTO();
        private void FrmPersonelBilgileri_Load(object sender, EventArgs e)
        {
            dto = PersonelBLL.GetAll();
            cmbDepartman.DataSource = dto.Departmanlar;
            cmbDepartman.DisplayMember = "DepartmanAd";
            cmbDepartman.ValueMember = "ID";
            cmbDepartman.SelectedIndex = -1;
            cmbPozisyon.DataSource = dto.Pozisyonlar;
            cmbPozisyon.DisplayMember = "PozisyonAd";
            cmbPozisyon.ValueMember = "ID";
            cmbPozisyon.SelectedIndex = -1;
            if (dto.Departmanlar.Count > 0)
                combofull = true;

        }
        bool combofull = false;
        private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmanID = Convert.ToInt32(cmbDepartman.SelectedValue);
                cmbPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) 
            { 
                pictureBox1.Load(openFileDialog1.FileName);
                txtResim.Text= openFileDialog1.FileName;
                resimad=Guid.NewGuid().ToString();
                resimad += openFileDialog1.SafeFileName;
            }
        }
        string resimad = "";
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("User No Alanını Doldurunuz!");
            else if (txtAd.Text.Trim() == "")
                MessageBox.Show("Ad Alanını Doldurunuz!");
            else if (txtSoyad.Text.Trim() == "")
                MessageBox.Show("Soyad Alanını Doldurunuz!");
            else if (txtMaas.Text.Trim() == "")
                MessageBox.Show("Maaş Alanını Doldurunuz!");
            else if (txtPassword.Text.Trim() == "")
                MessageBox.Show("Şifre Alanını Doldurunuz!");
            else if (txtResim.Text.Trim() == "")
                MessageBox.Show("Resim Ekleyiniz!");
            else if (cmbDepartman.SelectedIndex == -1)
                MessageBox.Show("Departman Seçiniz");
            else if (cmbPozisyon.SelectedIndex == -1)
                MessageBox.Show("Pozisyon Seçiniz");
            else
            {
                PERSONEL pr = new PERSONEL();
                pr.UserNo = Convert.ToInt32(txtUserNo.Text);
                pr.Ad = txtAd.Text;
                pr.Soyad = txtSoyad.Text;
                pr.Maas = Convert.ToInt32(txtMaas.Text);
                pr.isAdmin = chisAdmin.Checked;
                pr.Password = txtPassword.Text;
                pr.PozisyonID = Convert.ToInt32(cmbPozisyon.SelectedValue);
                pr.DepartmanID = Convert.ToInt32(cmbDepartman.SelectedValue);
                pr.DogumGunu = dateTimePicker1.Value;
                pr.Adres = txtAdres.Text;
                pr.Resim = resimad;
                PersonelBLL.PersonelEkle(pr);
                File.Copy(txtResim.Text, @"resimler\\" + resimad);
                MessageBox.Show("Personel Eklendi");
                txtUserNo.Clear();
                txtAd.Clear();
                txtSoyad.Clear();
                txtMaas.Clear();
                chisAdmin.Checked = false;
                txtPassword.Clear();
                cmbDepartman.SelectedIndex = -1;
                cmbPozisyon.DataSource = dto.Pozisyonlar;
                cmbPozisyon.SelectedIndex = -1;
                dateTimePicker1.Value = DateTime.Today;
                txtAdres.Clear();
                txtResim.Clear();
                resimad = "";
            }
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("User no boş");
            else if (PersonelBLL.isUnique(Convert.ToInt32(txtUserNo.Text)))
            {
                MessageBox.Show("Lütfen User No değiştirin zaten bunu kullanan bir personel mevcut.");

            }
            else
            {
                MessageBox.Show("Bu User No kullanılabilir.");
            }
        }
    }
}
