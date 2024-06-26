﻿namespace IncludeTypeBackend.Dtos;

public class ProjectDetailsDto
{
    public Project Project { get; set; } = new();
    public List<ProjectMember> ProjectMembers { get; set; } = [];
    public bool IsAdmin { get; set; }
}
