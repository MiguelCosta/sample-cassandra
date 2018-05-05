CREATE TABLE IF NOT EXISTS mpc_sample.user (
	username text,
	name text,
	birthday timestamp,
	PRIMARY KEY (username)
);


INSERT INTO mpc_sample.user (username, birthday, name)
	VALUES('miguelcosta', '1990-03-28', 'Miguel Costa');

SELECT * FROM mpc_sample.user WHERE username = 'miguelcosta';
SELECT * FROM mpc_sample.user WHERE username = 'miguelcostaa';