using System;

namespace TravelBox.Common
{
    public interface ICountdownCapable : IDisposable
    {
        event Action OnCountdownComplete;
        event Action<TimeSpan> OnCountdownTick;

        void RunCountdown(TimeSpan length);
        void ToggleCountdownPause(out bool currentState);
        void StopCountdown();
        TimeSpan GetRunningLength();
    }
}
