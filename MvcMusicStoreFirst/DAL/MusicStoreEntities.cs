﻿using System.Data.Entity;
using MvcMusicStoreFirst.Models;

namespace MvcMusicStoreFirst.DAL {
    public class MusicStoreEntities :DbContext {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}