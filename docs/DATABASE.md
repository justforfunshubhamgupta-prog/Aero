# Aero — Database

## Database Engine

SQLite.

## Location

The database should be stored in the user's local application-data directory.

The exact path will be determined during implementation.

## Principles

- Database is local.
- Database should not contain secrets.
- Database operations should be abstracted behind repositories/services.
- Schema changes should use migrations.
- Destructive migrations should be avoided where possible.

## Planned Data

### Clipboard

Potential fields:

- Id
- Content
- ContentType
- CreatedAt
- LastUsedAt
- IsPinned

### Screenshots

Potential fields:

- Id
- FilePath
- CreatedAt
- OCRText
- Category
- Hash

### Reminders

Potential fields:

- Id
- Title
- Description
- ScheduledAt
- CreatedAt
- CompletedAt
- IsCompleted

The final schema will be designed during implementation rather than prematurely finalized.