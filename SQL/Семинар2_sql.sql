CREATE DATABASE IF NOT EXISTS lesson_2; -- 1. создаем БД если она не существует
-- DROP DATABASE IF EXISTS lesson_2; -- удалить БД если она существует

USE lesson_2; -- 2. Подключение к БД 

DROP TABLE IF EXISTS product; -- 3. Таблица (все столбцы в большой таблице, без НОРМАЛИЗАЦИИ) 
CREATE TABLE product
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(45),
    category VARCHAR(100) DEFAULT 'не определена'
);

DESCRIBE product; -- 4. Просмотр структуры таблицы

-- 5. Производим нормализацию.
-- Выделяем отдельно таблицы: продукт и категория
-- Удаляем категорию из Продукт

ALTER TABLE product
DROP category; -- удаляем точечно столбец Категория
DESCRIBE product;

-- 6. Создание таблицы Категория все категории переносим туда
DROP TABLE IF EXISTS category;
CREATE TABLE category
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    category_name VARCHAR(45)
);

-- 7. Заполним таблицу с продуктами
INSERT INTO product (title) -- заполняем столбец title из таблицы product
VALUES
	('Intel Core i7-10700K'),
	('Intel Core i9-11900K'),
	('Intel Core i9-11600K'),
	('Ryzen 5 5600x'),
	('GTX-1060'),
	('GTX-1070');
    
SELECT * FROM product;

-- Добавим внешний ключ в таблицу Продукт на таблицу Категория
ALTER TABLE product -- точечное внесение изменений в таблицу
ADD category_id INT,
ADD FOREIGN KEY(category_id) -- вторичный ключ product.category_id - FK
REFERENCES category(id) -- внешний вторичный ключ product.category_id ССЫЛАЕТСЯ на category.id 
ON UPDATE CASCADE ON DELETE CASCADE; -- set null (cascade второй удйлить); -- обновился\удалился первичный ключ, обнов.удал вторичный ключ

INSERT INTO category (category_name) -- заполнить данными столбец category_name в таблицу category
VALUE
('процессор'), -- id 1
('видеокарта'); -- id 2

SELECT * FROM category;

-- Заполнить столбец category_id из таблицы product
UPDATE product
SET category_id = CASE -- альтернативная команда IF 
	WHEN title LIKE 'Intel%' OR title LIKE 'Ryzen%'
		THEN 1 -- процессоры
	ELSE 2 -- видокарты
END;

SELECT * FROM product;


SELECT * from product;

SELECT 
	p.title,
    p.category_id,
    c.category_name,
    c.id
FROM product p 
JOIN category c 
ON p.category_id = c.id;

SELECT 
	title,
    CASE
		WHEN title LIKE 'Intel%' OR title LIKE 'Ryzen%'
			THEN 'процессор'
		ELSE 'видеокарта'
	END AS result
FROM product;

SELECT 
	title,
    IF(title LIKE 'Intel%' OR title LIKE 'Ryzen%',
		'процессор',
		'видеокарта')
	AS result
FROM product;

-- on delete set null