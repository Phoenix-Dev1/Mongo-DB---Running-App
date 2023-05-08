using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       string connectionString = ConfigurationManager.ConnectionStrings["MyMongo"].ConnectionString;
       IMongoDatabase db; // Represents a Database in MongoDB
       IMongoCollection<Product> productsCollection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get the DB Name(As a string)
            MongoDB.Driver.MongoUrl mongoUrl = MongoUrl.Create(connectionString);
            string dbName = mongoUrl.DatabaseName;


            // Create Mongo Client
            MongoDB.Driver.MongoClient mongoClient;

            try 
            { 
               // we will work on a database in this manner
               // mongoClient.GetDatabase("test").GetCollection("test").
                mongoClient = new MongoClient(connectionString);

                // Get the DB OBJECT
                IMongoDatabase db = mongoClient.GetDatabase(dbName);

                // Get the Collection 
                // the collection is called "products" - in the first time it will create it
                productsCollection = db.GetCollection<Product>("Products");

                // When the form is loaded - we would like to get the list of all products
                LoadProductsUponScreen();


            }
            catch(Exception ex)
            {
                mongoClient = null;
                MessageBox.Show("The following error occured:\n" + ex.Message,
                    "Balagan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_InsertProduct_Click(object sender, EventArgs e)
        {
            // To Do - Stage 1: Get the information from the screen
            Models.Product product = GetProductDetailsFromScreen();

            // To Do - Stage2: Insert the data into the Collection(Into the MongoDB)
            try
            {
            productsCollection.InsertOne(product);
                MessageBox.Show("The Following product was inserted:\n"+ product.ToString(),
                    "Product was inserted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                // If the insert succeeded - refresh the screen with the new information
                LoadProductsUponScreen();
            }

            catch(Exception ex)
            {
                MessageBox.Show("The following error occured:\n" + ex.Message,
                   "Balagan",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private Product GetProductDetailsFromScreen()
        {
            string productCode = textBox_ProductCode.Text;
            string productName = textBox_ProductName.Text;
            double productPrice = Convert.ToDouble(textBox_ProductPrice.Text);

            Product product = new Product(productCode, productName, productPrice);



            return product;
        }
        
        private void LoadProductsUponScreen()
        {
            List<Product> results;

            // 3 options for load process:
            // option 1:
            results = productsCollection.Aggregate().ToList();

            // option 2 - based on declaration of empty fiter:
            //FilterDefinition<Product> emptyFilter = Builders<Product>.Filter.Empty;
            //results = productsCollection.Find(emptyFilter).ToList();

            // option 3:

            dataGridView_products.DataSource = results;

        }


        private void btn_RefreshProductsList_Click(object sender, EventArgs e)
        {
            LoadProductsUponScreen();
        }
    }
}
