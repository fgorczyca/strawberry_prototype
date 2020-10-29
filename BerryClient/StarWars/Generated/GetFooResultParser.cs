using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using StrawberryShake;
using StrawberryShake.Http;
using StrawberryShake.Http.Subscriptions;
using StrawberryShake.Transport;

namespace BerryClient
{
    public class GetFooResultParser
        : JsonResultParserBase<IGetFoo>
    {
        private readonly IValueSerializer _stringSerializer;

        public GetFooResultParser(IValueSerializerResolver serializerResolver)
        {
            if (serializerResolver is null)
            {
                throw new ArgumentNullException(nameof(serializerResolver));
            }
            _stringSerializer = serializerResolver.GetValueSerializer("String");
        }

        protected override IGetFoo ParserData(JsonElement data)
        {
            return new GetFoo
            (
                ParseGetFooPerson(data, "person")
            );

        }

        private IPerson ParseGetFooPerson(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return new Person
            (
                DeserializeNullableString(obj, "name"),
                ParseGetFooPersonFilmConnection(obj, "filmConnection")
            );
        }

        private IPersonFilmsConnection ParseGetFooPersonFilmConnection(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return new PersonFilmsConnection
            (
                ParseGetFooPersonFilmConnectionFilms(obj, "films")
            );
        }

        private IReadOnlyList<IFilm> ParseGetFooPersonFilmConnectionFilms(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            int objLength = obj.GetArrayLength();
            var list = new IFilm[objLength];
            for (int objIndex = 0; objIndex < objLength; objIndex++)
            {
                JsonElement element = obj[objIndex];
                list[objIndex] = new Film
                (
                    DeserializeNullableString(element, "title")
                );

            }

            return list;
        }

        private string DeserializeNullableString(JsonElement obj, string fieldName)
        {
            if (!obj.TryGetProperty(fieldName, out JsonElement value))
            {
                return null;
            }

            if (value.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return (string)_stringSerializer.Deserialize(value.GetString());
        }
    }
}
