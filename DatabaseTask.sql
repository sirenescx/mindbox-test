CREATE TABLE Products (
    ProductID int not null,
    PName varchar(255) not null
);

CREATE TABLE Categories (
    CategoryID int not null,
    CName varchar(255) not null
);

CREATE TABLE Category_Product (
    ProductID int not null,
    CategoryID int not null    
);

SELECT Products.PName, Categories.CName from Products
LEFT JOIN Category_Product ON Category_Product.ProductID = Products.ProductID
LEFT JOIN Categories ON Category_Product.CategoryID = Categories.CategoryID

