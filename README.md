# .NET Design Patterns

A compact, practical collection of C# examples demonstrating common software design patterns. Each folder contains a focused, runnable demo that illustrates the pattern's intent, structure, and a minimal implementation you can read and execute.

**Status:** Repository modernized to .NET 8.0 where applicable. Some legacy projects were updated; see project files for details.

## Quick Start

Prerequisites
- Install the .NET SDK 8.0 or later: https://dotnet.microsoft.com

Run the root demo (from repository root):

```bash
dotnet run --project DesignPatterns.csproj
```

To run an individual pattern demo, change into its folder and run:

```bash
dotnet run
```

## Repository Structure

- `DesignPatterns.csproj` — root demo/runner and entrypoint for the collection.
- Each pattern is hosted in its own folder (e.g., `Behavioral.Observer`, `Creational.Builder`).
- `Images/` — illustrative diagrams used in the README and examples.

## Patterns Included

The examples are grouped by category; each folder contains a short demo and supporting code.

Creational
- Abstract Factory
- Builder
- Factory Method
- Prototype
- Singleton

Structural
- Adapter
- Bridge
- Composite
- Decorator
- Facade
- Flyweight
- Proxy

Behavioral
- Chain of Responsibility
- Command
- Interpreter
- Iterator
- Mediator
- Memento
- Observer
- State
- Strategy
- Template Method
- Visitor

## How the examples are organized

- Each pattern folder usually contains:
  - `Program.cs` — a small runnable example.
  - `Abstract*/`, `Concrete*/`, and other supporting folders for a clear structure.
- Keep examples small and focused — they are intended for learning and quick reference, not production-ready libraries.

## Notes about the codebase

- The repository was migrated toward SDK-style projects and `net8.0` targets. During migration some legacy assembly metadata files were removed to avoid duplicate assembly attribute errors.
- If you encounter build issues, run a full clean of generated artifacts and rebuild:

```bash
find . -type d \( -name bin -o -name obj \) -prune -exec rm -rf {} +
dotnet clean
dotnet build
```

## Contributing

- Open an issue to discuss changes or submit a pull request.
- Suggested improvements: add short console output examples to each `Program.cs`, normalize project targets, and convert README image links to local relative paths for offline viewing.

## Next steps I can do for you

- Convert README image links to local relative paths, or
- Add a linked Table of Contents with anchors for each pattern.

---
Made concise and ready for readers; tell me which next step you want.
