using System;
using System.Collections.Generic;

namespace OOP_Module1_Task1_v2
{
    class Storage
    {
        public Dictionary<Type, Resource> resources = new Dictionary<Type, Resource>();

        public Storage()
        {
            Gold gold = GetResource<Gold>();
            Wood wood = GetResource<Wood>();
        }

        public T GetResource<T>()
            where T : Resource
        {
            return (T)resources[typeof(T)];
        }
    }
}
