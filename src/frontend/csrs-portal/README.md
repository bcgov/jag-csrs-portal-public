# csrs Portal

## Installation and Configuration

The installation and configuration of the CSRS development environment is sequentially ordered to ensure software dependencies are available when needed during setup.

### Installation

The following list includes the required software needed to run the application, as well as, the suggested IDE with extensions for web client development, and software for source control management and API development/testing.

#### Git and GitKraken

[Download](https://git-scm.com/downloads) and install the Git version control system, and optionally [download](https://www.gitkraken.com) and install the free GitKraken Git GUI client.

Clone the CSRS repository into a project directory GitKraken or the terminal by typing:

```bash
git clone https://github.com/bcgov/jag-csrs-portal-public
```

#### Node

[Download](https://nodejs.org/en/) and install **Node v14.x**

#### Angular cli

Install Angular cli using command:

```bash
yarn add @angular/cli
```

#### VS Code

[Download](https://code.visualstudio.com/) and install VSCode and accept the prompt to install the recommended extensions when the PRIME repository is initially opened in VSCode.

#### PostMan

[Download](https://www.getpostman.com/apps) and install the Postman HTTP client.

## Building and Running

### Client

To build, run, and open the Angular application in the default browser at <http://localhost:4200> for development go to the csrs Portal project repository in the terminal and type:

```bash
yarn start
```

To test the production build locally before pushing features to the repository for deployment type:

```bash
ng build --configuration production
```

#### Angular CLI Reference

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 10.1.x. Refer to the Angular CLI documentation for the available commands, but the most used commands during development will be:

1. `yarn install` to install any packages that the application depends on.
2. `ng serve -o` to serve your application locally in memory during development at `http://localhost:4200` through the default browser, which watches for changes, recompiles, and automatically refresh the application in the browser
3. `ng build` to build the application, which is stored in `/dist` directory. Use the `--prod` flag for a production build, which significantly decreases the size of the application
4. `ng g <blueprint>` to create code scaffolding for a directive, pipe, service, class, guard, interface, enum, and module
5. `ng lint` to lint the application code using TSLint.
6. `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).
7. `ng e2e` to execute the end-to-end tests via [Protractor](http://www.protractortest.org/).

##### Getting Help

1. To get more help on the Angular CLI use `ng help`
2. `ng doc component` to look up documentation for features
3. `ng serve --help` to look up doc for `ng serve` command

## Coding Styles

Coding styles should adhere to the [Angular Style Guide](https://angular.io/docs/ts/latest/guide/style-guide.html) at all times! The editor config setup for the project will also assist with coding style automatically, as well as VSCode settings.




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
