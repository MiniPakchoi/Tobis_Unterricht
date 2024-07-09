namespace Aufgabenverwaltungssystem
{
    public class Task
    {
        // Eigenschaften kommen hier hin:
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        // Konstruktor soll hier implementiert werden:
        public Task(string title, string description, DateTime dueDate)
        { 
            Title = title;
            Description = description;
            IsCompleted = false;
            DueDate = DateTime.Now;
        }

        // Beschreibung der Aufgabe
        public string GetTaskInfo()
        {
            return $"Title: \"{Title}\", Beschreibung: {Description}, Fällig bis: {DueDate}, Erledigt: {IsCompleted}";
        }

        // Markierung der Aufgabe als erledigt
        public void CompleteTask()
        {

        }

        // Verlängerung des Fälligkeitsdatums
        public void ExtendDueDate(DateTime newDueDate)
        {

        }
    }
}
