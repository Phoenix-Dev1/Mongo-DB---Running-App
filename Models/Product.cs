using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    [Serializable]
    public class Product
    {

        // ProductId will be the coding name, and it will be mapped to the PK _id of the table
        [BsonId,BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string ProductId { get; set; }



        // ProductCode is the coding name and it wil be mapped to the product_code column
        // in the Mongo DB
        // In the code ProductCode is defined as string, and also in the database
        // - it will be stored as string.

        [BsonElement("product_code"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string ProductCode { get; set; }

        // ProductName is the coding name and it will be mapped to the product_name column
        // in the Mongo DB.
        // In the code, ProductionName is defined as string, and also in the database
        // - it will be stored as string

        [BsonElement("product_name"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string ProductName { get; set; }

        [BsonElement("price"), BsonRepresentation(MongoDB.Bson.BsonType.Double)]
        public double Price { get; set; }   



        public Product(string productCode, string productName, double price)
        {
            this.ProductCode = productCode;
            this.ProductName = productName;
            this.Price = price;
        }

        
        public override string ToString()
        {
            string str = "";

            str += "Code: " + this.ProductCode + 
                "\nName: " + this.ProductName + 
                "\nPrice: " + this.Price.ToString();

            return str;
        }

    }
}
