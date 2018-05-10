namespace _01___Abstract_Factory.GameExample.Abstract_Product
{
    public abstract class Player
    {
        public int health;
        public int attPow;

        public abstract void Attack();
        public abstract void Move();
    }
}
