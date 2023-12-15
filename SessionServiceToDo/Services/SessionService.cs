using SessionServiceToDo.Helper;

namespace SessionServiceToDo.Services
{
    public class SessionService<T>
    {
        private readonly ISession _session;
        public SessionService(IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext.Session;
        }

        public void SaveSession(string key, T value)
        {
            _session.SetData(key, value);
        }

        public T GetSession(string key)
        {
            T result = _session.GetData<T>(key);
            return result;
        }
    }
}
