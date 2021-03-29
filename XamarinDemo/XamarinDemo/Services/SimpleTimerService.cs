using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace XamarinDemo.Services
{
    public class SimpleTimerService : ITimerService
    {
        private Timer Timer;

        public TimeSpan StartTimeSpan  { get; private set; }
        public TimeSpan CurrentTimeSpan { get; private set; }
        public Action<TimeSpan> TickCallback { get; private set; }
        public Action CompletedCallback { get; private set; }

        public bool IsRunning { get; private set; }

        public void SetupCallbacks(Action<TimeSpan> tickCallback, Action completedCallback)
        {
            TickCallback = tickCallback;
            CompletedCallback = completedCallback;
        }

        public void SetupDuration(TimeSpan duration)
        {
            StartTimeSpan = duration;
            CurrentTimeSpan = duration;
        }

        public void Start()
        {
            Timer = new Timer(Tick, this, 1000, 1000);
            IsRunning = true;
        }
        public void Stop()
        {
            if(Timer != null)
                Timer.Dispose();
            Timer = null;
            IsRunning = false;
        }
        public void Reset()
        {
            CurrentTimeSpan = StartTimeSpan;
        }

        private void Tick(object obj)
        {
            var state = obj as SimpleTimerService;

            if (state.CurrentTimeSpan.TotalSeconds > 0)
            {
                state.CurrentTimeSpan -= TimeSpan.FromSeconds(1);
                if (state.TickCallback != null)
                    state.TickCallback(CurrentTimeSpan);
            }
            
            if(state.CurrentTimeSpan.TotalSeconds <=  0)
                Complete();
            
        }

        private void Complete()
        {
            Stop();
                        
            CurrentTimeSpan = TimeSpan.Zero;
            
            if(CompletedCallback != null) 
                CompletedCallback();

        }
        
    }
}
