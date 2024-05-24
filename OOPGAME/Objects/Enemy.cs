namespace OOPGAME.Objects
{
    internal class Enemy
    {
        private string Name;
        private int Health;
        private int Damage;
        private int ChanceAttack;
        private bool DoAttack;

        public Enemy(string Name, int Health)
        {
            this.Name = Name;
            this.Health = Health;
            Random rand = new Random();
            Damage = rand.Next(5, 11);
            Random random = new Random();
            ChanceAttack = random.Next(1, 101);

        }
        public string GetName()
        {
            return Name;
        }
        public int GetHealth()
        {
            return Health;
        }
        public int GetDamage()
        {
            return Damage;
        }
        public bool GetDoAttack()
        {
            if (ChanceAttack >= 20) { DoAttack = true; }
            else { DoAttack = false; }
            return DoAttack;
        }
        public void TakeDamage(Player player)
        {
            Health -= player.GetDamage();
        }
    }
}
