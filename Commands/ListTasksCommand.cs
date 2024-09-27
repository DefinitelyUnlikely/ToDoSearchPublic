public class ListTasksCommand {
    public static void Execute(string[] commandArgs) {
        List<Task> tasks = TaskManager.GetAllTasks();

        foreach (Task task in tasks) {
            Console.WriteLine(task);
        }
    }
}