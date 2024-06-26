﻿namespace IncludeTypeBackend.Models;

public class ProjectIssue
{
    public string Id { get; set; } = "";
    public string ProjId { get; set; } = "";
    public string ProjName { get; set; } = "";
    public string Title { get; set; } = "";
    public string Date { get; set; } = "";
    public string Details { get; set; } = "";
    public string Deadline { get; set; } = "";
    public string Assigned { get; set; } = "";
    public bool Completed { get; set; } = false;
    public string Priority { get; set; } = "";
    public string Author { get; set; } = "";

    // Navigation Property
    //public Project Project { get; set; }
}
