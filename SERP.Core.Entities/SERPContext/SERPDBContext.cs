using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace SERP.Core.Entities.SERPContext
{
    public class SERPDBContext : DbContext
    {
        private readonly IConfiguration configuration;
        private  string _connectionString = string.Empty;
        public SERPDBContext(IConfiguration configuration)
        {
            this.configuration = configuration;
            this._connectionString = configuration.GetSection("SERPDBInfo:SERpDevelopmentDB").Value;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this._connectionString);
        }
    }
}
