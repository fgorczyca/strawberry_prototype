using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public class PersonFilmsConnection
        : IPersonFilmsConnection
    {
        public PersonFilmsConnection(
            IReadOnlyList<IFilm> films)
        {
            Films = films;
        }

        public IReadOnlyList<IFilm> Films { get; }
    }
}
