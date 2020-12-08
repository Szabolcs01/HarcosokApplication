using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HarcosokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void kapcsolatl()
        {
            MySqlConnectionStringBuilder harcosadatbazis = new MySqlConnectionStringBuilder();
            harcosadatbazis.Server = "localhost";
            harcosadatbazis.UserID = "root";
            harcosadatbazis.Password = "";
            harcosadatbazis.Database = "cs_harcosok";
            harcosadatbazis.CharacterSet = "utf8";
            conn = new MySqlConnection(harcosadatbazis.ToString());
      
            sql = conn.CreateCommand();
            conn.Open();


        }
        private void kapcsolatB()
        {
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                kapcsolatl();

                sql.CommandText = @"CREATE TABLE IF NOT EXISTS `harcosok` ( 
                                    `id` INT NOT NULL AUTO_INCREMENT , 
                                    `nev` VARCHAR(50) NOT NULL , 
                                    `letrehozas` DATETIME NOT NULL ,
                                    PRIMARY KEY (`id`), 
                                    UNIQUE (`nev`)) ENGINE = InnoDB;";
                sql.ExecuteNonQuery();
                sql.CommandText = @"CREATE TABLE IF NOT EXISTS `kepessegek` ( 
                                    `id` INT NOT NULL AUTO_INCREMENT , 
                                    `nev` VARCHAR(50) NOT NULL , 
                                    `leiras` VARCHAR(255) NOT NULL , 
                                    `harcos_id` INT NOT NULL , 
                                    PRIMARY KEY (`id`),
                                    FOREIGN KEY (`harcos_id`) REFERENCES harcosok(`id`))
                                    ENGINE = InnoDB;";
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex) 
            {
                MessageBox.Show(ex.Message, "Adatkapcsolati hiba");
                return;
            }
            Combohasznal();
            kapcsolatB();
        }
        private void Combohasznal()
        {
            comboBox_használó.Items.Clear();
            sql.CommandText = "SELECT nev FROM harcosok;";
            using (MySqlDataReader hc = sql.ExecuteReader())
            {
                while (hc.Read())
                {
                    comboBox_használó.Items.Add(hc.GetString("nev"));
                }
            }
        }


        private void btn_létrehoz_Click(object sender, EventArgs e)
        {
            kapcsolatl();
            string nev = text_harcosNeve.Text.Trim();
            if (nev == " ")
            {
                MessageBox.Show("Kérem adjon meg egy harcos nevet!");
                text_harcosNeve.Focus();
                return;
            }
            string query = "SELECT * FROM harcosok WHERE nev = '" + nev + "'";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    var datum = DateTime.Now.ToString("yyyy-MM-dd ");

                    reader.Close();
                    sql.CommandText = "INSERT INTO harcosok (`nev`, `letrehozas`) VALUES ('" + nev + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                    sql.ExecuteNonQuery();
                    text_harcosNeve.Clear();
                    MessageBox.Show("Sikeres felvétel!");
                    Combohasznal();
                    text_harcosNeve.Focus();
                }
                else
                {
                    MessageBox.Show("Már létezik ez a harcos kérem próbájon újjat!");
                    text_harcosNeve.Focus();
                }

            }
        }

        private void btn_hozzaad_Click(object sender, EventArgs e)
        {
            kapcsolatl();
            if (comboBox_használó.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon li eg yharcost!");
                comboBox_használó.Focus();
                return;
            }
            else if (textBox_kepességekneve.Text.Trim() == "")
            {
                MessageBox.Show("Kére adja meg a képesség nevet!");
                textBox_kepességekneve.Focus();
                return;
            }
            else if (textBox_leírás.Text.Trim() == "")
            {
                MessageBox.Show("Írjon egy képesség leírást!!");
                textBox_leírás.Focus();
                return;
            }

            sql.CommandText = @"INSERT INTO `kepessegek`(`nev`, `leiras`, `harcos_id`) 
                VALUES('" + textBox_kepességekneve.Text.Trim() + "', '" + textBox_leírás.Text.Trim() + "', " +
                "(SELECT id FROM harcosok WHERE nev = '" + comboBox_használó.SelectedItem + "'))";
            if (sql.ExecuteNonQuery() == 1)
            {
              
                MessageBox.Show("Sikeresen rögzítve!");
            }
            else
            {
                MessageBox.Show("Nem sikerült rögzíteni!");
            }
            comboBox_használó.SelectedIndex = -1;
            textBox_kepességekneve.Text = "";
            textBox_leírás.Text = "";
            kapcsolatB();

        }

        private void btn_modosit_Click(object sender, EventArgs e)
        {
            kapcsolatl();
            if (listBox_képességek.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva képesség, aminek lehetne módosítani a leírását!");
                listBox_képességek.Focus();
                return;
            }

            sql.CommandText = @"SELECT `nev`, `leiras` FROM `kepessegek` WHERE `nev` = '" + listBox_képességek.SelectedItem ;
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                dr.Read();
                if (dr.GetString("leiras") != listBox_képességek.Text)
                {
                    dr.Close();
                    sql.CommandText = @"UPDATE `kepessegek` SET `leiras`= '" + listBox_képességek.Text + "' WHERE `nev` = '" + listBox_képességek.SelectedItem ;
                    sql.ExecuteNonQuery();
  
                    listBox_képességek.Text = "";
                    MessageBox.Show("Sikeres  módosítás!");
                }
                else
                {
                    MessageBox.Show("A változtatás nem történt meg!");
                }
            }

            kapcsolatB();

        }

        private void btn_Törlés_Click(object sender, EventArgs e)
        {
            kapcsolatl();

            if (listBox_képességek.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva hogy mit akar törölni!");
                listBox_képességek.Focus();
                return;
            }
                sql.CommandText = @"DELETE FROM `kepessegek` WHERE `nev` = '" + listBox_képességek.SelectedItem ;
                sql.ExecuteNonQuery();
                listBox_képességek.Text = " ";
           
            MessageBox.Show("Sikeres törlés");

            kapcsolatB();
        }
    }
}
