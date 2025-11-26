#!/bin/bash
set -e

echo "Building .NET and Node apps..."
docker-compose build dotnetapp
docker-compose build nodeapp

echo "Starting containers..."
docker-compose up -d

echo "Deployment simulation complete!"
