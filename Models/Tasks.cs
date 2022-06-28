namespace API.Controllers
{
    public class Tasks
    {
        public Tasks(int id, string name, DateTime date,string description)
        {
            Id = id;
            Name = name;
            Date = date;
            Description = description;
        } 
        
            
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

    }

}