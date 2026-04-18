#!/usr/bin/env bash
set -euo pipefail

echo "==> Updating .NET workloads..."
dotnet workload update --skip-sign-check --no-cache 2>/dev/null || true

echo "==> Installing dotnet-ef tool..."
dotnet tool install -g dotnet-ef || dotnet tool update -g dotnet-ef

echo "==> Trusting dev certs..."
dotnet dev-certs https --trust

echo "==> Restoring NuGet packages..."
dotnet restore

echo "==> Done!"
