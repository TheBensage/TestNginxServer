# Local Server Simulation

This project sets up a **local Nginx + Docker environment** that simulates a real server running a .Net and a Node project

## Features

- .NETApp → `http://localhost:5000`
- NodeApp → `http://localhost:3000`
- nginx → `http://localhost:8080/nodeapp`, `http://localhost:8080/dotnetapp`
- Deployment simulation with `deploy.sh`

## Run locally (Clear all and run fresh)

```bash
docker-compose down --rmi all --volumes --remove-orphans && docker-compose build --no-cache && docker-compose up -d --force-recreate

```
