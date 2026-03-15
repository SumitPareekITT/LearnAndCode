# LearnAndCode
# Coding Guidelines

## 1. Naming
- Use meaningful, readable, and searchable names.
- Classes and files → `UpperCamelCase`
- Methods, variables, parameters → `lowerCamelCase`
- Constants → `UPPER_SNAKE_CASE`
- Use consistent terminology across the codebase.

## 2. Functions
- Keep functions small and focused.
- A function should perform one task only.
- Use clear, descriptive function names.
- Prefer fewer parameters; wrap many parameters in an object.
- Follow the DRY principle.

## 3. Comments
- Prefer self-explanatory code over comments.
- Use comments for intent, warnings, and TODOs.
- Avoid redundant or outdated comments.

## 4. Formatting

### Vertical Formatting
- Separate logical sections with blank lines.
- Keep related code close together.
- Place higher-level methods before helper methods.
- End every file with a single newline.

### Horizontal Formatting
- Keep line length readable.
- No space between method name and parentheses.
- Always use braces for `if`, `for`, and `while`.

## 5. Classes
- One top-level class per file.
- Each class should have a single responsibility.
- Maintain high cohesion.
- Order members: constants → static fields → instance fields → constructors → public methods → private methods.

## 7. Objects and Data Structures
- Objects encapsulate data and behavior.
- Data structures expose data without behavior.
- Avoid mixing both patterns.

## 8. Design Principles
- Single Responsibility Principle.
- Open for extension, closed for modification.
- Prefer small, focused interfaces.
- Depend on abstractions rather than implementations.

## 9. PR Description
- Problem statement should mention in the description itself.
- Every PR will have description about the solution of assignment.

## 10. Branching Name
- assignment-xx-chapterName