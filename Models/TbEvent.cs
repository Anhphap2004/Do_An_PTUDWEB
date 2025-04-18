﻿using System;
using System.Collections.Generic;

namespace Pantus.Models;

public partial class TbEvent
{
    public int EventId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? Location { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsActive { get; set; }

    public string? Image { get; set; }

    public string? Details { get; set; }
}
