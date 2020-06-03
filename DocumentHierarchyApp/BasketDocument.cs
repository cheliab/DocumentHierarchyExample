using System;

namespace DocumentHierarchyApp
{
    /// <summary>
    /// Документ в корзине
    /// </summary>
    public class BasketDocument : BaseBundleDocument
    {
        /// <summary>
        /// Идентификатор корзины, может быть заполнен только через API(сайт)
        /// </summary>
        public String OrderId { get; set; }
    }
}