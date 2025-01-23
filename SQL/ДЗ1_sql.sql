CREATE DATABASE IF NOT EXISTS lesson_1_hm;
USE LESSON_1_hm; # itresume9987762;

DROP TABLE IF EXISTS mobile_phones; # itresume9987762.mobile_phones
CREATE TABLE mobile_phones
(
id INT PRIMARY KEY AUTO_INCREMENT,
product_name VARCHAR(45) NOT NULL,
manufacturer VARCHAR(45) NOT NULL,
product_count BIGINT,
price BIGINT
);

INSERT INTO mobile_phones (product_name,manufacturer,product_count,price)
VALUES
('iPhone X','Apple',156, 76000),
('iPhone 8','Apple',180, 51000),
('Galaxy S9','Samsung',21, 56000),
('Galaxy S8','Samsung',124, 41000),
('P20 Pro','Huawei',341, 36000);

SELECT 
product_name,
manufacturer,
price 
FROM mobile_phones
WHERE product_count > 2;

