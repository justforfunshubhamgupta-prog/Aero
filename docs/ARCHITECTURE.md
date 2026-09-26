# Aero — Architecture

## High-Level Structure

```text
Aero.App
    │
    ├── Aero.Core
    │
    └── Aero.Infrastructure
              │
              └── Aero.Data
````

## Projects

### Aero.App

The WPF presentation layer.

Responsibilities:

* Windows
* Views
* ViewModels
* User interaction
* Visual resources
* Application startup

It should contain as little business logic as possible.

### Aero.Core

The application's domain and business logic.

Responsibilities:

* Domain models
* Interfaces
* Business rules
* Service contracts
* Feature logic that should remain platform-independent

Aero.Core should not depend on WPF or Windows-specific APIs.

### Aero.Data

Data persistence.

Responsibilities:

* SQLite connection
* Database initialization
* Migrations
* Repositories
* Full-text search
* Data persistence

### Aero.Infrastructure

Platform-specific functionality.

Responsibilities:

* Windows APIs
* Global hotkeys
* Clipboard integration
* Notifications
* File system operations
* OCR integration
* Other operating-system services

### Aero.Tests

Automated tests.

The initial focus should be testing Aero.Core.

## Dependency Rules

Aero.App may depend on:

* Aero.Core
* Aero.Infrastructure

Aero.Infrastructure may depend on:

* Aero.Core
* Aero.Data

Aero.Core should remain independent of:

* Aero.App
* Aero.Infrastructure
* Aero.Data

Aero.Data should not depend on Aero.App.

## Design Principles

### Separation of concerns

Each project should have a clear responsibility.

### Dependency inversion

Core logic should depend on interfaces rather than concrete infrastructure.

### Testability

Important business logic should be testable without launching the WPF application.

### Small modules

Features should be separated into focused services rather than large monolithic classes.

```