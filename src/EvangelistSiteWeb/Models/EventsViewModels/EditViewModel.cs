﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using EvangelistSiteWeb.Models;

namespace EvangelistSiteWeb.Models.EventsViewModels
{
    public class EditViewModel
    {
        public Event Event { get; set; }

        public IEnumerable<SelectListItem> Talks { get; set; }
    }
}
