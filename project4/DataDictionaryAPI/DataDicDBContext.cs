using System;
using Microsoft.EntityFrameworkCore;
using MyWebApi;
namespace DataDictionaryAPI
{
public class DataDicDBContext: DbContext{

public DataDicDBContext(DbContextOptions<DataDicDBContext> options):base(options)   {

}
public DataDicDBContext()   {
    
}

public DbSet<EmpIDg> EmpIDg { get; set; }
public DbSet<PatientTb> PatientTb { get; set; }
public DbSet<RoomTb> RoomTb { get; set; }
public DbSet<serviceTB1> serviceTB1 { get; set; }
public DbSet<ServiceTokenStatusHistoryTBq> ServiceTokenStatusHistoryTBq { get; set; }
public DbSet<ServiceToken> ServiceToken { get; set; }
public DbSet<StatusTB1> StatusTB1 { get; set; }
}    
}
