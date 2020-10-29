using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public class Person
        : IPerson
    {
        public Person(
            string name, 
            IPersonFilmsConnection filmConnection)
        {
            Name = name;
            FilmConnection = filmConnection;
        }

        public string Name { get; }

        public IPersonFilmsConnection FilmConnection { get; }
    }
}
