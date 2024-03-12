using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ConcreteObserver
{
    public class Follower : IFollower
    {
        public void Update(ICelebrityInstagram celebrityInstagram)
        {
            Console.WriteLine($"Follower notified. Post of {celebrityInstagram.FullName}: " +
                $"{celebrityInstagram.Post}");
        }
    }
}
