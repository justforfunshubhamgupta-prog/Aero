# Aero — Architecture Decisions

This document records important technical decisions and their reasoning.

---

## ADR-001 — Use C#

Status: Accepted

### Decision

Use C# as Aero's primary programming language.

### Reason

C# provides strong Windows integration, mature tooling, excellent .NET libraries, and good support for WPF desktop applications.

---

## ADR-002 — Use WPF

Status: Accepted

### Decision

Use WPF for the initial Aero desktop interface.

### Reason

WPF is mature, well-supported, Windows-native, and suitable for building a lightweight desktop application.

---

## ADR-003 — Use SQLite

Status: Accepted

### Decision

Use SQLite as Aero's local database.

### Reason

Aero is primarily a local desktop application.

SQLite:

- Requires no database server
- Works offline
- Has low resource usage
- Is portable
- Is free
- Is well suited to local application data

---

## ADR-004 — AI Is Optional

Status: Accepted

### Decision

Aero's core functionality must not require an AI API.

### Reason

Users should be able to use Aero without:

- API keys
- subscriptions
- cloud accounts
- internet access for core features

---

## ADR-005 — Open Source

Status: Accepted

### Decision

Aero will be developed publicly on GitHub.

### Reason

Open development allows community contributions, transparency, and public review of the project's code.

---

## ADR-006 — MIT License

Status: Accepted

### Decision

Aero is released under the MIT License.

### Reason

The MIT License allows broad use, modification, redistribution, and commercial use while remaining simple and permissive.