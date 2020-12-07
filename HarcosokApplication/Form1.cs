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
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Adatkapcsolati hiba");
                return;
            }

   
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
            kapcsolatB();
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
                    text_harcosNeve.Focus();
                }
                else
                {
                    MessageBox.Show("Már létezik ez a harcos kérem próbájon újjat!");
                    text_harcosNeve.Focus();
                }

            }
        }
    }
}
