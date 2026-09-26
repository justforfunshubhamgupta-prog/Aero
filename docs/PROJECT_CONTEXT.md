# Aero — Project Context

## Overview

Aero is a lightweight, privacy-first Windows utility suite.

The goal is to combine several small, frequently useful utilities into one fast application rather than requiring users to install many separate tools.

## Target Platform

Windows 10 and Windows 11.

## Primary Goals

1. Fast startup
2. Low RAM usage
3. Low CPU usage while idle
4. Local-first operation
5. Privacy
6. No mandatory account
7. No mandatory cloud service
8. No mandatory AI API
9. Simple user experience
10. Open-source development

## Technology

- Language: C#
- Runtime: .NET 10
- UI: WPF
- Database: SQLite
- Search: SQLite FTS5
- Testing: xUnit

## Planned Modules

### V1

1. Clipboard
2. Screenshot Organizer
3. Reminders
4. Link Analyzer
5. Smart Paste

### Deferred

6. Downloads Cleaner
7. Send Anywhere

## AI Philosophy

AI must be optional.

Aero's fundamental functionality must not depend on paid AI APIs.

If AI functionality is added, the architecture should allow multiple providers and ideally local processing where practical.

## Storage Philosophy

User data should remain local by default.

Aero should not require a remote database for normal operation.

SQLite is the primary local data store.

## Architecture Philosophy

Keep application logic independent from:

- WPF
- Windows APIs
- SQLite
- external AI providers

This makes the application easier to test, maintain, and extend.

## Current Development Stage

Pre-MVP.

The first implementation target is the Clipboard module.