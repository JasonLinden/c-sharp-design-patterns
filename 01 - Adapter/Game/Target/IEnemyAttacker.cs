namespace _01___Adapter.Game.Target
{
    public interface IEnemyAttacker
    {
        void FireWeapon();
        void AssignDriver(string driverName);
        void DriveForward();
    }
}
