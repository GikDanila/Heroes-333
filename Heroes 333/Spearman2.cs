namespace Heroes3
{
    internal class Spearman2
    {
        public Spearman2()
        { }
        private int attack = 4;
        private int defends = 4;
        private int damage = 3;
        private int health = 10;
        private int speed = 5;



        /// <summary>
        /// Атаковать
        /// </summary>
        /// <returns>Сила атаки</returns>
        public int Storming()
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random((int)(DateTime.Now.Ticks));
            //Random rnd = new Random();

            //Получить случайное число (в диапазоне от 1 до 3)
            int value = rnd.Next(1, 3);

            return value;
        }
        public void LossOfHealth(int damage)
        {
            health = health - damage;
        }
        public bool IsDead()
        {
            bool isDead;
            if (health > 0)
            {
                isDead = false;
            }
            else
            {
                isDead = true;
            }
            return isDead;
        }
    }
}
        
    
