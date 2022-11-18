namespace AnimalWithPatterns
{
    static class AnimalFactory
    {
        /// <summary>
        /// Получить животное
        /// </summary>
        /// <param name="Type">Тип животного</param>
        /// <param name="Name">Название животного</param>
        /// <returns></returns>
        public static Animal GetAnimal(string Type, string Name)
        {
            switch (Type)
            {
                case "Mammals": return new Mammals(Name);
                case "Amphibias": return new Amphibias(Name);
                case "Birds": return new Birds(Name);
                default: return new NullAnimal(Name);
            }
        }
    }
}
