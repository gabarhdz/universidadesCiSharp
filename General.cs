using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace universidades
{
	public class General
	{
        public static String basededatosactual = ConfigurationManager.ConnectionStrings["conexionreal"].ConnectionString;
    }
}