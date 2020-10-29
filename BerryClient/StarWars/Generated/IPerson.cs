using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public interface IPerson
    {
        string Name { get; }

        IPersonFilmsConnection FilmConnection { get; }
    }
}
