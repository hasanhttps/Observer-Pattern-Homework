using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern_Homework.models;

class PublisherObserver : Observer {
    public override void Update(string message) {
        Console.WriteLine($"Message to Publisher: {message}");
    }
}
