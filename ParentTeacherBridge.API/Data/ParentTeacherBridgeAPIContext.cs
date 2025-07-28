using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParentTeacherBridge.API.Models;

namespace ParentTeacherBridge.API.Data
{
    public class ParentTeacherBridgeAPIContext : DbContext
    {
        public ParentTeacherBridgeAPIContext (DbContextOptions<ParentTeacherBridgeAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ParentTeacherBridge.API.Models.Admin> Admin { get; set; } = default!;
        public object Teacher { get; internal set; }
    }
}
