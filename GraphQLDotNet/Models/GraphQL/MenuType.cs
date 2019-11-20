﻿using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotNet.Models.GraphQL
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Name = "Menu";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the menu.");
            Field(x => x.Name).Description("The name of the menu");
            Field(x => x.MenuItems, type: typeof(ListGraphType<MenuItemType>)).Description("The menu items.");
        }
    }    
 
}
