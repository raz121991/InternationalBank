// See https://aka.ms/new-console-template for more information
using EntityFramework;

Console.WriteLine("Hello, World!");

var productService = new ProductService();


//GET ALL Products

productService.GetProducts();

// Add Product

productService.AddProduct("test", 10);

//Update Product

productService.UpdateProduct(1, "test123", 20);

//Delete Product

productService.DeleteProduct(1);

