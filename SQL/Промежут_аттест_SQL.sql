/*Урок 6. SQL – Транзакции. Временные таблицы, управляющие конструкции, циклы
1. Создайте функцию, которая принимает кол-во сек и формат их в кол-во дней часов.
Пример: 123456 ->'1 days 10 hours 17 minutes 36 seconds '
*/

DROP PROCEDURE IF EXISTS time_sec;
DELIMITER $$
CREATE PROCEDURE time_sec
(
	IN input_time_sec INT
)
BEGIN
	DECLARE n INT DEFAULT input_time_sec;
	DECLARE result VARCHAR(45) DEFAULT '';
	DECLARE days INT DEFAULT 0;
    DECLARE hours INT DEFAULT 0;
	DECLARE minutes INT DEFAULT 0;
	DECLARE seconds INT DEFAULT 0;

	SET days = n / (60*60*24); -- 86400 sec in 1 days
    SET hours = n % (60*60*24) / (60*60); -- 3600 in 1 hour
    SET minutes = FLOOR(((n % (60*60*24)) % (60*60)) / 60); -- ((n % (60*60*24)) % (60*60)) / 60; -- 60 in 1 minutes
	SET seconds = n % 60;
	SET result = CONCAT(result, days, ' days ', hours, ' hours ', minutes, ' minutes ', seconds, ' seconds');

SELECT result;
END ;
CALL time_sec(123456);

/*2. Выведите только чётные числа от 1 до 10.
Пример: 2,4,6,8,10*/
-- SELECT @input_number := 10;
DROP PROCEDURE IF EXISTS even_numbers;
DELIMITER $$
CREATE PROCEDURE even_numbers
(
	IN input_number INT
    -- OUT even_number VARCHAR(20)
)
BEGIN 
	DECLARE n INT DEFAULT input_number;
    DECLARE result_even_num VARCHAR(100) DEFAULT '';
REPEAT
	IF n % 2 = 0 
		THEN SET result_even_num = CONCAT(result_even_num, n, ',');
	END IF;
	SET n = n + 1;
UNTIL n > 10
END REPEAT;
SELECT result_even_num;
END ;
CALL even_numbers(1);
