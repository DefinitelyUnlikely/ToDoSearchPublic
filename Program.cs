/*
Todo applikation

- Skapa todos
    - Titel för task
    - Beskrivning för task
    - Datum + deadline för task
    - Label för task (kategorisera)
    - Upprepande tasks
    - create <title> <description>
- Radera todos
    - remove <title>
- Avklara todos
    - complete <title>
    - uncomplete <title>
- Uppdatera todos
    - update <title> <description>

    // MENU

Klasser:
- Task
    - description
    - title
    - label
    - date
    - deadline
- Calender
- Command (en för varje kommando)
- TaskManager
- CommandManager

*/
using System.Text;

class Program
{
    public static bool running = true;

    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("Welcome to the todo app. Type 'help' for a list of commands.");

        List<Task> tasks = TaskManager.GetAllTasks();
        foreach (Task task in tasks)
        {
            if (task.DeadlineDate.Day + 1 >= DateTime.Now.Day)
            {
                Console.WriteLine("Remember to complete task " + task.Title);
            }
        }

        while (running)
        {
            string input = Console.ReadLine()!;
            try
            {
                CommandManager.TryExecuteCommand(input);
            }
            catch (Exception exception)
            {
                Console.WriteLine("An error has occurred: " + exception.Message);
            }
        }
    }
}
