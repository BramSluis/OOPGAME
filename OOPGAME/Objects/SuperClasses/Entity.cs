namespace OOPGAME.Objects.SuperClasses
{
    internal class Entity
    {
        protected string Name;
        protected int Health;
        protected int Damage;
        public Entity(string Name, int Health)
        {
            this.Name = Name;
            this.Health = Health;
            this.Damage = Damage;

        }
        
        
    }

}
