
namespace server.Models;

public class UserMessage
{
    public string Name { get; set; }
    
    public string Message { get; set; }
    
    public bool CurrentUser { get; set; }
    
    public DateTime SentTime { get; set; }
}