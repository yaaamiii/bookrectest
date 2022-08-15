﻿using System.ComponentModel.DataAnnotations;

namespace CSite.Models
{
    public class Transactions
    {
        [Key]
        public int ID { get; set; }
        public int? AccountID { get; set; }
        public int AccountType { get; set; }
        public uint Amount { get; set; }
        public int Type { get; set; }
        public int? OperationID { get; set; }
        public int Operation { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public string Notes { get; set; }

    }
}
