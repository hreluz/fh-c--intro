namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private List<Task> Tasks = _tasks;

        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("----- List of Tasks -------");
            WriteLine("\n{0,-8} {1,-35} {2,-15}", "Id", "Description", "Completed");
            foreach (var task in Tasks)
            {
                WriteLine(new string('-', 58));
                WriteLine("\n{0,-8} {1,-35} {2,-15}", task.Id, task.Description, task.Completed);
            }
        }
    }   
}
