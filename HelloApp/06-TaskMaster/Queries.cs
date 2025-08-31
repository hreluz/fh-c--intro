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

        public List<Task> MarkAsCompleted()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("----- Mark task as completed -----");
                WriteLine("Enter task id: ");
                var id = ReadLine()!;
                Task task = Tasks.Find(t => t.Id == id)!;

                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"Task not found with the id {id} ");
                    ResetColor();
                    return Tasks;
                }

                task.Completed = true;
                task.ModifiedAt = DateTime.Now;
                ForegroundColor = ConsoleColor.Green;

                WriteLine("Task mark as completed succesfully");
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
