/*
 Create
 Read - SELECT
 Update
 Delete
*/

UPDATE TextObject
SET Text = 'Terje'
WHERE Text = 'Torje'

SELECT * FROM TextObject

DELETE FROM TextObject
WHERE [Index] = 54444

SELECT [Index], Text FROM TextObject

SELECT  [Index], Text  
FROM TextObject
WHERE [Index] > 2

INSERT INTO TextObject
VALUES (5, 'Pål', 'green', 'gray')

INSERT INTO TextObject ([Index], Text)
VALUES (6, 'Ole')