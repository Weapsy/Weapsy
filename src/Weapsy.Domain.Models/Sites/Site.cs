﻿using System;
using Weapsy.Domain.Models.Sites.Commands;

namespace Weapsy.Domain.Models.Sites
{
    public class Site
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public Site()
        {
        }

        public Site(CreateSite command)
        {
            Id = command.SiteId;
            Name = command.Name;
        }

        public void Update(UpdateSite command)
        {
            Name = command.Name;
        }
    }
}
