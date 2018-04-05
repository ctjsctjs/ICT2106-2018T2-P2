﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SmartHome.DAL;

using MongoDB.Bson;
using MongoDB.Driver.Builders;
using SmartHome.DAL.Mappers;
using SmartHome.Models;

namespace SmartHome
{
    public class Program
    {
        LinkedList<object> list = new LinkedList<object>();
        private static IScheduleMapper _ScheduleMapper = new ScheduleMapper();

        public static void Main(string[] args)
        {

            //BuildWebHost(args).Run();

            // var host = BuildWebHost(args);

            // using (var scope = host.Services.CreateScope())
            // {
                // var services = scope.ServiceProvider;
                // try
                // {
                    // var context = services.GetRequiredService<SmartHomeDbContext>();
                    // DbInitializer.Initialize(context);
                // }
                // catch (Exception ex)
                // {
                    // var logger = services.GetRequiredService<ILogger<Program>>();
                    // logger.LogError(ex, "An error occured while seeding the databse.");
                // }
            // }

            // host.Run();


            Console.WriteLine("Starting Program");
            //Console.WriteLine(DateTime.Now.ToString(CultureInfo.CurrentCulture));
            List<String> list1 = new List<string>();

            list1.Add("1");
            list1.Add("2");



            Schedule lol = new Schedule();
            lol.StartTime = new DateTime();
            lol.EndTime = new DateTime();
            lol.ApplyToEveryWeek = true;
            lol.DayOfWeek = list1;

            //ObjectId id = new ObjectId("5ac5c582327aa3469c7621db");
            
           // _ScheduleMapper.SelectByDevice(id);
            _ScheduleMapper.Create(lol).Save().Commit();
            
            //Console.WriteLine(_ScheduleMapper.SelectById(id).EndTime + "\n");

            //Console.WriteLine(_ScheduleMapper.SelectById("sdfsdf"));

            BuildWebHost(args).Run();

        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}