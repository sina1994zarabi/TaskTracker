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


```bash
### Add a Task
task-cli add "Task description"
# Example:
task-cli add "Buy groceries"
# Output: Task added successfully (ID: 1)

### Update a Task
task-cli update <TaskID> "Updated task description"
# Example:
task-cli update 1 "Buy groceries and cook dinner"

### Delete a Task
task-cli delete <TaskID>
# Example:
task-cli delete 1

### Mark Task
task-cli mark-in-progress <TaskID>
# Example:
task-cli mark-in-progress 1

### List
task-cli list
task-cli list todo
task-cli list in-progress
