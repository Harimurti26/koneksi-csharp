﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koneksi
{
    internal class connections
    {
        public static MySqlCommand CreateCommand { get; internal set; }

        public static MySqlConnection getConnection()
        {
            MySqlConnection koneksi = null;

            try
            {
                string sConnstring = "server = localhost;database= db_sekolah;uid=root;password=;";
                koneksi = new MySqlConnection(sConnstring);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return koneksi;
        }
    }
}
