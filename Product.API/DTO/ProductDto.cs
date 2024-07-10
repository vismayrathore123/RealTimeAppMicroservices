﻿using Product.API.Entities;
using System.ComponentModel.DataAnnotations;

namespace Product.API.DTO
{
    public class ProductDto
    {
        
        public int Id { get; set; }
        
        public string Title { get; set; }
       
        public string Description { get; set; }
       
        public decimal Price { get; set; }
        
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }
      
    }
}
