﻿using ASPPrueba.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPPrueba.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Category>categories { get; set; }
        public DbSet<Pregunta> preguntas { get; set; }

        public DbSet<Respuesta> respuestas { get; set; }
    }
}
