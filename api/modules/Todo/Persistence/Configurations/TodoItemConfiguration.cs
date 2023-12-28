﻿using FSH.WebApi.Todo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSH.WebApi.Todo.Persistence.Configurations;
internal class TodoItemConfiguration : IEntityTypeConfiguration<TodoItem>
{
    public void Configure(EntityTypeBuilder<TodoItem> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title)
                .HasMaxLength(100);
        builder.Property(x => x.Note)
                .HasMaxLength(1000);
    }
}