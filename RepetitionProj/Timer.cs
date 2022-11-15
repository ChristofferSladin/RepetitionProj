class Timer
{
    public int TimeBetweenAction(int second)
    {
        var sec = new System.Timers.Timer();
        sec.Interval = second * 1000;
        var interval = second * 1000;

        return interval;
    }

}
