using _01___Adapter.Game.Adaptee;
using _01___Adapter.Game.Target;

namespace _01___Adapter.Game.Adapter
{
    class EnemyRobotAdapter : IEnemyAttacker
    {
        EnemyRobot _enemyRobot;

        public EnemyRobotAdapter(EnemyRobot enemyRobot)
        {
            _enemyRobot = enemyRobot;
        }

        public void AssignDriver(string driverName)
        {
            _enemyRobot.CrushDriver(driverName);
        }

        public void DriveForward()
        {
            _enemyRobot.WalkForward();
        }

        public void FireWeapon()
        {
            _enemyRobot.SmashWithHands();
        }
    }
}
