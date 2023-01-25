using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]

public class InvalidPropertyExeption : Exception
{
    public InvalidPropertyExeption() : base() { }

    public InvalidPropertyExeption(string message) :base(message) { }

    public InvalidPropertyExeption(string message, Exception innerException) :base(message, innerException) { }

    protected InvalidPropertyExeption(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info,context) { }
}
