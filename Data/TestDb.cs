using ClinicUserManagementService.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicUserManagementService.Data
{
    public static class TestDb
    {
        public static void DataPopulate(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDBContext>());
            }
        }

        private static void SeedData(AppDBContext context)
        {
            if (!context.Patients.Any())
            {
                Console.WriteLine("---> Adding data");
                context.Patients.AddRange(
                    new Patient(){
                        FName = "Anthony", LName = "Mugabira", Email = "me@mugabira.com", Gender = "Male", NIN = "25644114QWA", 
                        PassportNumber = "A0121212", PhoneNumber = "+256703386060", UserType = "IP", DateOfBirth = new DateTime(1940, 2, 18)
                    },
                    new Patient()
                    {
                        FName = "Patrick",
                        LName = "Kamuli",
                        Email = "iamkamuli@rocketmail.com",
                        Gender = "Male",
                        NIN = "2545QWA",
                        PassportNumber = "A0poo12",
                        PhoneNumber = "+25670121233",
                        UserType = "IP",
                        DateOfBirth = new DateTime(1978, 5, 9)
                    },
                    new Patient()
                    {
                        FName = "Ada",
                        LName = "Aliyinza",
                        Email = "mine@ada.com",
                        Gender = "Female",
                        NIN = "25645562",
                        PassportNumber = "A45221209",
                        PhoneNumber = "+2567852520",
                        UserType = "OP",
                        DateOfBirth = new DateTime(2002, 2, 18)
                    },
                    new Patient()
                    {
                        FName = "Kirigwajjo",
                        LName = "Emma",
                        Email = "kiriemma@gmail.com",
                        Gender = "Male",
                        NIN = "2564411KLJ",
                        PassportNumber = "A0098765",
                        PhoneNumber = "+2567524411698",
                        UserType = "OP",
                        DateOfBirth = new DateTime(1989, 12, 18)
                    }
                    );

                context.SaveChanges();

            }
            else
                Console.WriteLine("----> Already has data");
        }
    }
}
