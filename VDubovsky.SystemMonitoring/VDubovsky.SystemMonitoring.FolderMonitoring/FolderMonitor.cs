using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace VDubovsky.SystemMonitoring.FolderMonitoring
{
    // 1. Получить список файлов и папок в указанной папке
    // 2. Сохранение полученного списка
    // 3. Сравнение двух списков

        //Хранить слепок состояния в файле
    public class FolderMonitor
    {
        private string _path;
        private int _interval;
        private List<string> LastFolderState = new List<string>();

        public bool IsActive { get; set; }

        public FolderMonitor(string path, int interval)
        {
            if (path == null) throw new ArgumentNullException();
            if (!Directory.Exists(path)) throw new DirectoryNotFoundException();
            _path = path;
            _interval = interval;
            LastFolderState = GetFolderState();
        }

        public void Monitoring()
        {
            Console.WriteLine($@"Monitoring of directory ""{_path}"" started." +
                $"\nMonitoring will be held with {_interval} second(s) interval.\n");
            while(true)
            {
                Thread.Sleep(_interval * 1000);
                Console.WriteLine($"\nChanges noticed on {DateTime.Now}:");
                TrackChanges();
            }
        }

        public void TrackChanges()
        {
            List<string> delChanges = new List<string>();
            List<string> addChanges = new List<string>();
            var CurrentFolderState = GetFolderState();
            delChanges = DeletionCheck(CurrentFolderState);
            addChanges = AdditionCheck(CurrentFolderState);
            if (delChanges.Count == 0 && addChanges.Count == 0)
                Console.WriteLine("No changes.");
            LastFolderState = CurrentFolderState;
        }

        public List<string> GetFolderState()
        {
            return Directory.EnumerateDirectories(_path)
                .ToList();
        }

        public List<string> CompareDirectoryStates(List<string> state1, List<string> state2)
        {
            List<string> StatesDifferences = new List<string>();
            foreach (var diff in state1)
                if (!state2.Contains(diff))
                    StatesDifferences.Add(diff);
            return StatesDifferences;
        }

        public List<string> DeletionCheck(List<string> currentState)
        {
            var changes = CompareDirectoryStates(LastFolderState, currentState);
            foreach (var ch in changes)
                Console.WriteLine($"Directory {ch} was deleted.");
            return changes;
        }

        public List<string> AdditionCheck(List<string> currentState)
        {
            var changes = CompareDirectoryStates(currentState, LastFolderState);
            foreach (var ch in changes)
                Console.WriteLine($"Directory {ch} was added.");
            return changes;
        }
    }
}
