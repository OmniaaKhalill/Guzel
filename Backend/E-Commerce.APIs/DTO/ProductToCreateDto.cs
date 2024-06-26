﻿using E_Commerce.Core.Entities;

namespace E_Commerce.APIs.DTO
{
    public class ProductToCreateDto
    {

        public int id { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }

        public string image_link { get; set; }

        public int? CategoryId { get; set; }

        public string Category { get; set; }
        public List<Coulor>? Colors { get; set; }


        public int SellerId { get; set; }
        public string seller { get; set; }
        public int NumOfProductInStock { get; set; }
    }
}
