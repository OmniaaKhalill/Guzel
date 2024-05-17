﻿using System.ComponentModel.DataAnnotations;

namespace E_Commerce.APIs.DTO
{
    public class CustomerWishlistDto
    {

        [Required]
        public string Id { get; set; }
        public List<CartItemDto> Items { get; set; }
    }
}