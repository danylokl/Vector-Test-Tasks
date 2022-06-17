USE [MyShop]
-- Select product with product name that begins with ‘C’.
SELECT [ProductID]
      ,[ProductName]
      ,[SupplierID]
      ,[CategoryID]
      ,[Price]
  FROM [dbo].[Products]
  WHERE SUBSTRING(ProductName,1,1)='C';

-- Select product with the smallest price.
SELECT [ProductID]
      ,[ProductName]
      ,[SupplierID]
      ,[CategoryID]
      ,[Price]
  FROM [dbo].[Products]
  WHERE Price = (SELECT MIN(Price) FROM [dbo].[Products] );

-- Select cost of all products from the USA.
SELECT Sum(Price)
  FROM dbo.Products INNER JOIN Suppliers ON Products.SupplierID=Suppliers.SupplierID
  WHERE Suppliers.Country='USA'

-- Select suppliers that supply Condiments.
  SELECT DISTINCT Suppliers.SupplierID
      ,[SupplierName]
      ,[City]
      ,[Country]
  FROM  [dbo].[Suppliers] INNER JOIN Products ON Suppliers.SupplierID=Products.SupplierID 
    WHERE Suppliers.SupplierID IN (SELECT  SupplierID  FROM Products INNER JOIN Categories ON Products.CategoryID=Categories.CategoryID WHERE CategoryName='Condiments')

--Add to database new supplier with name: ‘Norske Meierier’, city: ‘Lviv’, country: ‘Ukraine’
--which will supply new product with name: ‘Green tea’, price: 10, and related to category with name: ‘Beverages’.
INSERT INTO [dbo].[Suppliers]
           ([SupplierID]
           ,[SupplierName]
           ,[City]
           ,[Country])
     VALUES
           ( 6,
		   '‘Norske Meierier’'
		   , 'Lviv'
		   , 'Ukraine'
		   )
INSERT INTO [dbo].[Products]
           ([ProductID]
           ,[ProductName]
           ,[SupplierID]
           ,[CategoryID]
           ,[Price])
     VALUES(6,
	 'Green tea'
	 ,6
	 ,1
	 ,10)
