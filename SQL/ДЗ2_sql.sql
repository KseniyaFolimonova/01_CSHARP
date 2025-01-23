DROP DATABASE IF EXISTS seminar2_hw;
CREATE DATABASE seminar2_hw;
USE seminar2_hw;

DROP TABLE IF EXISTS manufacturer;
CREATE TABLE manufacturer
(
id INT PRIMARY KEY AUTO_INCREMENT,
`name` VARCHAR(100)
);

INSERT INTO manufacturer (`name`)
VALUES
('Apple'),
('Samsung'),
('Huawei');

SELECT * FROM  manufacturer;

DROP TABLE IF EXISTS mobile_phones;
CREATE TABLE mobile_phones
(
id SERIAL PRIMARY KEY, -- AUTO_INCREMENT,
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

/*
SELECT 
	product_name,
	manufacturer,
	CASE 
		WHEN product_count < 100 THEN 'litle'
		WHEN product_count > 100 AND product_count < 300 THEN 'many'
		WHEN product_count > 300 THEN 'lots'
	END AS status_product_count
FROM mobile_phones;
*/

ALTER TABLE mobile_phones ADD manufacturer_id INT,
ADD FOREIGN KEY(manufacturer_id) REFERENCES manufacturer(id)
ON UPDATE CASCADE ON DELETE CASCADE;
SELECT * FROM mobile_phones;

UPDATE mobile_phones 
SET manufacturer_id = CASE
	WHEN manufacturer = ('Apple') THEN 1
	WHEN manufacturer = ('Samsung') THEN 2
	WHEN manufacturer = ('Huawei') THEN 3
END;
SELECT * FROM mobile_phones;

/* SELECT 
	product_name,
    manufacturer,
    manufacturer_id
FROM mobile_phones
JOIN manufacturer
ON mobile_phones.manufacturer_id = manufacturer.id;

SELECT * FROM mobile_phones;
*/

ALTER TABLE mobile_phones
DROP manufacturer;

DESCRIBE mobile_phones;
SELECT 
	m.id,
    m.product_name,
    m.manufacturer_id
FROM mobile_phones m;