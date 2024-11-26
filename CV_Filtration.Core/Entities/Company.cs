﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Filtation_System.Core.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Website { get; set; }
        public string? Location { get; set; }
        public string Email { get; set; } = string.Empty;

        public ICollection<CompanyJobPosting> JobPostings { get; set; } = new List<CompanyJobPosting>();
    }

}