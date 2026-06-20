using System;
using System.Collections.Generic;



namespace matala_7
{
    public class Task : IComparable 
    {
        public int TaskID { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public Task(int taskID, string description, int priority)
        {
            TaskID = taskID;
            Description = description;
            Priority = priority;
        }
        public int CompareTo(object obj)
        {
            Task t = (Task)obj;
            if (this.Priority< t.Priority)
            return -1;
            
            if (this.Priority> t.Priority)
            return 1;
            
            return 0;
        }
        public override string ToString ()
        {
            return $"ID: {TaskID}, Description: {Description}, Priority: {Priority}";
        }
    }
}