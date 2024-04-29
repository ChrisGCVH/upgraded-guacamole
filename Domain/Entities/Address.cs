﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HicomInterview.Domain.Entities;

public partial class Address
{
    [Key]
    public int AddressId { get; set; }

    [Timestamp]
    public byte[] RowVersion { get; set; }

    public string AddressType { get; set; }

    public string AddressLine1 { get; set; }

    public string AddressLine2 { get; set; }

    public string AddressLine3 { get; set; }

    public string AddressLine4 { get; set; }

    public string AddressPostcode { get; set; }

    [InverseProperty("NewAddress")]
    public virtual ICollection<Widget> WidgetNewAddress { get; set; } = new List<Widget>();

    [InverseProperty("OldAddress")]
    public virtual ICollection<Widget> WidgetOldAddress { get; set; } = new List<Widget>();
}
