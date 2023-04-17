﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace HrApi.Models
{

    public record DepartmentCreateRequest
    {
        [Required, MinLength(3), MaxLength(20)]
        public string Name { get; set; } = string.Empty;
    }
    public record DepartmentsResponse
    {
        public List<DepartmentSummaryItem> Data { get; set; } = new();
    }
    public record DepartmentSummaryItem
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
