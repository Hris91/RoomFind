using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomFind.Data.Context
{
    public class RoomFindContext : DbContext
    {
        public RoomFindContext(DbContextOptions<RoomFindContext> options)
             : base(options) {}     
    }
}
