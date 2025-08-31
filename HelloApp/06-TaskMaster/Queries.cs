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

        public List<Task> AddTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("----- Add task -----");
                WriteLine("Add task's description: ");
                var description = ReadLine()!;
                Task newTask = new Task(Utils.GenerateId(), description);
                Tasks.Add(newTask);
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Task added successfully");
                ResetColor();
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
                return Tasks;
            }
        }
    }   
}
