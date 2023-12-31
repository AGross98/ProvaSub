﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProvaSub.Data;

#nullable disable

namespace ProvaSub.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20231211235309_terceira")]
    partial class terceira
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("ProvaSub.Model.Aluno", b =>
                {
                    b.Property<int>("AlunoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("DataNasc")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AlunoID");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("ProvaSub.Model.Imc", b =>
                {
                    b.Property<int>("ImcID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Altura")
                        .HasColumnType("REAL");

                    b.Property<int>("AlunoID")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Peso")
                        .HasColumnType("REAL");

                    b.HasKey("ImcID");

                    b.HasIndex("AlunoID");

                    b.ToTable("Imc");
                });

            modelBuilder.Entity("ProvaSub.Model.Imc", b =>
                {
                    b.HasOne("ProvaSub.Model.Aluno", "aluno")
                        .WithMany()
                        .HasForeignKey("AlunoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aluno");
                });
#pragma warning restore 612, 618
        }
    }
}
