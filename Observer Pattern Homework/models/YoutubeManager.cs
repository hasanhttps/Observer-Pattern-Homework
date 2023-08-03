using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern_Homework.models;

class YoutubeManager {

    private readonly List<Observer> _observers = new();

    public void NewVideo() {
        Notify("New video uploaded!");
    }


    public void Attach(Observer observer)
        => _observers.Add(observer);


    public void Detach(Observer observer)
        => _observers.Remove(observer);


    private void Notify(string message) {
        foreach (var observer in _observers)
            observer.Update(message);
    }

}
