// <auto-generated />
using System;
using CrudTodoListApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudTodoListApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230104130856_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("CrudTodoListApi.Models.Tarefa", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("concluido")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("dataDeCriacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("nomeTarefa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("tarefa");
                });
#pragma warning restore 612, 618
        }
    }
}
