using System;
using Microsoft.AspNetCore.Mvc;

namespace ModelBinding.Models;

public class Book
{
    [FromQuery]
    public int? BookId { get; set; }
    [FromRoute]
    public string? Author { get; set; }

    public override string ToString()
    {
        return $"Book object - Book id {BookId}, Author: {Author}";
    }
}
