public class HelpCommand {
    public static void Execute(string[] commandArgs) {
        Console.WriteLine("Commands:");
        Console.WriteLine(" create <title> - Create and save a task.");
        Console.WriteLine(" remove <title> - Remove a task.");
        Console.WriteLine(" complete <title> - Mark task as completed.");
        Console.WriteLine(" list - List all saved tasks.");
        Console.WriteLine(" stop, exit - Exit the application.");
    }
}