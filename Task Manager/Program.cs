using System;
using System.Collections.Generic;
using System.IO;


namespace Task_Manager
{
    public class Program {
        public static void Main() {
            var taskMan = new TaskManager();
            taskMan.Run(); } }

    public class TaskManager {
        private readonly List<Task> _taskList;
        public TaskManager() {
            _taskList = new List<Task>(); }

        internal void Run() {
            Console.WriteLine("Welcome to Task Manager. It manages your tasks! Duh.");
            var userInput = "";
            while (userInput != "Done") {
                Console.WriteLine("This is the main menu. Type \"Create\" or \"Display\", or \"Done\" to exit.");
                userInput = Console.ReadLine();
                switch (userInput) {
                    case "Create":
                        CreateTasks();
                        break;
                    case "Display":
                        DisplayTasks();
                        break;
                    case "Done":
                        break;
                    default:
                        Console.WriteLine("Sorry, that's not a valid entry");
                        break; } } }

        private void CreateTasks() {
            Console.WriteLine("Enter names of tasks you wish to create. Type \"Done\" to exit: ");
            var userInput = Console.ReadLine();
            while (userInput != "Done") {
                _taskList.Add(new Task(userInput));
                userInput = Console.ReadLine(); } }

        private void DisplayTasks() {
            var length = _taskList.Count;
            foreach (var task in _taskList) {
                Console.Write(task.Name);
                if (0 < --length) {
                    Console.Write(", "); } } } }
    internal class Task {
        internal readonly string Name;
        public Task(string nameArg) {
            Name = nameArg; } }
}