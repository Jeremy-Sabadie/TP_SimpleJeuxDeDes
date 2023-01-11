namespace SimpleJeuxDeDes
{
    internal class De
    {
        private int Value;
        /// <summary>
        /// Fonction GetValeue
        /// </summary>
        public int GetValue()
        {
            return this.Value;
        }

        public int Lancer()
        {
            Random rand = new Random();
            Value = rand.Next(0, 7);
            return Value;

        }
    }
}
