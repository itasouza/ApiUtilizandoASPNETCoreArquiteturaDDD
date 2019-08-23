﻿using Api.Data.Context;
using Api.Data.Implementations;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>),typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUsuarioRepository, UsuarioImplementation>();


            //serviceCollection.AddDbContext<MyContext>
            //(
            //   options => options.UseMySql("Server=localhost;Port=3306;DataBase=DbModelo;Uid=root;Pwd=")
            //);

            serviceCollection.AddDbContext<MyContext>
            (
               options => options.UseSqlServer("Server=DESKTOP-MO51FPC\\SQLEXPRESS;Database=ApiDB;User Id=sa;Password=root;")
            );

        }
    }
}
