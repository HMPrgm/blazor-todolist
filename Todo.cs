namespace ToDoList
{
    public class Todo
    {
        public string Name { get; init; }
        public bool completed { get; set; }

        public Todo(string name)
        {
            this.Name = name;
            completed = false;
        }

        public bool ToggleCompleted()
        {
            completed = !completed;
            return completed;
        }
    }
}
