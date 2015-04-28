﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkDAL
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Infrastructure;

	public partial class EFModelContainer : DbContext
	{
		public EFModelContainer()
			: base("name=EFModelContainer")
		{
			Database.ExecuteSqlCommand(
				"DECLARE @DatabaseName nvarchar(50) SET @DatabaseName= N'HellDB' DECLARE @SQL varchar(max) SELECT @SQL = COALESCE(@SQL, '') + 'Kill '" +
				" + Convert(varchar, SPId) + ';' FROM MASTER..SysProcesses WHERE DBId = DB_ID(@DatabaseName) AND SPId <> @@SPId --SELECT @SQL EXEC(@SQL)");

			//Create database always, even If exists
			Database.SetInitializer(new DBInitializer());
			

		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			throw new UnintentionalCodeFirstException();
		}

		public virtual DbSet<Sinner> Sinners { get; set; }
		public virtual DbSet<Sin> Sins { get; set; }
		public virtual DbSet<Punishment> Punishments { get; set; }
		public virtual DbSet<Punisher> Punishers { get; set; }
		public virtual DbSet<PunisherRank> PunisherRanks { get; set; }
	}
}
