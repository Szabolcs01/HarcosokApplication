﻿using System;
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
     
        }
    }
}
