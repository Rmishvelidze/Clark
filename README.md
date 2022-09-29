# Goal:

To download product information from two APIs and generate a merged file.

# Prerequisite:
- .NET 6 is required to run this solution.

# Instructions:

- Please use Git locally to commit your changes as you progress

## Merge Product Data:

- Using the provided console application Ir.Interview
- Retrieve the product data from https://472d3c44-41a8-4d95-995c-2a9791b2ad66.mock.pstmn.io/api/products
- Retrieve the product inventory from https://472d3c44-41a8-4d95-995c-2a9791b2ad66.mock.pstmn.io/api/products/inventory
- Join the two result sets by the id property.
- Add the joint products to a CSV file called products.csv
	-The header should be
	Id,Name,Brand,Inventory

	CSV output example of the first product.
	27301111199999,Birkenstock Gizeh Toe Post Adjustable Strap Sandal,Birkenstock,10

	-If the is no product id match in the inventory API response then the Inventory field in the CSV should be OUTOFSTOCK
	-All products from the products API should be outputted in the CSV

## Fix broken test:
- Run the test in ProductServiceTest.cs
  - This test needs to pass.
  - In order to make the test pass, the logic in the ProductsService UpdatePrices method needs to be refactored.
  - The ProductsService is a dummy service that contains 40k products.
  
  
# Send code back:
- Zip up the solution folder and send it back via email
  - Please make sure no binary folders are included (bin, obj).
- Under this line please mention your favourite book or movie from the last year and commit the change.
