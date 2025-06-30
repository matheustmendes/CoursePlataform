﻿using System.Runtime.InteropServices.JavaScript;

namespace CoursePlataform.ContentContext;

public abstract class Content
{

    public Content(string title, string url)
    {
        Title = title;
        Url = url;
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
}