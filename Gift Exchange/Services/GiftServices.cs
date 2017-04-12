﻿using Gift_Exchange.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Gift_Exchange.Services
{
    public class GiftServices
    {
        const string connectionString = @"Server=localhost\SQLEXPRESS;Database=GiftExchange;Trusted_Connection=True;";

        public List<TheStuff>GetAllGifts()
        {
            var rv = new List<TheStuff>();
            using (var connection = new SqlConnection(connectionString))
            {

                var text = @"SELECT * FROM TheGoods";
                var cmd = new SqlCommand(text, connection);
                //cmd.Parameters.AddWithValue("@Id", Id);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rv.Add(new TheStuff(reader));
                }
                connection.Close();
                

            }
            return rv;



        }


    }
}