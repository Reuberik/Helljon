using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Helljon.Site.Data {
    public class HelljonUserDbContext : IdentityDbContext {
        public HelljonUserDbContext(DbContextOptions<HelljonUserDbContext> options)
            : base(options) {
        }
    }
}
