namespace API.Controllers
{
    public static class TarefaRepository
    {
        private static readonly List<Tasks> _tasks = new List<Tasks>();

        public static void Add(Tasks tasks)
        {
            _tasks.Add(tasks);
        }

        public static List<Tasks> GetAll()
        {
            return _tasks;
        } 

        public static void Remove(Tasks tasks)
        {
            _tasks.Remove(tasks);
        }

        public static Tasks GetById(int id)
        {
            return _tasks.Find(t => t.Id == id);
        }
    }
}
