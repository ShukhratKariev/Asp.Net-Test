﻿using Domain.Enums;

namespace Domain;

public class Project
{
    public int Id { get; set; }

    public string Name { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public ProjectPriorityEnum Priority { get; set; }

    public string ExecutiveCompanyName { get; set; }
    public string Client { get; set; }
    
    public Employee ProjectLead { get; set; }
    public int ProjectLeadId { get; set; }
    
    public List<EmployeeProject> Employees { get; set; }
}