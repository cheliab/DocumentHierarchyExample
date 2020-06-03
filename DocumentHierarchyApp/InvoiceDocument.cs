using System;
using System.Collections.Generic;

namespace DocumentHierarchyApp
{
    /// <summary>
    /// Расходная накладная
    /// </summary>
    public class InvoiceDocument : BaseBundleDocument
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        public List<String> Lines { get; set; }
        
        /// <summary>
        /// Признак того, что есть предзаказ по товарам
        /// </summary>
        public bool IsPreOrder
        {
            get
            {
                if (Lines != null)
                {
                    return true;
                }

                return false;
            }
        }

        public InvoiceDocument()
        {
            Lines = new List<string>();
            DocType = "Расходная накладная";
        }

        public void View()
        {
            const int cutLineSize = 55;
            
            Console.WriteLine(new string('-', cutLineSize));
            
            Console.WriteLine($"{DocType} {Number} от {Date}");
            Console.WriteLine($"Филиал: \"{BranchId}\" Склад: \"{WarehouseId}\"");
            Console.WriteLine($"Контрагент: \"{BuyerId}\"");
            
            Console.WriteLine(new string('-', cutLineSize));
            
            Console.WriteLine("Товары:");

            int i = 1;
            foreach (var line in Lines)
            {
                Console.WriteLine($"{i}: {line}");
                i++;
            }
            
            Console.WriteLine(new string('-', cutLineSize));
        }
    }
}