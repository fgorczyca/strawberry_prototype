using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public class Queries
        : IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            118,
            121,
            71,
            54,
            109,
            86,
            51,
            112,
            77,
            51,
            76,
            67,
            71,
            99,
            106,
            78,
            56,
            74,
            55,
            69,
            79,
            65,
            61,
            61
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            103,
            101,
            116,
            70,
            111,
            111,
            40,
            36,
            105,
            100,
            58,
            32,
            73,
            68,
            41,
            32,
            123,
            32,
            112,
            101,
            114,
            115,
            111,
            110,
            40,
            105,
            100,
            58,
            32,
            36,
            105,
            100,
            41,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            97,
            109,
            101,
            32,
            102,
            105,
            108,
            109,
            67,
            111,
            110,
            110,
            101,
            99,
            116,
            105,
            111,
            110,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            102,
            105,
            108,
            109,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            116,
            105,
            116,
            108,
            101,
            32,
            125,
            32,
            125,
            32,
            125,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Queries Default { get; } = new Queries();

        public override string ToString() => 
            @"query getFoo($id: ID) {
              person(id: $id) {
                name
                filmConnection {
                  films {
                    title
                  }
                }
              }
            }";
    }
}
