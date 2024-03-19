
using ContosoPizza.Pages;

namespace ContosoPizza.Services
{
  public class MessageStoreService
  {
    private readonly List<string> _messages = new List<string>();
    public void AddMessage(string message)
    {
        _messages.Add(message);
    }

    public IList<string> GetMessages()
    {
      if(_messages != null)
      {
        return _messages.ToList();
      }
      return new List<string>();
    }
    // Call this method to clear the messages, if necessary
    public void ClearMessages()
    {
        _messages.Clear();
    }
  }
}
