﻿using System.ComponentModel.DataAnnotations;

namespace POSSystem.Models.Address;

public class Picture
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    /// <summary>
    /// Gets or sets the picture mime type
    /// </summary>
    public string MimeType { get; set; }

    /// <summary>
    /// Gets or sets the SEO friendly filename of the picture
    /// </summary>
    public string SeoFilename { get; set; }

    /// <summary>
    /// Gets or sets the "alt" attribute for "img" HTML element. If empty, then a default rule will be used (e.g. product name)
    /// </summary>
    public string AltAttribute { get; set; }

    /// <summary>
    /// Gets or sets the "title" attribute for "img" HTML element. If empty, then a default rule will be used (e.g. product name)
    /// </summary>
    public string TitleAttribute { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the picture is new
    /// </summary>
    public bool IsNew { get; set; }

    /// <summary>
    /// Gets or sets the picture virtual path
    /// </summary>
    public string VirtualPath { get; set; }
}
