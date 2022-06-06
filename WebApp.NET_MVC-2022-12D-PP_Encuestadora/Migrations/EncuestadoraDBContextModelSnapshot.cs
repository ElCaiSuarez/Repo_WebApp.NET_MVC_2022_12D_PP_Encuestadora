﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.NET_MVC_2022_12D_PP_Encuestadora.Context;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Migrations
{
    [DbContext(typeof(EncuestadoraDBContext))]
    partial class EncuestadoraDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cuitCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("domicilioCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mailCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passwordCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("precioCliente")
                        .HasColumnType("int");

                    b.HasKey("ClienteId");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models.Encuesta", b =>
                {
                    b.Property<int>("EncuestaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("datetimeCreacionEncuesta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("datetimeVencimientoEncuesta")
                        .HasColumnType("datetime2");

                    b.Property<int>("puntosEncuesta")
                        .HasColumnType("int");

                    b.Property<string>("tituloEncuesta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EncuestaId");

                    b.ToTable("encuestas");
                });

            modelBuilder.Entity("WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models.OpcionPregunta", b =>
                {
                    b.Property<int>("OpcionPreguntaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("opcionSeleccionada")
                        .HasColumnType("bit");

                    b.Property<string>("tituloOpcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OpcionPreguntaId");

                    b.ToTable("opciones");
                });

            modelBuilder.Entity("WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models.Pregunta", b =>
                {
                    b.Property<int>("PreguntaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EncuestaId")
                        .HasColumnType("int");

                    b.Property<int>("tipoPregunta")
                        .HasColumnType("int");

                    b.Property<string>("tituloPregunta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PreguntaId");

                    b.ToTable("preguntas");
                });

            modelBuilder.Entity("WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("datetimeFechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("dniUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("domicilioUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mailUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passwordUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("preferenciaUsuario")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId");

                    b.ToTable("usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
