using System;

namespace DocumentHierarchyApp
{
    public class Document
    {
        public String Id { get; set; }
        
        public String DocType { get; set; }
        
        public DateTime Date { get; set; }
        
        public String Number { get; set; }

        public Document()
        {
            Id = new Random().Next().ToString();
            Date = DateTime.Now;
            Number = $"БК6-0000{new Random().Next(99).ToString()}";
        }
        
    }
}