// See https://aka.ms/new-console-template for more information
using ObserverPattern.ConcreteObserver;
using ObserverPattern.ConcreteSubject;

var sukhpinder = new Sukhpinder();

var firstFan = new Follower();
var secondFan = new Follower();

sukhpinder.AddFollower(firstFan);
sukhpinder.AddFollower(secondFan);

sukhpinder.Post = "I love design patterns.";

Console.Read();
