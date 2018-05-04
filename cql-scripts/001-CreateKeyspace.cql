CREATE KEYSPACE IF NOT EXISTS mpc_sample 
WITH replication = {
	'class' : 'SimpleStrategy',
	'replication_factor' : 1
};
