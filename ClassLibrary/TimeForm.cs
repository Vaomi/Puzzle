﻿using System;
using System.Windows.Threading;
using System.Windows.Controls;

namespace ClassLibrary
{
    public class TimerForm
    {
        public DispatcherTimer timer;
        public int Second;
        public Label labelName;
        public TimeSpan span;

        public TimerForm(int sec, Label lb)
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            span = TimeSpan.FromSeconds(sec);
            Second = sec;
            labelName = lb;
            lb.Content = span.ToString("mm' : 'ss");
        }

        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
    }
}
