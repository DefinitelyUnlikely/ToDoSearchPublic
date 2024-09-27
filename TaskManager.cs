public class TaskManager {
    private static Dictionary<string, Task> tasks = new Dictionary<string, Task>();
    
    public static void AddTask(Task task) {
        tasks.Add(task.Title, task);
    }

    public static Task? RemoveTask(string title) {
        if (tasks.ContainsKey(title)) {
            Task task = tasks[title];
            tasks.Remove(title);
            return task;
        } 

        return null;
    }

    public static Task? GetTask(string title) {
        return tasks[title];
    }

    public static List<Task> GetAllTasks() {
        List<Task> list = new List<Task>();
        foreach (KeyValuePair<string, Task> pair in tasks) {
            list.Add(pair.Value);
        }
        return list;
    }
}