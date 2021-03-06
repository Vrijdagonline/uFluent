﻿using System.Collections.Generic;
using uFluent.Migrate;
using uFluentExample.uFluent.Migrate.Migrations;

namespace uFluentExample.uFluent.Migrate
{
    public class MigrationList : IMigrationList
    {
        public IEnumerable<IUmbracoMigration> Migrations
        {
            get
            {
                return new List<IUmbracoMigration>
                {
                    new HomePage(),
                    new HomePageAdditions(),
                    new Category(),
                    new Article(),
                    new CategoryAddIcon(),
                    new SubCategoryCreateDataType()
                };
            }
        }
    }
}