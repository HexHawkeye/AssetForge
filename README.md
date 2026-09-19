# AssetForge — Phase 4

The production-oriented release of the self-hosted .NET 10 asset and custody platform.

## Features

- Complete asset register, people directory and custody history
- QR codes, public-safe lookup and printable A4 labels
- Maintenance and repair workflow
- Supplier, repair cost, resolution and completion tracking
- Damaged/repair assets automatically return to Available when completed
- Warranty-expiry, asset-value and repair-cost reporting
- CSV inventory export
- Expanded maintenance audit events
- Automatic upgrade of Phase 3 SQLite databases when Phase 4 pages are opened
- Docker and Docker Compose with persistent storage
- GitHub Actions build and container verification

## Run

Open `AssetForge.sln`, start `AssetForge.Web`, and sign in with `admin` / `change-me-now` for local development. Copy an existing `assetforge.db` into `AssetForge.Web` before starting to retain Phase 3 data.

Docker:

```bash
docker compose up -d --build
```

Change the administrator password hash before exposing the application to a network.
