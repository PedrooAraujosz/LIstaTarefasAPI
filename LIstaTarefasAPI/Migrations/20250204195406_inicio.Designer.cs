﻿// <auto-generated />
using LIstaTarefasAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LIstaTarefasAPI.Migrations
{
    [DbContext(typeof(ListaTarefasContext))]
    [Migration("20250204195406_inicio")]
    partial class inicio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LIstaTarefasAPI.Models.Tarefa", b =>
                {
                    b.Property<int>("TarefaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TarefaId"));

                    b.Property<bool>("Concluida")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoTarefaId")
                        .HasColumnType("int");

                    b.HasKey("TarefaId");

                    b.HasIndex("TipoTarefaId");

                    b.ToTable("Tarefas");
                });

            modelBuilder.Entity("LIstaTarefasAPI.Models.TipoTarefa", b =>
                {
                    b.Property<int>("TipoTarefaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoTarefaId"));

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoTarefaId");

                    b.ToTable("TiposTarefas");
                });

            modelBuilder.Entity("LIstaTarefasAPI.Models.Tarefa", b =>
                {
                    b.HasOne("LIstaTarefasAPI.Models.TipoTarefa", "TipoTarefa")
                        .WithMany()
                        .HasForeignKey("TipoTarefaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoTarefa");
                });
#pragma warning restore 612, 618
        }
    }
}
