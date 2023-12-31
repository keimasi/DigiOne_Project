﻿using System.Collections.Generic;

namespace _01_DigiOneQuery.Contracts.Product
{
    public class ProductQueryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Slug { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public string Category { get; set; }
        public string CategorySlug { get; set; }
        public string MetaDescription { get; set; }
        public string PriceAfterDiscount { get; set; }
        public int DiscountRate { get; set; }
        public string DiscountExpireDate { get; set; }
        public bool HasDiscount { get; set; }
        public List<ProductPictureQueryModel> Pictures { get; set; }
        public List<CommentQueryModel> Comments { get; set; }
    }
}
