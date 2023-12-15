using System.Text.Json;

namespace SessionServiceToDo.Helper
{
    public static class SessionExtension
    {
        public static void SetData<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize<T>(value));
        }
        public static T GetData<T>(this ISession session, string key)
        {
            /*session.
            session.GetString(key)
            return value == null ? default : JsonSerializer.Deserialize<T>((string)value)
            */
            //return session.Keys.FirstOrDefault(key) == default ? default : JsonSerializer.Deserialize<T>(session.GetString(key))
            /*var ses = session.GetString(key)
            return ses == null ? default : JsonSerializer.Deserialize<T>(ses)*/

            T result = default(T); // pro int = 0; pro string null; pro class = null
            var ses = session.GetString(key); // pokud je session prázdná, vrací null
            if (ses != null) result = JsonSerializer.Deserialize<T>(ses);
            if (typeof(T).IsClass && result == null) result = (T)Activator.CreateInstance(typeof(T));
            return result;
        }
    }
}
