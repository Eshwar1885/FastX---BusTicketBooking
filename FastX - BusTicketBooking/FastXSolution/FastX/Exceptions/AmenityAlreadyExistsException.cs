﻿using System.Runtime.Serialization;

namespace FastX.Exceptions
{
    [Serializable]
    public class AmenityAlreadyExistsException : Exception
    {
        string message;
        public AmenityAlreadyExistsException()
        {
            message = "Amenity already exists for this bus";
        }
        public override string Message => message;


    }
}