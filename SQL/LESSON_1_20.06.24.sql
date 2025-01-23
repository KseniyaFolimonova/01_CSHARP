CREATE DATABASE LESSON_1; -- создается база
USE LESSON_1; -- обращение к базе данных
CREATE TABLE STUDENTS ( -- создаю таблицу
ID INT AUTO_INCREMENT PRIMARY KEY, -- ДАЮ ПЕРВИЧНЫЙ КЛЮЧС АВТОМАТИЧЕСКОЙ НУМЕРАЦИЕЙ
NAME VARCHAR (45), 
COURSE_NAME VARCHAR (45), -- указали поле + тип данных формат ТЕКСТ
DR DATE NOT NULL,
EMAIL VARCHAR (55),
PHONE_NUMBER BIGINT NOT NULL);

INSERT INTO STUDENTS (NAME, COURSE_NAME, DR, EMAIL, PHONE_NUMBER)
VALUES
('Андрей', 'sql', '1977-12-20', 'andrey@yandex.ru', 89109102010),
('Вадим', 'python', '1991-02-02', 'vadim@yandex.ru', 89509500003),
('Ольга', 'makros', '2000-02-02', 'olga@yandex.ru', 89002003005),
('Анастасия', 'excel', '2002-11-09', 'anastasiya@yandex.ru', 89002009999);

CREATE TABLE TEACHERS ( -- создаю таблицу
ID INT AUTO_INCREMENT PRIMARY KEY, -- ДАЮ ПЕРВИЧНЫЙ КЛЮЧС АВТОМАТИЧЕСКОЙ НУМЕРАЦИЕЙ
NAME VARCHAR (45), 
COURSE_NAME VARCHAR (45), -- указали поле + тип данных формат ТЕКСТ
POST VARCHAR (45)
);

INSERT INTO TEACHERS (NAME, COURSE_NAME, POST)
VALUES
('Прохоров АВ', 'sql', 'Доктор'),
('Симонова НС', 'python', 'Профессор'),
('Турбина ТБ', 'makros', 'Доцент'),
('Токарев АА', 'excel', 'Лектор');

CREATE TABLE COURSE ( -- создаю таблицу
ID INT AUTO_INCREMENT PRIMARY KEY, -- ДАЮ ПЕРВИЧНЫЙ КЛЮЧС АВТОМАТИЧЕСКОЙ НУМЕРАЦИЕЙ
NAME_STUDENT VARCHAR (45), 
NAME_TEACHER VARCHAR (45),
COURSE_NAME VARCHAR (45) -- указали поле + тип данных формат ТЕКСТ
);

INSERT INTO COURSE (NAME_STUDENT, NAME_TEACHER, COURSE_NAME)
VALUES
('Андрей', 'Прохоров АВ', 'sql', 'Доктор'),
('Вадим', 'Симонова НС', 'python', 'Профессор'),
('Ольга', 'Турбина ТБ', 'makros', 'Доцент'),
('Анастасия', 'Токарев АА', 'excel', 'Лектор');

SELECT *FROM STUDENTS;
SELECT *FROM STUDENTS WHERE COURSE_NAME = 'excel';
/*SELECT *FROM STUDENTS WHERE NAME = 'Вадим';

SELECT NAME, COURSE_NAME FROM STUDENTS;
SELECT *FROM STUDENTS WHERE NAME LIKE 'А%'
*/
-- SELECT *FROM TEACHERS;