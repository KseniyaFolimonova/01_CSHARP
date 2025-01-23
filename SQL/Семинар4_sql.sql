DROP DATABASE IF EXISTS lesson_4;
CREATE DATABASE lesson_4;
USE lesson_4;

DROP TABLE IF EXISTS teacher;
CREATE TABLE teacher
(
	id INT NOT NULL PRIMARY KEY, -- AUTO_INCREMENT,
    surname VARCHAR(45),
    salary INT
);

INSERT INTO teacher
VALUES
	(1,"Авдеев", 17000),
    (2,"Гущенко",27000),
    (3,"Пчелкин",32000),
    (4,"Питошин",15000),
    (5,"Вебов",45000),
    (6,"Шарпов",30000),
    (7,"Шарпов",40000),
    (8,"Питошин",30000);
    
SELECT * FROM teacher;

DROP TABLE IF EXISTS lesson;
CREATE TABLE lesson
(
	 id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
     course VARCHAR(45),
     teacher_id INT,
     FOREIGN KEY (teacher_id) REFERENCES teacher(id)
);

INSERT INTO lesson (course, teacher_id)
VALUES 
	("Знакомство с веб-технологиями",1),
    ("Знакомство с веб-технологиями",2),
    ("Знакомство с языками программирования",3),
    ("Базы данных и SQL",4),
    ("Нейронные сети", NULL);
    
SELECT * FROM lesson;
-- Вывести всех учителей, которые проводят уроки 
SELECT
	t.surname,
    t.salary,
    l.course
FROM teacher t
INNER JOIN lesson l -- JOIN аналог запроса
ON t.id = l.teacher_id

-- Вывести абсолютно всех учителей, даже если они ничего не ведут
SELECT
	t.surname,
    t.salary,
    l.course
FROM teacher t -- t - имя таблицы/псевдоним. Левая таблица
LEFT OUTER JOIN lesson l -- l - имя таблицы/псевдоним. LEFT JOIN аналог запроса. Правая таблица
ON t.id = l.teacher_id
WHERE l.teacher_id IS NULL; 

-- учителя, которые ведут только Веб
SELECT
	t.surname,
    t.salary,
    l.course
FROM teacher t -- t - имя таблицы/псевдоним. Левая таблица
LEFT OUTER JOIN lesson l -- l - имя таблицы/псевдоним. LEFT JOIN аналог запроса. Правая таблица
ON t.id = l.teacher_id
WHERE l.course = 'Знакомство с веб-технологиями'; 

-- Подзапросы
-- Вевести название должностей, средние ЗП которых выше средней по организации
SELECT *
FROM lesson_3.staff;

SELECT 
	AVG(salary),
    post
FROM lesson_3.staff
GROUP BY post
HAVING AVG(salary) > (SELECT AVG(salary) FROM lesson_3.staff);

