using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public class GetFoo
        : IGetFoo
    {
        public GetFoo(
            IPerson person)
        {
            Person = person;
        }

        public IPerson Person { get; }
    }
}
