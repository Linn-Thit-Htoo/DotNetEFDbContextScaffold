﻿namespace DotNetEFDbContextScaffold.Models;

public class Income
{
    public long IncomeId { get; set; }

    public long Amount { get; set; }

    public DateTime Date { get; set; }

    public bool IsActive { get; set; }
}