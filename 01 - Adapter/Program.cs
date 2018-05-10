using _01___Adapter.Game.Adaptee;
using _01___Adapter.Game.Adapter;
using _01___Adapter.Game.Target;
using _01___Adapter.PhoneCharger.Adapter;
using _01___Adapter.PhoneCharger.Target;
using _01___Adapter.Speed.Adapter;
using _01___Adapter.Speed.Target;

namespace _01___Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var samsungS8 = new SamsungS8();
            var andoidCharger = new AndoidCharger();
            andoidCharger.Charge(samsungS8);

            var iphoneX = new IPhoneX();
            var iphoneCharger = new IPhoneCharger();
            iphoneCharger.Charge(iphoneX);

            // Adapter
            var adapter = new AndroidToIphoneAdapter(samsungS8);
            iphoneCharger.Charge(adapter);

            var tank = new EnemyTank();
            Attack(tank);

            var enemyRobot = new EnemyRobot();
            var enemyRobotAdapter = new EnemyRobotAdapter(enemyRobot);
            Attack(enemyRobotAdapter);

            
            // Not the best...
            ILocomotion car = new FordFigo();
            var speed = car.Speed();

            var speedAdpater = new SpeedAdapter(car);
            speedAdpater.Speed();
        }

        static void Attack(IEnemyAttacker attacker)
        {
            attacker.FireWeapon();
            attacker.AssignDriver("Shane");
            attacker.DriveForward();
        }
    }
}
