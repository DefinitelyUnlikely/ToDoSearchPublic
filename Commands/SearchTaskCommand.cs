public class SearchTaskCommand
{
    public static void Execute(string[] commandArgs)
    {
        if (commandArgs.Length < 3)
        {
            throw new ArgumentException("Usage: search 'category' 'searchtext'");
        }

        List<Task> tasks = TaskManager.GetAllTasks();
        List<Task> resultList = [];

        switch (commandArgs[1])
        {
            case "label":

                foreach (Task task in tasks)
                {
                    if (task.Label.Equals(commandArgs[2]))
                    {
                        resultList.Add(task);
                    }
                }
                break;

            case "description":

                foreach (Task task in tasks)
                {
                    if (task.Description.ToLower().Contains(commandArgs[2].ToLower()))
                    {
                        resultList.Add(task);
                    }
                }
                break;
            case "deadline":
                if (commandArgs[2] == "today")
                {
                    DateTime today = DateTime.Now;
                    foreach (Task task in tasks)
                    {
                        if (
                            task.DeadlineDate.DayOfYear == today.DayOfYear
                            && task.DeadlineDate.Year == today.Year
                        )
                        {
                            resultList.Add(task);
                        }
                    }
                }
                else
                {
                    foreach (Task task in tasks)
                    {
                        DateTime date = DateTime.Parse(commandArgs[2]);
                        if (
                            task.DeadlineDate.DayOfYear == date.DayOfYear
                            && task.DeadlineDate.Year == date.Year
                        )
                        {
                            resultList.Add(task);
                        }
                    }
                }
                break;

            case "created":

                foreach (Task task in tasks)
                {
                    DateTime date = DateTime.Parse(commandArgs[2]);
                    if (
                        task.DeadlineDate.DayOfYear == date.DayOfYear
                        && task.DeadlineDate.Year == date.Year
                    )
                    {
                        resultList.Add(task);
                    }
                }
                break;
        }

        if (resultList.Count == 0)
        {
            return;
        }
        else
        {
            Console.Clear();
            foreach (Task task in resultList)
            {
                Console.WriteLine(task);
            }
        }
    }
}
