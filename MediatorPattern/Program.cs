// See https://aka.ms/new-console-template for more information
Chatroom chatroom = new Chatroom();
User Jennifer = new User(Username.Jennifer.ToString());
User Ashley = new User(Username.Ashley.ToString());
User David = new User(Username.David.ToString());
User Scott = new User(Username.Scott.ToString());

chatroom.Register(Jennifer);
chatroom.Register(Ashley);
chatroom.Register(David);
chatroom.Register(Scott);

David.Post(Username.Scott.ToString(), "Hey");
Scott.Post(Username.David.ToString(), "I am good how about you.");
Jennifer.Post(Username.Ashley.ToString(), "Hey ashley... david is back in the group");
Jennifer.Post(Username.David.ToString(), "Where have you been?");
Ashley.Post(Username.David.ToString(), "How come you aren't active here anymore?");

Console.ReadKey();
public enum Username
{
    Ashley,
    David,
    Jennifer,
    Scott
}
public abstract class AChatroom
{
    public abstract void Register(User user);
    public abstract void Post(string fromUser, string toUser, string msg);
}

public class Chatroom : AChatroom
{
    private Dictionary<string, User> _users = new Dictionary<string, User>();
    public override void Post(string fromUser, string toUser, string msg)
    {
        User participant = _users[toUser];

        if (participant != null)
        {
            participant.DM(fromUser, msg);
        }
    }

    public override void Register(User user)
    {
        if (!_users.ContainsValue(user))
        {
            _users[user.Name] = user;
        }

        user.Chatroom = this;
    }
}
public class User
{
    private Chatroom _chatroom;
    private string _name;
    public User(string name) => this._name = name;

    public string Name => _name;

    public Chatroom Chatroom
    {
        set { _chatroom = value; }
        get => _chatroom;
    }
    public void Post(string to, string message) =>
        _chatroom.Post(_name, to, message);

    public virtual void DM(string from, string message) =>
        Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);

}
