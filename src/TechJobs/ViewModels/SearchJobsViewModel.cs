﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class SearchJobsViewModel 
    {
        // TODO #7.1 - Extract members common to JobFieldsViewModel
        // to BaseViewModel

        // The search results
        public List<Job> Jobs { get; set; }

      

        // The search value
        [Display(Name = "Keyword:")]
        public string Value { get; set; } = "";
        public string Title { get; internal set; }
        public object Column { get; internal set; }
        public List<JobFieldType> Columns { get; }

        public SearchJobsViewModel()
        {
            // The column to search, defaults to all
            Column = JobFieldType.All;

            // Populate the list of all columns

            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }


        }
    }
}
