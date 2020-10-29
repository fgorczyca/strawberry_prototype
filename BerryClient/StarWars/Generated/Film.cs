using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public class Film
        : IFilm
    {
        public Film(
            string title)
        {
            Title = title;
        }

        public string Title { get; }
    }
}
