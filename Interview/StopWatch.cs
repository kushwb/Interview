using System;
using System.Net.Http.Headers;

namespace Interview
{
    public class StopWatch
    {
        TimeSpan _timer = new TimeSpan();
        DateTime _startTime;
        DateTime _stopTime;
        bool isTimerRunning = false;
        public void Start()
        {
            if (!isTimerRunning)
            {
                _startTime = DateTime.Now;
                isTimerRunning = true;
            }
            else
                Console.WriteLine("Timer already running.");
        }

        public void Stop()
        {
            _stopTime = DateTime.Now;
            _timer = _stopTime - _startTime;
            isTimerRunning = false;
            Console.WriteLine(_timer.Duration().ToString(@"hh\:mm\:ss"));
        }
    }
}