# Mpc.SampleCassandra

WebApi with Cassandra

## Endpoints

```http
GET  api/users
GET  api/users/{username}
POST api/users
```

## Configs

File appsettings.json

```json
{
  "Cassandra": {
      "ContactPoints": "127.0.0.1",
      "KeySpace": "mpc_sample"
  }
}
```

## Cql Scripts

Folder [cql-scripts](cql-scripts)

## Create Cassandra infrastructure (Docker)

For the first node:

```bash
docker run --name name-of-node cassandra
```

For the 2nd and 3rd nodes:

```bash
docker run --name name-of-new-node --link name-of-node:cassandra -d cassandra
```

How to go to the bash terminal of the docker container? Simple:

```bash
docker exec -it name-of-node bash
```

To see the status of the cluster:

```bash
nodetool status
```

## Usefull links

- http://datastax.github.io/csharp-driver/features/components/linq/
- https://www.youtube.com/watch?v=I_1L2vGaxA4
