using System.Globalization;

public class CreateTaskCommand
{
    public static void Execute(string[] commandArgs)
    {
        if (commandArgs.Length != 2)
        {
            throw new ArgumentException("Usage: create <title>");
        }

        string title = commandArgs[1];

        // TODO: Lägg kod för att skapa task
        Console.WriteLine("Create: " + commandArgs[1]);

        Console.WriteLine("Enter description: ");
        string description = Console.ReadLine()!;

        Console.WriteLine("Enter label:");
        string label = Console.ReadLine()!;

        Console.WriteLine("Enter deadline date (yyyy-MM-dd):");
        string deadlineDate = Console.ReadLine()!;

        DateTime deadline;

        try
        {
            deadline = DateTime.ParseExact(
                deadlineDate,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture
            );
        }
        catch (Exception)
        {
            deadline = DateTime.Now;
        }

        Task task = new Task
        {
            Title = title,
            Description = description,
            Label = label,
            CreationDate = DateTime.Now,
            DeadlineDate = deadline,
        };

        Console.WriteLine(task.ToString());

        TaskManager.AddTask(task);
    }

    public static void Populate()
    {
        try
        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("todo.txt", System.Text.Encoding.UTF8))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    string[] input = line.Split();

                    Task task = new Task
                    {
                        Title = input[0],
                        Description = input[1],
                        Label = input[2],
                        CreationDate = DateTime.Parse(input[3]),
                        DeadlineDate = DateTime.Parse(input[4]),
                    };
                    TaskManager.AddTask(task);
                }
            }
        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}
