using System;

namespace program1
{
    class Alarm
    {
        private int aHour, aMin;
        public delegate void delegateType();
        public event delegateType AlarmEvent;

        public Alarm(int hour, int min)
        {
            aHour = hour;
            aMin = min;
        }

        public void StartAlarm()
        {
            if (AlarmEvent != null)
            {
                AlarmEvent();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int hour, min;
            Console.WriteLine("----------ALARM----------");
            Console.WriteLine("请设置闹钟（输入两个整数）:");

            hour = int.Parse(Console.ReadLine());
            min = int.Parse(Console.ReadLine());

            void AlartRun()
            {
                Console.WriteLine("现在是" + hour + "时" + min + "分。");
            }

            while (true)
            {
                if(hour==DateTime.Now.Hour && min== DateTime.Now.Minute)
                {
                    Alarm alarm = new Alarm(hour, min);
                    alarm.AlarmEvent += new Alarm.delegateType(AlartRun);
                    alarm.StartAlarm();
                    break;
                }
            }
        }
    }
}
