CREATE DATABASE IF NOT EXISTS lesson_3;

USE lesson_3;

DROP TABLE IF EXISTS staff;
CREATE TABLE staff
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(45),
    last_name VARCHAR(45),
    post VARCHAR(45) NOT NULL,
    seniority INT,
    salary DECIMAL(8,2),
    age INT
    );
    
    TRUNCATE staff; -- очистка таблицы от данных. От задвоения данных
    INSERT INTO staff (first_name, last_name, post, seniority, salary, age)
    VALUES
    ('Василий', 'Петров', 'Начальник', 40, 70000, 60),
    ('Василий', 'Петров', 'Начальник', 40, 100000, 60),
    ('Петр', 'Власоа', 'Начальник', 8, 70000, 30),
	('Екатерина', 'Катина', 'Инженер', 2, 70000, 25), 
	('Иван', 'Петров', 'Рабочий', 40, 30000, 59), 
	('Александр', 'Санин', 'Инженер', 12, 50000, 35),     
	('Петр', 'Петров', 'Рабочий', 20, 30000, 60),  
	('Семен', 'Сидоров', 'Рабочий', 10, 20000, 35),  
 	('Антон', 'Антонов', 'Рабочий', 8, 19000, 28),     
    ('Юрий', 'Юрков', 'Рабочий', 5, 15000, 28),  
    ('Максим', 'Петров', 'Рабочий', 2, 11000, 19),  
    ('Юрий', 'Петров', 'Рабочий', 3, 12000, 24),
    ('Людмила', 'Маркина', 'Уборщик', 10, 10000, 49);
    
SELECT * FROM staff;

-- Сортировка ORDER BY
SELECT 
	id,
	salary,
    CONCAT(first_name,' ', last_name) AS full_name
FROM staff
ORDER BY salary DESC -- DESC обратная / ASC
LIMIT 3;

SELECT 
	id,
	salary,
    first_name,
    last_name
FROM staff
ORDER BY first_name DESC, last_name DESC, salary DESC; -- DESC обратная / ASC

-- Группировка GROUP BY 
-- для каждой занимаемой должности найти:
-- по каждой должности 
-- мин и макс ЗП, сред ЗП, разницу макс и мин ЗП сотрудников
-- кол. сотрудников
SELECT 
	post,
    MIN(salary) AS min_salary
FROM staff
GROUP BY post;

-- вывести должность и его мин зп
SELECT 
	post,
    salary
FROM staff
WHERE salary = (SELECT MIN(salary) FROM staff);

SELECT 
	post,
	MIN(salary) AS nim_salary, -- агрегатная функция MIN, MAX, COUNT(), ROUND() и тд
	MAX(salary) AS max_salary,
	ROUND(AVG(salary)) AS avg_salary, -- ROUND(_,2) округлить с 2 знаками после запятой
	MAX(salary) - MIN(salary) AS diff, -- AS псевдоним для вывода в SELECT
	COUNT(salary) AS 'Кол. должностей'
FROM staff
WHERE post != 'Уборщик' -- исключить из вывода. WHERE фильтрует все строки БЕЗ агригатный функций
GROUP BY post
HAVING avg_salary > 20000; -- HAVING фильтрует/работает как WHERE и с агрегатными функциями.  

