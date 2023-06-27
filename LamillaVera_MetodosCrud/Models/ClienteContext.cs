using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamillaVera_MetodosCrud.Models
{
    public class ClienteContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KEVINLAMILLA\\SQLEXPRESS;Database=ClienteBaseDatos;Trusted_Connection=True;Encrypt = False ;");
        }
    }
}
