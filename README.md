<div>
  <img src="https://img.shields.io/badge/version-0.1.0-%236C63FF" />
</div>

<br/>

<div>
  <img src="https://img.shields.io/badge/Docker-%230db7ed.svg?style=flat&logo=docker&logoColor=white" />
  <img src="https://img.shields.io/badge/.NET Core 6.0-512BD4?style=flat&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/MS%20SQL%20Sever-00000F?style=flat&logo=microsoft%20sql%20server&logoColor=white" />
  <img src="https://img.shields.io/badge/-Swagger-%23Clojure?style=flat&logo=swagger&logoColor=white" />
</div>


# ProjectWe

An app that allows users to plan and manage community projects.

Features:
- Project Management with Project Framework
- Report Generation
- Recommendation System
- Voting System

<br/>

## Getting Started

To run the development server locally you will need to install the following tools:
- [.NET SDK (6.0)](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [Docker](https://www.docker.com/)


### Development server

To start development server, you need to clone the repository:

```bash
git clone https://github.com/mirzaceligija/FIT-RS2-ProjectWe.git
```

#### Docker

```bash
docker-compose up --build
```

Note: Please wait for a few seconds for a database to be created and seeded.

#### Credentials
Username: Admin
Password: Test123!

Username: Manager
Password: Test123!

#### Useful commands
flutter pub run build_runner build