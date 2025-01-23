USE lesson_3;

SELECT * FROM lesson_3.staff;

SELECT 
    post, MAX(salary)
FROM
    staff
GROUP BY post;

SELECT
	post,
    salary,
    DENSE_RANK() OVER(ORDER BY salary DESC) AS result
FROM staff;

SELECT
	post,
    salary,
    DENSE_RANK() OVER(PARTITION BY post ORDER BY salary DESC) AS `dense_rank` -- PARTITION BY группировка внутри окна OVER 
FROM staff;

-- вывсети в каждой должности самую высокую ЗП
SELECT *
FROM (SELECT
	post,
    salary,
    DENSE_RANK() OVER(PARTITION BY post ORDER BY salary DESC) AS `dense_rank` -- PARTITION BY группировка внутри окна OVER 
FROM staff) AS rank_staff
WHERE `dense_rank` = 1 OR `dense_rank` = 2;

-- Агрегирующие оконные функции 
-- ср. зп
-- сум. ЗП по должностям 
-- сум ЗП по заводу
-- % соотн. ЗП чпстного к общей ЗП долности
-- % соотн. ЗП частной к общей по заводу 
SELECT
	post,
    salary,
    ROUND(AVG(salary) OVER (PARTITION BY post), 2) AS avg_salary,
    SUM(salary) OVER (PARTITION BY post) AS sum_salary,
    SUM(salary) OVER () AS total_salary,
    ROUND(salary * 100 / SUM(salary) OVER(PARTITION BY post), 2) AS persent_sum,
    ROUND( salary * 100 / SUM(salary) OVER (), 2) AS persent_count
FROM staff;
    
SELECT
	post,
    salary,
    ROUND(AVG(salary) OVER w, 2) AS avg_salary,
    SUM(salary) OVER w AS sum_salary,
    SUM(salary) OVER w1 AS total_salary,
    ROUND(salary * 100 / SUM(salary) OVER w, 2) AS persent_sum,
    ROUND( salary * 100 / SUM(salary) OVER w1, 2) AS persent_count
FROM staff
WINDOW w AS (PARTITION BY post),
w1 AS ();
    


