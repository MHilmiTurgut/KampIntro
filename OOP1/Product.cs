using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product  //Entity
    {
        public int Id { get; set; } // ürün numarası 
        public int CategoryId { get; set; } //  kategori kısmı 
        public string ProductName { get; set; } // ürün ismi
        public double UnitPrice { get; set; } // birim fiyat 
        public int UnitInStock { get; set; } // stok adedi

        //CRUD create read update delete--ProductManager da yazılcak!!!
    }
}