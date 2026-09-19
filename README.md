# AssetForge

[![Build](https://github.com/HexHawkeye/AssetForge/actions/workflows/ci.yml/badge.svg)](https://github.com/HexHawkeye/AssetForge/actions/workflows/ci.yml)
[![.NET](https://img.shields.io/badge/.NET-10-512BD4)](https://dotnet.microsoft.com/)
[![Docker](https://img.shields.io/badge/Docker-ready-2496ED)](https://www.docker.com/)

AssetForge is a self-hosted IT asset and equipment-custody platform built with ASP.NET Core, Razor Pages, EF Core and .NET 10. It provides a complete record of equipment, ownership, condition, maintenance and lifecycle history.

It was created as a portfolio-quality application that demonstrates full-stack .NET development, relational data modelling, business workflows, QR-code integration, reporting, authentication and container deployment.

## Features

### Asset management

- Complete asset register with unique asset tags
- Categories, locations and departments
- Manufacturer, model and serial-number recording
- Purchase price, purchase date and warranty expiry
- Available, Assigned, Repair, Lost and Retired states
- Search and status filtering
- Fictional demonstration data for evaluation

### Custody and assignments

- People and employee directory
- Assign and return equipment
- Issue and return condition recording
- Expected-return dates and overdue highlighting
- Handover references and notes
- Complete custody history
- Protection against simultaneous duplicate assignments

### QR codes and labels

- Unique QR code for every asset
- Public-safe mobile lookup pages
- SVG QR-code downloads
- Printable A4 batch label sheets
- Public pages hide serial numbers, prices, notes and holder information

### Maintenance and reporting

- Maintenance and repair workflow
- Supplier, issue, cost and resolution tracking
- Repair completion automatically restores an asset to Available
- Warranty-expiry reporting
- Total recorded asset value
- Lifetime repair-cost reporting
- CSV inventory export
- Expanded audit events for important lifecycle actions

### Deployment

- SQLite database for simple self-hosting
- Automatic upgrade of an existing Phase 3 database
- Docker and Docker Compose support
- Persistent container storage
- GitHub Actions build and container verification

## Technology

- ASP.NET Core .NET 10
- Razor Pages
- Entity Framework Core
- SQLite
- QRCoder
- Docker and Docker Compose
- GitHub Actions

## Solution structure

```text
AssetForge.sln
├── AssetForge.Core
│   └── Domain models
├── AssetForge.Infrastructure
│   └── EF Core persistence and database upgrades
└── AssetForge.Web
    ├── Razor Pages
    ├── Authentication
    └── Responsive interface
```

## Running locally

### Requirements

- .NET 10 SDK
- Visual Studio 2026 or another .NET-compatible editor

Clone the repository:

```bash
git clone https://github.com/HexHawkeye/AssetForge.git
cd AssetForge
```

Restore and run:

```bash
dotnet restore AssetForge.sln
dotnet run --project AssetForge.Web
```

Open the address printed in the terminal.

The development login is:

```text
Username: admin
Password: change-me-now
```

Change the administrator password hash before exposing AssetForge to a network.

## Docker

Build and start AssetForge:

```bash
docker compose up -d --build
```

Open:

```text
http://localhost:8080
```

The SQLite database is retained in the `assetforge-data` Docker volume.

Stop the application with:

```bash
docker compose down
```

## Upgrading from Phase 3

Copy the existing `assetforge.db` into the new `AssetForge.Web` directory before starting the application. Phase 4 creates its maintenance tables automatically when the new features are first used.

Back up the database before any upgrade.

## QR-code deployment note

QR labels use the hostname from the current request. Before printing labels, access AssetForge using the hostname or IP address that phones will use, rather than `localhost`.

For example:

```text
http://assetforge.example.local:8080
```

## Security

AssetForge is intended to run behind HTTPS or a trusted reverse proxy in production.

- Replace the default administrator password before deployment.
- Never commit populated databases, `.env` files or credentials.
- Keep public lookup pages free of personal and commercially sensitive data.
- Restrict administrative access to trusted users and networks.
- Back up the SQLite database regularly.

## Roadmap

- Role-based administrator and operator permissions
- File and image attachments
- CSV import with validation preview
- Email warranty and overdue reminders
- Configurable label templates
- SQL Server support
- Automated integration tests


