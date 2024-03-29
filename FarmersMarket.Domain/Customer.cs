﻿using System.Collections.Generic;

namespace FarmersMarket.Domain
{
	public class Customer : Entity
	{
		public User User { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; } 
		public string ImagePath { get; set; }
		public virtual ICollection<FavoriteProducts> Categories { get; set; } // избранные категории, назвал по другому для лучшего понимания БД
		public virtual ICollection<Cart> Carts { get; set; } // у покупателя может быть много товаров в корзине
	}
}