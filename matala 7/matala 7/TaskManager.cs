using System;
using System.Collections.Generic;



namespace matala_7
{
    public class TaskManager
    {
        private Dictionary<int, Task> tasks;
        private Stack<Task> undoHistory;

        public TaskManager()
        {
            tasks = new Dictionary<int, Task>();
            undoHistory = new Stack<Task>();

        }
        public void AddTask(Task task)
        {
            tasks[task.TaskID] = task;
            Console.WriteLine($"Task numbre:{task.TaskID} added ");

        }
        public Task GetTask(int taskID)
        {
            if (tasks.ContainsKey(taskID))
            {
                return tasks[taskID];
            }
            else
            {
                Console.WriteLine($"Task {taskID} not found");
                return null;
            }
        }
        public void RemoveTask(int taskID)
        {
            if (tasks.ContainsKey(taskID))
            {
                Task removed = tasks[taskID];
                tasks.Remove(taskID);
                undoHistory.Push(removed);

                Console.WriteLine($"Task numbre:{taskID} removed ");
            }
            else
            {
                Console.WriteLine($"Task {taskID} not found");
            }

        }
        public void UndoRemove()
        {
            if (undoHistory.Count > 0)
            {
                Task restored = undoHistory.Pop();
                tasks[restored.TaskID] = restored;
                Console.WriteLine($"Task numbre: {restored.TaskID} restored.");
            }
            else
            {
                Console.WriteLine("Task not found");
            }
        }
        public void PrintAllSorted()
        {
            if (tasks == null)
            {
                Console.WriteLine("There are no tasks in the system");
            }
            List<Task> taskList = new List<Task>(tasks.Values);
            Task[] taskArray = taskList.ToArray();
            Array.Sort(taskArray);

            Console.WriteLine("Task by order of priority");

            foreach (Task t in taskArray)
            {
                Console.WriteLine(t.ToString());
            }
            
        }

    }
}