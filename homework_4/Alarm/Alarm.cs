using System;

namespace Alarm {
    public class AlarmClockEventArgs: EventArgs {
        public int sleepTime;
    }
    public delegate void AlarmClockEventHandler(object sender, AlarmClockEventArgs args);

    public class AlarmClock {
        public event AlarmClockEventHandler Handler;
        public void alarm(int sleepTime) {
            var args = new AlarmClockEventArgs();
            args.sleepTime = sleepTime;
            Handler(this, args);
        }
    }

    public class AlarmClockUser {
        static void Main(string[] args) {
            var alarmClock = new AlarmClock();
            alarmClock.Handler += show;

            int t = int.Parse(Console.ReadLine());
            alarmClock.alarm(t);
        }
        static void show(object sender, AlarmClockEventArgs args) {
            int t = args.sleepTime;
            Console.WriteLine("Alarm clock will alarm in " + t + "ms.");
            System.Threading.Thread.Sleep(t);
            Console.WriteLine("Time is up!");
        }
    }
}
