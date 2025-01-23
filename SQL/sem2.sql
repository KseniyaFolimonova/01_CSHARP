-- 1. Создание БД , snake_case (slill_manager)
CREATE DATABASE IF NOT EXISTS lesson_2; 

-- 2. Подключение к БД 
USE lesson_2;

-- 3. Таблица (все столбцы в большой таблице, без НОРМАЛИЗАЦИИ) 
DROP TABLE IF EXISTS product;
CREATE TABLE product
(
	id INT PRIMARY KEY AUTO_INCREMENT, -- id++ (id = id + 1)
    title VARCHAR(45), -- строка динам. длины на 45 символов 
	category VARCHAR(100) DEFAULT "не определена"
);

-- 4. Просмотр структуры таблицы
DESCRIBE product; -- посмотреть, какие столбцы лежат в таблице product

-- 5. Производим нормализацию. 
-- Выделяем отдельно таблицы: "продукт" и "категория"
-- Удаляем категорию из "продукт" 
ALTER TABLE product
DROP category; -- Удаляю столбец "category"

DESCRIBE product;

-- 6. Создание таблицы "Категория", все категории переносим туда 
DROP TABLE IF EXISTS category;
CREATE TABLE category
(
	id INT PRIMARY KEY AUTO_INCREMENT, -- id++ (id = id + 1)
    category_name VARCHAR(45) -- строка динам. длины на 45 символов 
);

-- 7. Заполним таблицу с продуктами
INSERT INTO product (title) -- заполняю столбец titlе из таблицы product
VALUES 
	("Intel Core i7-10700K"), -- id = 1
    ("Intel Core i9-11900K"), -- id = 2
    ("Intel Core i9-11600K"), -- id = 3
    ("Ryzen 5 5600x"), -- id = 4
    ("GTX-1060"), -- id = 5
    ("GTX-1070");
    
SELECT * FROM product;

-- Добавим внешний ключ на таблицу "Категории"
ALTER TABLE product
ADD category_id INT, 
ADD FOREIGN KEY(category_id) -- product.category_id - FK
REFERENCES category(id) -- product.category_id ССЫЛАЕТСЯ НА category.id
ON UPDATE CASCADE ON DELETE CASCADE; -- обновился/удалися перв. ключ - обновился/удалися внешний

-- Заполняем категории
INSERT INTO category (category_name) -- заполняю столбец category_name из таблицы category
VALUES 
	("процессор"), -- id = 1
    ("видеокарта");-- id = 2
    
SELECT * FROM category;

-- Заполняю столбец category_id из таблицы product
UPDATE product
SET category_id = CASE -- if title like = ... OR title = ... 
	WHEN title LIKE "Intel%" OR title LIKE "Ryzen%" 
		THEN 1 -- category_id = 1, процессоры 
	ELSE 2 -- category_id = 2, видеокарты
END;
SELECT * FROM product;

-- Покажу только для примера, будет дальше
SELECT 
	p.title,
    c.category_name,
    c.id,
    c.category_name
FROM product p 
JOIN category c 
ON p.category_id = c.id;

SELECT 
	title,
    CASE 
		WHEN title LIKE "Intel%" OR title LIKE "Ryzen%" 
			THEN "процессор"
		ELSE "видеокарта"
	END AS "Результат" -- псевдоним
FROM product;

SELECT 
	title,
	IF(title LIKE "Intel%" OR title LIKE "Ryzen%" ,
    "процессор", -- "Intel%" OR title LIKE "Ryzen%" - истинное
    "видеокарта"
) AS result
FROM product;