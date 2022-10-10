﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace aspSample.Data
{
    public class Customer
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
