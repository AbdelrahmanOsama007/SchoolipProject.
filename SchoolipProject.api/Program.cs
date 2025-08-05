using Microsoft.EntityFrameworkCore;
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
            builder.Services.AddScoped<SchoolipProject.Infrastructure.Irepository.IDepatrmentRepo, SchoolipProject.Infrastructure.Repository.DepatrmentRepo>();
            builder.Services.AddScoped<SchoolipProject.Infrastructure.Irepository.ISubjectRepo, SchoolipProject.Infrastructure.Repository.SubjectRepo>();
            builder.Services.AddScoped<SchoolipProject.Infrastructure.Irepository.IDepartmentSubjectRepo, SchoolipProject.Infrastructure.Repository.DepartmentSubjectRepo>();
            builder.Services.AddScoped<SchoolipProject.Infrastructure.Irepository.IStudentSubjectRepo, SchoolipProject.Infrastructure.Repository.StudentSubjectRepo>();
            builder.Services.AddScoped<SchoolipProject.Infrastructure.Irepository.IStudentRepo, SchoolipProject.Infrastructure.Repository.StudentRepo>();
            builder.Services.AddTransient<IStudentService, StudentService>();
            builder.Services.AddTransient<IDepatrmentService, DepatrmentService>();
            builder.Services.AddTransient<ISubjectService, SubjectService>();
            builder.Services.AddTransient<IDepartmentSubjectService, DepartmentSubjectService>();
            builder.Services.AddTransient<IStudentSubjectService, StudentSubjectService>();
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
