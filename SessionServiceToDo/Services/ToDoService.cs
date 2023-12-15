using SessionServiceToDo.Models;

namespace SessionServiceToDo.Services
{
    public class ToDoService
    {
        private const string KEY = "234TGDB746";
        private readonly SessionService<List<ToDo>> _sessionService;
        private List<ToDo> _toDoList;
        public ToDoService(SessionService<List<ToDo>> sessionService)
        {
            _sessionService = sessionService;
            _toDoList = _sessionService.GetSession(KEY) ?? new List<ToDo>();
        }

        public IEnumerable<ToDo> GetAll()
        {
            return _toDoList.AsEnumerable();
        }

        public void AddToDo(string name)
        {
            _toDoList.Add(new ToDo { Id = Guid.NewGuid(), Name = name });
            _sessionService.SaveSession(KEY, _toDoList);
        }
    }
}
