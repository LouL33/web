using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Gift_Exchange.Models
{
    public class TheStuff  // Model
    {
        public int Id { get; set; }
        public string Contents { get; set; }
        public string GiftHint { get; set; }
        public string ColorWrappingPaper { get; set; }
        public double? Height { get; set; }
        public double? Width { get; set; }
        public double? Depth { get; set; }
        public double? Weight { get; set; }
        public bool? IsOpened { get; set; }

        public TheStuff() {}

        public TheStuff(SqlDataReader reader)
        {
            Id = (int)reader["Id"];
            Contents = reader["Contents"].ToString();
            GiftHint = reader["GiftHint"].ToString();
            ColorWrappingPaper = reader["ColorWrappingPaper"].ToString();
            Height = reader["Height"] as double?;
            Width = reader["Width"] as double?;
            Depth = reader["Depth"] as double?;
            Weight = reader["Weight"] as double?;
            IsOpened = reader["IsOpened"] as bool?;

        }
    }
}