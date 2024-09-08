﻿using Core.Serializer;
using BlubLib.Serialization;
using Sigil;
using Sigil.NonGeneric;

namespace Core.Serializer
{
    public class StringSerializer : ISerializerCompiler
    {
        private readonly int _size;
        public StringSerializer(int Size)
        {
            _size = Size;
        }

        public bool CanHandle(Type type)
        {
            if (type == typeof(string))
                return true;
            return false;
        }

        public void EmitDeserialize(Emit emiter, Local value)
        {
            emiter.LoadArgument(1);
            emiter.LoadConstant(_size);
            emiter.Call(typeof(Extensions).GetMethod(nameof(Extensions.ReadString)));
            emiter.StoreLocal(value);
        }

        public void EmitSerialize(Emit emiter, Local value)
        {
            emiter.LoadArgument(1);
            emiter.LoadLocal(value);
            emiter.LoadConstant(_size);
            emiter.Call(typeof(Extensions).GetMethod(nameof(Extensions.WriteString),
                new[] { typeof(BinaryWriter), typeof(string), typeof(int) }));
        }
    }
}
