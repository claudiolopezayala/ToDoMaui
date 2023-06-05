using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMPW_412_3P_PR02
{
    public sealed class Tasks
    {
        public EventHandler tasksUpdated;

        private List<Task> tasks = new List<Task>() { new Task("deafult","defaultdescription")};
        private Tasks() { }
        private readonly static Tasks instance = new Tasks();

        public static Tasks taskInstance { get { return instance; } }

        public void addTask(Task taskToAdd)
        {
            tasks.Add(taskToAdd);
            tasksUpdated?.Invoke(this, EventArgs.Empty);
        }

        public List<Task> getClonedList()
        {
            List<Task> tasksToReturn = new List<Task>(this.tasks.Count);
            this.tasks.ForEach((task) =>
            {
                tasksToReturn.Add((Task)task.Clone());
            });
            return tasksToReturn;
        }

        public void removeTaskByIndex(int index)
        {
            tasks.RemoveAt(index);
        }

        public void removeTask(Task task)
        {
            foreach (Task t in tasks)
            {
                if (t.description.Equals(task.description) && t.title.Equals(task.title))
                {
                    tasks.Remove(t);
                    tasksUpdated?.Invoke(this, EventArgs.Empty);
                    return;
                }
            }
        }
    }
}
