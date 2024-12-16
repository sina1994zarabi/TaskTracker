# Task Tracker CLI
Project Task URL : <a href="https://roadmap.sh/projects/task-tracker">https://roadmap.sh/projects/task-tracker</a>

**Task Tracker CLI** is a simple command-line application to help you manage and track tasks efficiently. This project allows you to create, update, delete, and monitor tasks while storing all data in a JSON file.

## Features

- Add, update, and delete tasks.
- Mark tasks as **in progress** or **done**.
- List tasks based on their status:
  - All tasks.
  - Completed tasks.
  - Pending tasks.
  - Tasks in progress.

## Requirements

- Built using `.NET` and C#.
- Uses the **native filesystem** to manage tasks.
- Stores data in a JSON file created in the current directory.

## Commands

### Add a Task
```bash
task-cli add "Task description"
# Example:
task-cli add "Buy groceries"
# Output: Task added successfully (ID: 1)

