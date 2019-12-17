using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace QualitasDigitalSeleniumCSharp.Extensions
{
    /// <summary>
    /// The Event Logger for the local machine
    /// </summary>
    public static class EventLogger
    {
        /// <summary>
        /// Gets a list of event log entries for the source specified
        /// </summary>
        /// <param name="eventType">The event log source</param>
        /// <param name="startTime">The test start time</param>
        /// <param name="endTime">The test end time</param>
        /// <returns></returns>
        public static List<EventLogEntry> GetEventLog(EventType eventType, DateTime startTime, DateTime endTime)
        {
            switch (eventType)
            {
                case EventType.Critical:
                    return GetEvents("Critical", startTime, endTime);
                case EventType.Error:
                    return GetEvents("Error", startTime, endTime);
                case EventType.Warning:
                    return GetEvents("Warning", startTime, endTime);
                case EventType.Information:
                    return GetEvents("Information", startTime, endTime);
                default:
                    throw new ArgumentOutOfRangeException(nameof(eventType), eventType, null);
            }
        }

        private static List<EventLogEntry> GetEvents(string source, DateTime startTime, DateTime endTime)
        {
            EventLog eventLog = new EventLog { Log = source };

            List<EventLogEntry> eventLogs = new List<EventLogEntry>();

            foreach (EventLogEntry eventLogEntry in eventLog.Entries)
            {
                if (eventLogEntry.TimeGenerated >= startTime && eventLogEntry.TimeGenerated <= endTime)
                {
                    eventLogs.Add(eventLogEntry);
                }
            }

            return eventLogs;
        }
    }
}
