﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChessOpening
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ChessEntities : DbContext
    {
        public ChessEntities()
            : base("name=ChessEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Debut> Debuts { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GameType> GameTypes { get; set; }
        public virtual DbSet<RankPlayer> RankPlayers { get; set; }
        public virtual DbSet<ResultGame> ResultGames { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<v_DebutStatistic> v_DebutStatistic { get; set; }
        public virtual DbSet<v_GrandMasters> v_GrandMasters { get; set; }
        public virtual DbSet<v_PlayerInfo> v_PlayerInfo { get; set; }
    }
}