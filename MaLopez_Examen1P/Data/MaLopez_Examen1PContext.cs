using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MaLopez_Examen1P.Models;

namespace MaLopez_Examen1P.Data
{
    public class MaLopez_Examen1PContext : DbContext
    {
        public MaLopez_Examen1PContext (DbContextOptions<MaLopez_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<MaLopez_Examen1P.Models.ML_modelo1> ML_modelo1 { get; set; } = default!;
    }
}
