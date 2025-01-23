-- CREATE DATABASE Myfirstdb;
USE Myfirstdb;

CREATE TABLE Customer
(
Id INT PRIMARY KEY auto_increment,
Age INT,
FirstName VARCHAR(20),
LastName VARCHAR(20)
);

SELECT * from product;

SELECT 
	p.title,
    p.category_id,
    c.category_name,
    c.id
FROM product p 
JOIN category c 
ON p.category_id = c.id;