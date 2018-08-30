using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;

namespace VDubovsky.SystemMonitoring.FolderMonitoring
{
    // 1. Получить список файлов и папок в указанной папке
    // 2. Сохранение полученного списка
    // 3. Сравнение двух списков
    
    public class FolderMonitor
    {
        private readonly string _path;
        private readonly int _interval;
        private List<string> _lastFolderState;
        public bool IsActive { get; set; } = true;

        public FolderMonitor(string path, int interval)
        {
            if (path == null) throw new ArgumentNullException();
            if (!Directory.Exists(path)) throw new DirectoryNotFoundException();
            _path = path;
            _interval = interval;
            _lastFolderState = GetFolderState();
        }

        public void Monitoring()
        {
            Console.WriteLine($@"Monitoring of directory ""{_path}"" started." +
                $"\nMonitoring will be held with {_interval} second(s) interval.\n");
            while(true)
            {
                Thread.Sleep(_interval * 1000);
                if (IsActive)
                {
                    Console.WriteLine($"\nChanges noticed on {DateTime.Now}:");
                    TrackChanges();
                }
            }
            // ReSharper disable once FunctionNeverReturns
        }

        public void TrackChanges()
        {
            var currentFolderState = GetFolderState();
            var delChanges = DeletionCheck(currentFolderState);
            var addChanges = AdditionCheck(currentFolderState);
            if (delChanges.Count == 0 && addChanges.Count == 0)
                Console.WriteLine("No changes.");
            _lastFolderState = currentFolderState;
        }

        public List<string> GetFolderState()
        {
            var folderContent = Directory.EnumerateDirectories(_path)
                .ToList();
            folderContent.AddRange(Directory.EnumerateFiles(_path));
            return folderContent;
        }

        public List<string> CompareDirectoryStates(List<string> state1, List<string> state2)
        {
            var statesDifferences = new List<string>();
            foreach (var diff in state1)
                if (!state2.Contains(diff))
                    statesDifferences.Add(diff);
            return statesDifferences;
        }

        public List<string> DeletionCheck(List<string> currentState)
        {
            var changes = CompareDirectoryStates(_lastFolderState, currentState);
            foreach (var ch in changes)
                Console.WriteLine($"Directory {ch} was deleted.");
            return changes;
        }

        public List<string> AdditionCheck(List<string> currentState)
        {
            var changes = CompareDirectoryStates(currentState, _lastFolderState);
            foreach (var ch in changes)
                Console.WriteLine($"Directory {ch} was added.");
            return changes;
        }
    }
}
