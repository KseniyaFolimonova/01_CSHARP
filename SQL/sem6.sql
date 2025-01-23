USE lesson_4;

START TRANSACTION;
INSERT INTO users (firstname, lastname, email)
VALUES ('Дмитрий', 'Дмитров', 'dima@mail.ru');

SET @last_user_id = last_insert_id();
-- SET @last_user_id = (SELECT id FROM users WHERE email = 'dima@mail.ru');

INSERT INTO profiles (user_id, hometown, birthday, photo_id)
VALUES (@last_user_id, 'Moscow', '1999-10-10', NULL);

COMMIT; 
-- ROLLBACK

SELECT * FROM users u 
LEFT JOIN profiles p ON u.id = p.user_id
ORDER BY u.id DESC;

/*
UPDATE users
SET email = 'new_email@example.com'
WHERE id IN (1, 2, 3);
*/
DROP PROCEDURE IF EXISTS sp_user_add;
DELIMITER //
CREATE PROCEDURE sp_user_add
(
	OUT tran_res VARCHAR(100)
)
BEGIN
	DECLARE seminar_6 BIT DEFAULT 0; -- b'0'
    
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION
    BEGIN
		SET seminar_6 = b'1';
	END;
    
	START TRANSACTION;
    
    INSERT INTO users (firstname, lastname, email)
	VALUES ('Дмитрий_3', 'Дмитров', 'dima_3@mail.ru');

	SET @last_user_id = LAST_INSERT_ID();
	-- SET @last_user_id = (SELECT id FROM users WHERE email = 'dima@mail.ru');

	INSERT INTO profiles (user_id, hometown, birthday, photo_id)
	VALUES (@last_user_id, 'Moscow', '1999-05-10', NULL);
	
    IF seminar_6 THEN
		SET tran_res = 'ROLLBACK';
		ROLLBACK;
	ELSE
		SET tran_res = 'COMMIT';
		COMMIT;
	END IF;
END //
DELIMITER ;

CALL sp_user_add(@tran_res);
SELECT @tran_res;
