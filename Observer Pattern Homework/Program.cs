using System;
namespace Observer_Pattern_Homework.models;

internal class Program {
    static void Main(string[] args) {
        YoutubeManager youtubeManager = new ();

        var subscriber = new SubscriberObserver();
        var publisher = new PublisherObserver();

        youtubeManager.Attach(subscriber);
        youtubeManager.Attach(publisher);

        youtubeManager.NewVideo();

        youtubeManager.Detach(publisher);
        Console.WriteLine();
        youtubeManager.NewVideo();
    }
}