using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ConcreteSubject
{
    public class Sukhpinder : ICelebrityInstagram
    {
        private readonly List<IFollower> _posts = new List<IFollower>();
        private string _post;
        public string FullName => "Sukhpinder Singh";

        public string Post {
            get { return _post; }
            set
            {
                Notify(value);
            }
        }

        public void AddFollower(IFollower follower)
        {
            _posts.Add(follower);
        }

        public void Notify(string post)
        {
            _post = post;
            foreach (var item in _posts)
            {
                item.Update(this);
            }
        }

        public void RemoveFollower(IFollower follower)
        {
            _posts.Remove(follower);
        }
    }
}
