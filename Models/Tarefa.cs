using System;
using Microsoft.EntityFrameworkCore;

namespace TrilhaApiDesafio.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public EnumStatusTarefa Status { get; set; }  // Usa o enum já existente
    }

    // Configuração opcional para EF Core armazenar enum como string
    public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Tarefa> builder)
        {
            builder.Property(t => t.Status)
                   .HasConversion<string>(); // Salva o enum como texto no banco
        }
    }
}
