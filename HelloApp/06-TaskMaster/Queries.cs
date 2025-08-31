using BetterConsoleTables;

namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private List<Task> Tasks = _tasks;

        public static void ShowTasksTable(List<Task> tasks)
        {
            Table table = new Table("Id", "Description", "Completed");

            foreach (var task in tasks)
            {
                table.AddRow(task.Id, task.Description, task.Completed);
            }

            table.Config = TableConfiguration.Unicode();

            Write(table.ToString());
            ReadKey();
        }
        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.DarkBlue;
            ShowTasksTable(Tasks);
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

        public List<Task> EditTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("----- Edit Task -----");
                WriteLine("Enter task id to edit: ");
                var id = ReadLine()!;
                Task task = Tasks.Find(t => t.Id == id)!;

                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"Task not found with the id {id} ");
                    ResetColor();
                    return Tasks;
                }

                Write("Enter the description's task: ");
                task.Description = ReadLine()!;
                task.ModifiedAt = DateTime.Now;
                ForegroundColor = ConsoleColor.Green;

                WriteLine("Task updated succesfully");
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

        public List<Task> RemoveTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("----- Delete Task -----");
                WriteLine("Enter task id to delete: ");
                var id = ReadLine()!;
                Task task = Tasks.Find(t => t.Id == id)!;

                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"Task not found with the id {id} ");
                    ResetColor();
                    return Tasks;
                }

                Tasks.Remove(task);

                WriteLine("Task deleted succesfully");
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

        public void TasksByState()
        {
            Clear();
            try
            {
                ResetColor();
                WriteLine("---- Tasks by  status ----");
                WriteLine("1.Completed");
                WriteLine("2.Pending");
                WriteLine("Enter an option: ");
                string taskState = ReadLine()!;
                if (taskState != "1" && taskState != "2")
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Invalid option");
                    ResetColor();
                    return;
                }

                bool completed = taskState == "1";
                List<Task> filteredTask = Tasks.Where(t => t.Completed == completed).ToList();

                if (filteredTask.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("There are not tasks with the selected options");
                    ResetColor();
                    return;
                }


                ForegroundColor = completed ? ConsoleColor.Green : ConsoleColor.Red;
                ShowTasksTable(filteredTask);
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"An error happened when filtering: ",ex.Message);
            }

        }
    }   
}
