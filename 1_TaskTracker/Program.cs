using System.Reflection.Metadata.Ecma335;
using TaskTracker.Services;
using System;   

while (true)
{
    Console.WriteLine("Enter Command: ");
    char[] delimeters = new char[] {' ','-'};
    string[] commandParts = Console.ReadLine().Split(delimeters,StringSplitOptions.RemoveEmptyEntries);
    string instruction = commandParts[0];
    TaskServices taskServices = new TaskServices();
    switch (instruction.ToLower())
    {
        case "add":
            if (commandParts[1].StartsWith('"'))
            {
                string description = string.Empty;
                for (int i = 1; i < commandParts.Length; i++)
                {
                    description += commandParts[i].Replace('"', ' ').Trim() + " ";
                }
                taskServices.AddNewTask(description);
            }
            else
            {
                Console.WriteLine("Invalid Parameter for Add Instruction");
                continue;
            }
            break;
        case "update":
            if (char.IsDigit(char.Parse(commandParts[1]))){
                if (commandParts[2].StartsWith('"'))
                {
                    string newDescription = string.Empty;
                    for (int i = 2; i < commandParts.Length; i++)
                    {
                        newDescription += commandParts[i].Replace('"', ' ').Trim() + " ";
                    }
                    taskServices.UpdateTask(int.Parse(commandParts[1]), newDescription);
                }
                else { 
                    Console.WriteLine("Invalid Parametr For Update Instruction.");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("Enter a valid Id");
                continue;
            }
            break;
        case "delete":
            if (char.IsDigit(char.Parse(commandParts[1])))
            {
                taskServices.DeleteTask(int.Parse(commandParts[1]));
            }
            else
            {
                Console.WriteLine("Enter The ID Of The Task");
            }
            break;
        case "list":
            if (commandParts.Length > 1)
            {
                string newStatus = string.Empty;
                for (int i = 1; i < commandParts.Length; i++){
                    newStatus += commandParts[i];
                }
                switch (newStatus.ToLower())
                {
                    case "done":
                        taskServices.DisplayCompletedTasks();
                        break;
                    case "todo":
                        taskServices.DisplayFailedTasks();
                        break;
                    case "inprogress":
                        taskServices.DisplayInProgressTasks();
                        break;
                    default:
                        Console.WriteLine("Invalid Parameter Option for List Instruction");
                        break;
                }
            }
            else taskServices.DisplayAllTasks();
            break;
        case "mark":
            if (commandParts.Length == 4) {
                if (commandParts[1].ToLower() + commandParts[2].ToLower() == "inprogress"){
                    if (int.TryParse(commandParts[3],out int id)){
                        taskServices.ChangeStatus(id,TaskTracker.Entity.status.InProgress);
                    }
                    else Console.WriteLine("Invalid Id");
                }
                else System.Console.WriteLine("Invalid new status");
            } else if (commandParts.Length == 3) {
                if (commandParts[1].ToLower() == "done") {
                    if (int.TryParse(commandParts[2],out int id)) {
                        taskServices.ChangeStatus(id,TaskTracker.Entity.status.Done);
                    }
                    else System.Console.WriteLine("Invalid Id");
                }
                else System.Console.WriteLine("Invalid status");
            }
            else System.Console.WriteLine("Invalid instruction for changing task status");
            break;
        case "exit":
            return;
        default:
            Console.WriteLine("Invalid Instruction");
            break;
    }
}

