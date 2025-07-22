[![Maintainability](https://api.codeclimate.com/v1/badges/1efca555bd2b4852e9b1/maintainability)](https://codeclimate.com/github/bcgov/jag-csrs-portal-public/maintainability) [![Test Coverage](https://api.codeclimate.com/v1/badges/1efca555bd2b4852e9b1/test_coverage)](https://codeclimate.com/github/bcgov/jag-csrs-portal-public/test_coverage)

[![img](https://img.shields.io/badge/Lifecycle-Experimental-339999)](https://github.com/bcgov/repomountie/blob/master/doc/lifecycle-badges.md)  

# jag-csrs-portal-public

Welcome to CSRS Portal Public

## Project Structure

    ├── src                                     # application source files
    |   ├── backend                             # backend apis
    │   └── frontend                            # frontend applications
    │       └── csrs-portal                     # csrs portal
    ├── CONTRIBUTING.md                         #
    ├── LICENSE                                 # Apache License
    └── README.md                               # This file.

## Apps

| Name                | Description                                  | Doc                             |
| ------------------- | -------------------------------------------- | --------------------------------|
| frontend            | all client side applications                 | [README](src/frontend/README.md)|


# Splunk Docker Examples

https://splunk.github.io/docker-splunk/EXAMPLES.html#create-standalone-with-hec

#### Docker

[Download](https://www.docker.com/products/docker-desktop) and install Docker

# Run docker-compose

Copy the `.env.template` to `.env` and then run docker-compose up.
Add the configuration for token and password for splunk.
Default user is `admin`. Password is what is configured in `.env`

```
docker-compose up
```

The frontend app csrs-portal will be accessible in the browser at http://localhost:8080 

To remove services run (all services and networking)
```
docker-compose down
```





## Run CSRS Portal Locally with Docker Compose

   1. Navigate to the project root:
    cd jag-csrs-portal-public\

   2. Build the containers (API, Frontend, etc.):
    docker compose build

   3. Start the containers:
    docker compose up

   4. To shut everything down cleanly:
    docker compose down

   5. To force a rebuild (use after Dockerfile changes):
    docker compose down && docker compose build --no-cache && docker compose up

    🚨 Known issue on Windows:
    You may need to trust the development certificate if the backend uses HTTPS.

    Run the following once:
    dotnet dev-certs https --trust

## Debug CSRS API Locally with VS

    1. If breakpoints aren’t hit during debugging, ensure Dockerfile includes .pdb files and that -c Debug is set during build/publish.

    2. To attach the debugger in VS  to the jag-csrs-api process running inside Docker (Linux Container, Docker type)

    3. Select Docker debug profile

    4. For Connection type select Docker (Linux Container)

    5. For Connection target select jag-csrs-api

    6. Filter processes ( 'dotnet') and select the process
