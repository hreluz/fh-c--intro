using BetterConsoleTables;

namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private List<Task> Tasks = _tasks;

        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.DarkBlue;

            Table table = new Table("Id", "Description", "Completed");

            foreach (var task in Tasks)
            {
                table.AddRow(task.Id, task.Description, task.Completed);
            }

            table.Config = TableConfiguration.Unicode();
            
            Write(table.ToString());
            ReadKey();
        }
    }   
}
