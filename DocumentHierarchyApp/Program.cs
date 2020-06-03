using System;

namespace DocumentHierarchyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoiceDocument = new InvoiceDocument
            {
                WarehouseId = "Прим Аэртон",
                BuyerId = "Березкин Павел",
                BranchId = "Владивосток Гоголя"
            };
            invoiceDocument.Lines.Add("iPhone");
            invoiceDocument.Lines.Add("Samsung");
            invoiceDocument.Lines.Add("Xiaomi");

            invoiceDocument.View();

            Console.ReadKey();
        }
    }
}