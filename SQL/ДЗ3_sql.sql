DROP DATABASE IF EXISTS seminar_3; 
CREATE DATABASE IF NOT EXISTS seminar_3; 

-- 2. Подключение к БД 
USE seminar_3;

-- 3. Создание таблицы 
CREATE TABLE IF NOT EXISTS staff
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(45),
    last_name VARCHAR(45),
    post VARCHAR(45) NOT NULL,
	seniority INT,
    salary DECIMAL(8, 2) NOT NULL,
    age INT
);
TRUNCATE staff; -- Очистка таблицы от данных  
INSERT staff (first_name, last_name, post, seniority, salary, age)
VALUES
 ('Вася', 'Петров', 'Начальник', 40, 70000, 60),
 ('Вася', 'Петров', 'Начальник', 40, 100000, 60),
 ('Петр', 'Власов', 'Начальник', 8, 70000, 30),
 ('Катя', 'Катина', 'Инженер', 2, 70000, 25),
 ('Саша', 'Сасин', 'Инженер', 12, 50000, 35),
 ('Иван', 'Петров', 'Рабочий', 40, 30000, 59),
 ('Петр', 'Петров', 'Рабочий', 20, 55000, 60),
 ('Сидр', 'Сидоров', 'Рабочий', 10, 20000, 35),
 ('Антон', 'Антонов', 'Рабочий', 8, 19000, 28),
 ('Юрий', 'Юрков', 'Рабочий', 5, 15000, 25),
 ('Максим', 'Петров', 'Рабочий', 2, 11000, 19),
 ('Юрий', 'Петров', 'Рабочий', 3, 12000, 24),
 ('Людмила', 'Маркина', 'Уборщик', 10, 10000, 49);
 
SELECT 
	id,
    first_name,
    last_name,
	salary  
FROM staff
ORDER BY salary;

SELECT 
    post,
	SUM(salary) AS sum_salary
FROM staff
GROUP BY post;

SELECT 
  post,
  COUNT(post) AS 'кол. должностей'
FROM staff
WHERE post = 'Рабочий' AND age BETWEEN 24 AND 49;

SELECT 
	post,
	COUNT(post) AS uniq_post
FROM staff
GROUP BY post;

SELECT COUNT(DISTINCT post) AS unique_posts_count
FROM staff;
/*
Объяснение:
DISTINCT post: выберет уникальные значения в столбце post.
COUNT(DISTINCT post): подсчитает количество уникальных значений в столбце post.
AS unique_posts_count: задает псевдоним для вывода.
*/

SELECT 
	id,
    firstname,
    lastname,
	salary,
	ROUND(AVG(age)) AS avg_age
    
FROM staff
GROUP BY post;