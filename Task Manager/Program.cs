using System;
using System.Collections.Generic;
using System.IO;


namespace Task_Manager
{
    public class Program {
        public static void Main() {
            var taskMan = new TaskManager();
            taskMan.Run(); } }

    internal class TaskManager {
        private readonly List<Task> _taskList = new List<Task>();

        internal void Run() {
            CreateTasks();
            DisplayTasks(); }

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