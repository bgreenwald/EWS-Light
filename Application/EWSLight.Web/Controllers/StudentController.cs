using System.Collections.Generic;
using System.Web.Mvc;
using EWSLight.Web.Models;

namespace EWSLight.Web.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult List()
        {
            var model = new List<StudentModel>
            {
                new StudentModel
                {
                    ThumbnailUrl = "/Content/Images/taraabbott.jpg",
                    FullName = "Tara D Abbott",
                    StudentId = 123,
                    GradeLevel = "7th Grade",
                    Status = new StatusModel
                    {
                        StatusHeader = "Warning!",
                        StatusMessage = "This student is failing (3) indicators.",
                        OverallStatus = StatusType.Warning
                    },
                    Indicators = new List<IndicatorModel>()
                    {
                        new IndicatorModel
                        {
                            Icon = "fa-calendar",
                            HeaderText = "Avg. Daily Attendance",
                            Value = "92%",
                            Status = StatusType.Ok
                        },
                        new IndicatorModel
                        {
                            Icon = "fa-plus",
                            HeaderText = "Course Failure: Math",
                            Value = "Yes",
                            Status = StatusType.Warning
                        },
                        new IndicatorModel
                        {
                            Icon = "fa-child",
                            HeaderText = "Suspensions",
                            Value = "Yes",
                            Status = StatusType.Warning
                        },
                        new IndicatorModel
                        {
                            Icon = "fa-book",
                            HeaderText = "Level 1 Score: ELA",
                            Value = "No",
                            Status = StatusType.Ok,
                            MoreInfo = new MoreInfoModel()
                            {
                                Title = "Level 1 Score: State Standardized Assessment ELA",
                                Description = "A longer description of the assessment will go here"
                            }
                        },
                        new IndicatorModel
                        {
                            Icon = "fa-file-text",
                            HeaderText = "Course Failure: ELA",
                            Value = "No",
                            Status = StatusType.Ok
                        },
                        new IndicatorModel
                        {
                            Icon = "fa-calculator",
                            HeaderText = "Level 1 Score: Math",
                            Value = "Yes",
                            Status = StatusType.Warning,
                            MoreInfo = new MoreInfoModel()
                            {
                                Title = "Level 1 Score: State Standardized Assessment Math",
                                Description = "A longer description of the assessment will go here"
                            }

                        },
                    }
                }
            };
            return View(model);
        }

        public ActionResult Get(int id)
        {
            var model = new StudentModel
            {
                ThumbnailUrl = "/Content/Images/taraabbott.jpg",
                FullName = "Tara D Abbott",
                StudentId = id,
                GradeLevel = "3rd Grade",
                Status = new StatusModel
                {
                    StatusHeader = "Warning!",
                    StatusMessage = "This student is failing (3) indicators.",
                    OverallStatus = StatusType.Warning
                },
                Indicators = new List<IndicatorModel>()
                {
                    new IndicatorModel
                    {
                        Icon = "fa-calendar",
                        HeaderText = "Avg. Daily Attendance",
                        Value = "92%",
                        Status = StatusType.Ok
                    },
                    new IndicatorModel
                    {
                        Icon = "fa-plus",
                        HeaderText = "Course Failure: Math",
                        Value = "Yes",
                        Status = StatusType.Warning
                    },
                    new IndicatorModel
                    {
                        Icon = "fa-child",
                        HeaderText = "Suspensions",
                        Value = "Yes",
                        Status = StatusType.Warning
                    },
                    new IndicatorModel
                    {
                        Icon = "fa-book",
                        HeaderText = "Level 1 Score: ELA",
                        Value = "No",
                        Status = StatusType.Ok,
                        MoreInfo = new MoreInfoModel()
                        {
                            Title = "Level 1 Score: State Standardized Assessment ELA",
                            Description = "A longer description of the assessment will go here"
                        }
                    },
                    new IndicatorModel
                    {
                        Icon = "fa-file-text",
                        HeaderText = "Course Failure: ELA",
                        Value = "No",
                        Status = StatusType.Ok
                    },
                    new IndicatorModel
                    {
                        Icon = "fa-calculator",
                        HeaderText = "Level 1 Score: Math",
                        Value = "Yes",
                        Status = StatusType.Warning,
                        MoreInfo = new MoreInfoModel()
                        {
                            Title = "Level 1 Score: State Standardized Assessment Math",
                            Description = "A longer description of the assessment will go here"
                        }

                    },
                }
            };
            return View(model);
        }
    }
}