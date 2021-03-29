using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinDemo.Services
{
    interface ITimerService
    {
        bool IsRunning { get;}
        
        void Start();
        void Stop();
        void Reset();

        void SetupDuration(TimeSpan duration);
        void SetupCallbacks(Action<TimeSpan> tickCallback, Action completedCallback);

    }
}
