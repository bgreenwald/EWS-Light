using System.Collections;
using System.Collections.Generic;

namespace EWSLight.Web.Models
{
    public class StudentModel
    {
        public string FullName { get; set; }
        public int StudentId { get; set; }
        public string GradeLevel { get; set; }
        public string ThumbnailUrl { get; set; }
        public StatusModel Status { get; set; }
        public IEnumerable<IndicatorModel> Indicators { get; set; }
    }

    public enum StatusType
    {
        Ok,
        Warning
    }

    public class StatusModel
    {
        public StatusType OverallStatus { get; set; }
        public string StatusHeader { get; set; }
        public string StatusMessage { get; set; }
    }
}