﻿using AutoMapper;
using E_Commerce.Core.Entities;
using E_Commerce.Core.Repositories.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.APIs.Controllers
{

    public class CartItemController : BaseApiController
    {
        private readonly ICartRepositery cartRepositery;
        IUnitOfWork unit;
        public CartItemController(
            ICartRepositery cartRepositery,
            IUnitOfWork unit   )
        {
            this.cartRepositery= cartRepositery;
            this.unit= unit;

        }
        [HttpPost]
        public async Task<ActionResult<customerCart>> AddCartItem(string cartId, CartItem item)
        {
           
            if (unit.ProductRepo.GetAsync(item.Id) != null)
            {
                var cart = cartRepositery.AddCartItem(cartId, item);
                return Ok(cart);
            }
            else
            {
                return BadRequest("you cannot add product that doesnot exist");
            }

        }
        [HttpDelete]
        public async Task<ActionResult<customerCart>> DeleteCartItem(string cartId, CartItem item)
        {
            var cart=cartRepositery.DeleteCartItemAsync(cartId, item);
            if(cart != null)
            {
                return Ok(cart);
            }
            return BadRequest(400);
          
        }


    }

}