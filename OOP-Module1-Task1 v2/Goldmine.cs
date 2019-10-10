using System;

namespace OOP_Module1_Task1_v2
{
    class Goldmine : Building
    {
        public Goldmine(string buildingName)
        {
            name = buildingName;
            Random random = new Random();
            coordinates = new Coordinates(random.Next(-100, 100), random.Next(-100, 100));
        }
    }
}
