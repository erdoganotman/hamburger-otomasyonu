using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using System.Data.SqlClient;
using EntitiyLayer;
namespace Hamburger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasa, hesap;
        public void clearall(Control items)
        {
            foreach (Control item in items.Controls)
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    btn.BackColor = Color.Gray;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Entity> list = Logic.logic.Listele();
            dataGridView1.DataSource = list;
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            label1.Visible=false;
           label2.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text = "1";
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label1.Text = "2";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "3";
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "4";
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "5";
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "6";
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "7";
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "8";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Entity ent = new Entity();
            ent.Siparis_adı = "TriplexBurger";
            ent.Siparis_adeti = 1;
            ent.Siparis_ucreti = 90;
            ent.Masano = Convert.ToInt32(label1.Text);
            DALSiparis.siparisekle(ent);
            kasa = kasa + 90;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            List<Entity> list = Logic.logic.Listele();
            dataGridView1.DataSource = list;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Entity ent = new Entity();
            ent.Siparis_adı = "KasapBurger";
            ent.Siparis_adeti = 1;
            ent.Siparis_ucreti = 70;
            ent.Masano = Convert.ToInt32(label1.Text);
            DALSiparis.siparisekle(ent);
            kasa = kasa + 70;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Entity ent = new Entity();
            
            ent.Siparis_adı = "CheesBurger";
            ent.Siparis_adeti = 1;
            ent.Siparis_ucreti = 60;
            ent.Masano = Convert.ToInt32(label1.Text);
            DALSiparis.siparisekle(ent);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Entity ent=new Entity();
            ent.Siparis_id = Convert.ToInt32(label2.Text);
            Logic.logic.DLsiparisSil(ent.Siparis_id);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Entity ent = new Entity();
            ent.Siparis_adı = "Kola";
            ent.Siparis_adeti = 1;
            ent.Siparis_ucreti = 15;
            ent.Masano = Convert.ToInt32(label1.Text);
            DALSiparis.siparisekle(ent);
            kasa = kasa + 15;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Entity ent = new Entity();
            ent.Siparis_adı = "Fanta";
            ent.Siparis_adeti = 1;
            ent.Siparis_ucreti = 15;
            ent.Masano = Convert.ToInt32(label1.Text);
            DALSiparis.siparisekle(ent);
            kasa = kasa + 15;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Entity ent = new Entity();
            ent.Siparis_adı = "Sprite";
            ent.Siparis_adeti = 1;
            ent.Siparis_ucreti = 15;
            ent.Masano = Convert.ToInt32(label1.Text);
            DALSiparis.siparisekle(ent);
            kasa = kasa + 15;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Entity ent = new Entity();
            ent.Siparis_adı = "Ayran";
            ent.Siparis_adeti = 1;
            ent.Siparis_ucreti = 9;
            ent.Masano = Convert.ToInt32(label1.Text);
            DALSiparis.siparisekle(ent);
            kasa = kasa + 9;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Entity ent = new Entity();
            ent.Siparis_adı = "Su";
            ent.Siparis_adeti = 1;
            ent.Siparis_ucreti = 5;
            ent.Masano = Convert.ToInt32(label1.Text);
            DALSiparis.siparisekle(ent);
            kasa = kasa + 5;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Entity ent = new Entity();
            ent.Siparis_adı = "TürkKahvesi";
            ent.Siparis_adeti = 1;
            ent.Siparis_ucreti = 10;
            ent.Masano = Convert.ToInt32(label1.Text);
            DALSiparis.siparisekle(ent);
            kasa = kasa + 10;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label5.Text=kasa.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Entity ent = new Entity();
            ent.Siparis_id = Convert.ToInt32(label2.Text);
            Logic.logic.DLsiparisSil(ent.Siparis_id);
            MessageBox.Show("Sipariş Teslim Edildi");
            List<Entity> list = Logic.logic.Listele();
            dataGridView1.DataSource = list;
        }
    }
}
