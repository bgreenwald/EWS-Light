using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EWSLight.Web.Models
{
    public class IndicatorModel
    {
        public string Icon { get; set; }
        public string HeaderText { get; set; }
        public string Value { get; set; }
        public MoreInfoModel MoreInfo { get; set; }
        public StatusType Status { get; set; }
    }

    public class MoreInfoModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}