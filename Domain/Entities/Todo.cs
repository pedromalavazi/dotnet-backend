namespace Domain.Entities;

public class Todo : Entity
{
    public Todo(string description, DateTime dueDate)
    {
        Description = description;
        DueDate = dueDate;
        Done = false;
    }

    public string Description { get; set; }
    public bool Done { get; set; }
    public DateTime DueDate { get; set; }

    void MarkAsDone()
    {
        Done = true;
    }

    void MarkAsNotDone()
    {
        Done = false;
    }

    void UpdateDescription(string newDescription)
    {
        Description = newDescription;
    }
}