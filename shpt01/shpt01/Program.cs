using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.Administration;

namespace shpt01
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void ListarApps() 
        {
           SPWebApplicationCollection coleccionesapps= SPWebService.ContentService.WebApplications;
           if (coleccionesapps.Count != null) {
               foreach (var spwWebApp in coleccionesapps) 
               {
                   Console.WriteLine(spwWebApp.ApplicationPool.Name);
               }
           }
        }
    }
}
