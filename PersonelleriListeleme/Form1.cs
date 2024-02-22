using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace PersonelleriListeleme
{
    
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MONSTER_SEA;Initial Catalog=CalisanlariListeleme;Integrated Security=True;");
        
      
        private void listele_Click(object sender, EventArgs e)
        {
       
        SqlCommand komut = new SqlCommand("select * from Personel", baglanti);
        SqlDataAdapter da = new SqlDataAdapter(komut);
        DataTable dt = new DataTable();
        da.Fill(dt);
        dataGridView1.DataSource = dt;
  
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("insert into Personel(TamAd,il,ilce,Uzaktan,Yuzyuze,YurticiDeneyim,YurtdisiDeneyim,Maas,TelNo,Ekip,Proje) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)",baglanti);
            komut.Parameters.AddWithValue("@p1", textBoxadSoyad.Text);
            komut.Parameters.AddWithValue("@p2", comboBoxil.SelectedValue);
            komut.Parameters.AddWithValue("@p3", comboBoxilce.SelectedValue);
            komut.Parameters.AddWithValue("@p4", comboBoxuzaktan.SelectedValue);
            komut.Parameters.AddWithValue("@p5", comboBoxyuzyuze.SelectedValue);

            komut.Parameters.AddWithValue("@p6", comboBoxyurtici.SelectedValue);
            komut.Parameters.AddWithValue("@p7", comboBoxyurtdisi.SelectedValue);
            komut.Parameters.AddWithValue("@p8", textBoxmaas.Text);

            komut.Parameters.AddWithValue("@p9", textBoxtelNo.Text);
            komut.Parameters.AddWithValue("@p10", comboBoxekip.SelectedValue);
            komut.Parameters.AddWithValue("@p11", comboBoxproje.SelectedValue);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel eklendi");



        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" select  *  from Il ",baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            comboBoxil.DisplayMember = "IlAdi";
            comboBoxil.ValueMember = "IlId";
            comboBoxil.DataSource = dt;



            SqlCommand komut1 = new SqlCommand(" select  *  from Ilce ", baglanti);
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(komut1);
            DataTable dt1 = new DataTable();
            dataAdapter1.Fill(dt1);
            comboBoxilce.DisplayMember = "IlceAdi";
            comboBoxilce.ValueMember = "IlceId";
            comboBoxilce.DataSource = dt1;


            SqlCommand komut2 = new SqlCommand(" select  *  from Uzaktan ", baglanti);
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            dataAdapter2.Fill(dt2);
            comboBoxuzaktan.DisplayMember = "Durumu";
            comboBoxuzaktan.ValueMember = "UzaktanId";
            comboBoxuzaktan.DataSource = dt2;


            SqlCommand komut3 = new SqlCommand(" select  *  from Yuzyuze ", baglanti);
            SqlDataAdapter dataAdapter3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            dataAdapter3.Fill(dt3);
            comboBoxyuzyuze.DisplayMember = "Durumu";
            comboBoxyuzyuze.ValueMember = "YuzyuzeId";
            comboBoxyuzyuze.DataSource = dt3;


            SqlCommand komut4 = new SqlCommand(" select  *  from YurticiDeneyim ", baglanti);
            SqlDataAdapter dataAdapter4 = new SqlDataAdapter(komut4);
            DataTable dt4 = new DataTable();
            dataAdapter4.Fill(dt4);
            comboBoxyurtici.DisplayMember = "Durumu";
            comboBoxyurtici.ValueMember = "YurticiDeneyimId";
            comboBoxyurtici.DataSource = dt4;


            SqlCommand komut5 = new SqlCommand(" select  *  from YurtdisiDeneyim ", baglanti);
            SqlDataAdapter dataAdapter5 = new SqlDataAdapter(komut5);
            DataTable dt5 = new DataTable();
            dataAdapter5.Fill(dt5);
            comboBoxyurtdisi.DisplayMember = "Durumu";
            comboBoxyurtdisi.ValueMember = "YurtdisiId";
            comboBoxyurtdisi.DataSource = dt5;


            SqlCommand komut6 = new SqlCommand(" select  *  from Ekip ", baglanti);
            SqlDataAdapter dataAdapter6 = new SqlDataAdapter(komut6);
            DataTable dt6 = new DataTable();
            dataAdapter6.Fill(dt6);
            comboBoxekip.DisplayMember = "EkipAdi";
            comboBoxekip.ValueMember = "EkipId";
            comboBoxekip.DataSource = dt6;


            SqlCommand komut7 = new SqlCommand(" select  *  from ProjeAdi join Proje on Proje.ProjeAdiId=ProjeAdi.ProjeAdiId"
              , baglanti);
            SqlDataAdapter dataAdapter7 = new SqlDataAdapter(komut7);
            DataTable dt7 = new DataTable();
            dataAdapter7.Fill(dt7);
            comboBoxproje.DisplayMember = "ProjeAdi";
            comboBoxproje.ValueMember = "ProjeAdiId";
            comboBoxproje.DataSource = dt7;


            
        }
       

     


        private void sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Personel where PersonelId=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", textBoxpersonelId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel silme islemi gerceklesti");
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Personel set TamAd=@p1,il=@p3,ilce=@p4,Uzaktan=@p5,Yuzyuze=@p6,YurticiDeneyim=@p7,YurtdisiDeneyim=@p8,Maas=@p9,TelNo=@p10,Ekip=@p11,Proje=@p12  where PersonelId=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", textBoxadSoyad.Text);
            komut.Parameters.AddWithValue("@p2", textBoxpersonelId.Text);

            komut.Parameters.AddWithValue("@p3",comboBoxil.SelectedValue);
            komut.Parameters.AddWithValue("@p4", comboBoxilce.SelectedValue);

            komut.Parameters.AddWithValue("@p5",comboBoxuzaktan.SelectedValue);
            komut.Parameters.AddWithValue("@p6",comboBoxyuzyuze.SelectedValue);
            komut.Parameters.AddWithValue("@p7",comboBoxyurtici.SelectedValue);
            komut.Parameters.AddWithValue("@p8",comboBoxyurtdisi.SelectedValue);

            komut.Parameters.AddWithValue("@p9", decimal.Parse(textBoxmaas.Text));
            komut.Parameters.AddWithValue("@p10", textBoxtelNo.Text);
            komut.Parameters.AddWithValue("@p11", comboBoxekip.SelectedValue);
            komut.Parameters.AddWithValue("@p12", comboBoxproje.SelectedValue);

            komut.ExecuteNonQuery();
            
            baglanti.Close();
            MessageBox.Show("Personel bilgileri güncellendi");



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxpersonelId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxadSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxil.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxilce.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxuzaktan.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBoxyuzyuze.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBoxyurtici.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboBoxyurtdisi.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBoxmaas.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBoxtelNo.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            comboBoxekip.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            comboBoxproje.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            

        }
        private void yurtdisibutton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("execute sp_YurtDisiDeneyim", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void yurticibutton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from yurticiDeneyimi_Olan_Personeller", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void kayitliPersonelbutton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from KayitliPersonelSayisi", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;



        }
    }
}
// Data Source=MONSTER_SEA;Initial Catalog=CalisanlariListeleme;Integrated Security=True;Encrypt=True;