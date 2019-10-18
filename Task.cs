using System;

class Task
{
    string name;
    int interval;


    public int getInterval()
    {
        return interval;
    }
    public Task(string name, int interval)
    {
        this.name = name;
        this.interval = interval;
    }
}