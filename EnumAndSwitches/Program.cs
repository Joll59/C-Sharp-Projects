using System;

namespace EnumAndSwitches
{
    class Program
    {
        static void Main(string[] args)
        {
            Todo myTodo = new Todo
            {
                Task = "Finish Learning C# and C++ Language",
                Status = Status.Incomplete
            };
        }
    }

    class Todo
    {
        public string Task { get; set; }
        public Status Status { get; set; }
    }
    enum Status
    {
        DueSoon,
        Current,
        Done,
        Completed,
        Incomplete
    }
}
