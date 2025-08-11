using Microsoft.EntityFrameworkCore;
using SchoolipProject.Core;
using SchoolipProject.Infrastructure.InfrastructureBases;
using SchoolipProject.Infrastructure.Irepository;
using SchoolipProject.Infrastructure.Repository;
using SchoolipProject.Service.Iservice;
using SchoolipProject.Service.Service;

namespace SchoolipProject.api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //connection to database
            builder.Services.AddDbContext<SchoolipProject.Infrastructure.Data.DbContext1>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            #region dependency injection

            // Register repositories
            builder.Services.AddTransient<IStudentRepo, StudentRepo>();
            builder.Services.AddTransient<IDepatrmentRepo, DepatrmentRepo>();
            builder.Services.AddTransient<ISubjectRepo, SubjectRepo>();
            builder.Services.AddTransient<IStudentSubjectRepo, StudentSubjectRepo>();
            builder.Services.AddTransient<IDepartmentSubjectRepo, DepartmentSubjectRepo>();
            
            // Register generic repository
            builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            
            // Register services
            builder.Services.AddTransient<IStudentService, StudentService>();
            builder.Services.AddTransient<IDepatrmentService, DepatrmentService>();
            builder.Services.AddTransient<ISubjectService, SubjectService>();
            builder.Services.AddTransient<IDepartmentSubjectService, DepartmentSubjectService>();
            builder.Services.AddTransient<IStudentSubjectService, StudentSubjectService>();
            
            builder.Services.RegisterCoreDependencies();
            
            #endregion 

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
