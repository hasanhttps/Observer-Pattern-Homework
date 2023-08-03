using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern_Homework.models;

abstract class Observer {
    public abstract void Update(string message);
}