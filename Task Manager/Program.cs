using System;
using System.Collections.Generic;


namespace Task_Manager
{
    class Program {
        static void Main(string[] args) {
            var taskMan = new TaskManager();
            taskMan.Run(); } }

    class TaskManager {
        List<Task> taskList = new List<Task>();
        private class Task {
            internal string name;
            public Task(string nameArg) {
                name = nameArg; } }

        internal void Run() {
            CreateTask();
            DisplayTasks(); }

        internal void CreateTask() {
            Console.WriteLine("Enter names of tasks you wish to create. Type \"Done\" to exit: ");
            string userInput = Console.ReadLine();
            while (userInput != "Done") {
                taskList.Add(new Task(userInput));
                userInput = Console.ReadLine(); } }

        internal void DisplayTasks() {
            int length = taskList.Count;
            foreach (Task task in taskList) {
                Console.Write(task.name);
                if (0 < --length) {
                    Console.Write(", "); } } } }
}