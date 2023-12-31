﻿// <auto-generated />
using CBU_Certificate_Generator.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CBU_Certificate_Generator.Migrations
{
    [DbContext(typeof(CertificateDBContext))]
    [Migration("20230820120534_firstmigration")]
    partial class firstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("CBU_Certificate_Generator.Entities.CertificateTemplate", b =>
                {
                    b.Property<string>("TemplateId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TemplateId");

                    b.ToTable("certificateTemplates");
                });
#pragma warning restore 612, 618
        }
    }
}
