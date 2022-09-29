using Ir.Interview.Helpers;
using Ir.Interview.Models;

//Add logic here
Console.WriteLine("Running products collection");

var client = new HttpClient();

var productResponse = client.GetAsync("https://472d3c44-41a8-4d95-995c-2a9791b2ad66.mock.pstmn.io/api/products");
var productQuantityResponse = client.GetAsync("https://472d3c44-41a8-4d95-995c-2a9791b2ad66.mock.pstmn.io/api/products/inventory");

var productsJson = productResponse.GetJsonData();
var productQunatitiesJson = productQuantityResponse.GetJsonData();


var products = productsJson.Deserialize<Product>();
var productsQuantities = productQunatitiesJson.Deserialize<ProductQuantity>();

if (productsQuantities != null && products != null)
{
    var productsForCsv = DataStructurization.CreateDataForCsv(products, productsQuantities);

    //please refer your local CSV file's path
    productsForCsv.WriteInFile("C:\\Users\\rmishvelidze\\Desktop\\Test.csv");
}
