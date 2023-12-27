using System;
using System.Collections.Generic;

namespace ReactCoreDemo.Server.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Description { get; set; }

    public string? Phone { get; set; }
}
