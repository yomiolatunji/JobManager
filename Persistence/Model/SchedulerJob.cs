using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobManager.Persistence.Model
{
    public class SchedulerJob
    {
        public string Comments { get; set; }
        public string AllowRunsInRestrictedMode { get; set; }
        public string DeferredDrop { get; set; }
        public int? InstanceId { get; set; }
        public string CredentialName { get; set; }
        public string CredentialOwner { get; set; }
        public string Destination { get; set; }
        public string DestinationOwner { get; set; }
        public int? NumberOfDestinations { get; set; }
        public string Source { get; set; }
        public string NlsEnv { get; set; }
        public int? JobWeight { get; set; }
        public string System { get; set; }
        public string RaiseEvents { get; set; }
        public string InstanceStickiness { get; set; }
        public string StopOnWindowClose { get; set; }
        public string LoggingLevel { get; set; }
        public string MaxRunDuration { get; set; }
        public string ScheduleLimit { get; set; }
        public DateTime? NextRunDate { get; set; }
        public string LastRunDuration { get; set; }
        public DateTime? LastStartDate { get; set; }
        public int? RetryCount { get; set; }
        public int? MaxFailures { get; set; }
        public int? FailureCount { get; set; }
        public int? MaxRuns { get; set; }
        public int? RunCount { get; set; }
        public int? JobPriority { get; set; }
        public string State { get; set; }
        public string Restartable { get; set; }
        public string AutoDrop { get; set; }
        public string Enabled { get; set; }
        public string JobClass { get; set; }
        public DateTime? EndDate { get; set; }
        public string FileWatcherName { get; set; }
        public string FileWatcherOwner { get; set; }
        public string EventRule { get; set; }
        public string EventCondition { get; set; }
        public string EventQueueAgent { get; set; }
        public string EventQueueName { get; set; }
        public string EventQueueOwner { get; set; }
        public string RepeatInterval { get; set; }
        public DateTime? StartDate { get; set; }
        public string ScheduleType { get; set; }
        public string ScheduleName { get; set; }
        public string ScheduleOwner { get; set; }
        public int? NumberOfArguments { get; set; }
        public string JobAction { get; set; }
        public string JobType { get; set; }
        public string ProgramName { get; set; }
        public string ProgramOwner { get; set; }
        public string GlobalUid { get; set; }
        public string ClientId { get; set; }
        public string JobCreator { get; set; }
        public string JobStyle { get; set; }
        public string JobSubname { get; set; }
        public string JobName { get; set; }
        public string Owner { get; set; }
        public int? Flags { get; set; }
    }
}
