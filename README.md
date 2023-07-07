# Training Journal API Web Server with IO.Swagger and ASP.NET Core 7.0 Server
This project serves as a practice project to develop a REST API web service. This a personal training journal API Server based on the OpenAPI 3.0 specification.

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```

