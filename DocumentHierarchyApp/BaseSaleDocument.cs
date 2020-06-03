using System;

namespace DocumentHierarchyApp
{
    public class BaseSaleDocument : Document
    {
        /// <summary>
        /// Склад списания товара
        /// </summary>
        public String WarehouseId { get; set; }
        
        /// <summary>
        /// Покупатель
        /// </summary>
        public String BuyerId { get; set; }
        
        /// <summary>
        /// Филиал
        /// </summary>
        public String BranchId { get; set; }
    }
}