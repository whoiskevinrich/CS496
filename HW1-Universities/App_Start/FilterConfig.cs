﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Universities
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
