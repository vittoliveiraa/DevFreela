﻿using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreela.Infrastructure.Persistence.Configurations
{
    public class ProjectConfigurations : IEntityTypeConfiguration<Project> 
    {
       public void Configure(EntityTypeBuilder<Project> builder)
        {
            //Chave Primária
            builder
                .HasKey(p => p.Id);

            //Relacionamentos
            builder
                .HasOne(p => p.Freelancer)
                .WithMany(p => p.FreelanceProjects)
                .HasForeignKey(p => p.IdFreelancer)
                .OnDelete(DeleteBehavior.Restrict);

            builder
             .HasOne(p => p.Client)
             .WithMany(p => p.OwnedProjects)
             .HasForeignKey(p => p.IdClient)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
