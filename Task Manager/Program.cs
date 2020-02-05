using System;
using System.Collections.Generic;


namespace Task_Manager
{
    class Program {
        static void Main() {
            var taskMan = new TaskManager();
            taskMan.Run(); } }

    class TaskManager {
        internal readonly List<Task> TaskList = new List<Task>();

        internal void Run() {
            CreateTask();
            DisplayTasks(); }

        void CreateTask() {
            Console.WriteLine("Enter names of tasks you wish to create. Type \"Done\" to exit: ");
            string userInput = Console.ReadLine();
            while (userInput != "Done") {
                TaskList.Add(new Task(userInput));
                userInput = Console.ReadLine(); } }

        internal void DisplayTasks() {
            int length = TaskList.Count;
            foreach (Task task in TaskList) {
                Console.Write(task.Name);
                if (0 < --length) {
                    Console.Write(", "); } } } }
    class Task {
        internal readonly string Name;
        public Task(string nameArg) {
            Name = nameArg; } }
}