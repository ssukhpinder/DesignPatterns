using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Subject
{
    public interface ICelebrityInstagram
    {
        string FullName { get; }
        string Post { get; set; }
        void Notify(string post);
        void AddFollower(IFollower fan);
        void RemoveFollower(IFollower fan);
    }
}
