/*
 * https://gist.github.com/ant-fx/989dd86a1ace38a9ac58
 * 
 * Edited Worse Looking version than that ^^
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;

namespace antfx
{
    public class LogFileMonitorLineEventArgs : EventArgs
    {
        public string Line { get; set; }
    }

    public class LogFileMonitor
    {
        public EventHandler<LogFileMonitorLineEventArgs> OnLine;
        string _path = String.Empty;
        string _delimiter = String.Empty;
        Timer _t = null;
        string _buffer = String.Empty;
        long _currentSize = 0;
        bool _isCheckingLog = false;

        protected bool StartCheckingLog()
        {
            lock (_t)
            {
                if (_isCheckingLog)
                    return true;

                _isCheckingLog = true;
                return false;
            }
        }

        protected void DoneCheckingLog()
        {
            lock (_t)
                _isCheckingLog = false;
        }

        public LogFileMonitor(string path, string delimiter = "\n")
        {
            _path = path;
            _delimiter = delimiter;
        }

        public void Start()
        {
            _currentSize = new FileInfo(_path).Length;
            _t = new Timer();
            _t.Elapsed += CheckLog;
            _t.AutoReset = true;
            _t.Start();
        }

        private void CheckLog(object s, ElapsedEventArgs e)
        {
            if (StartCheckingLog())
            {
                try
                {
                    var newSize = new FileInfo(_path).Length;
                    if (_currentSize >= newSize)
                        return;
                    _currentSize = newSize;
                    OnLine(this, new LogFileMonitorLineEventArgs { Line = OnLine.ToString() });

                }
                catch (Exception)
                {
                }
                DoneCheckingLog();
            }
        }

        public void Stop()
        {
            if (_t == null)
                return;

            _t.Stop();
        }
    }
}