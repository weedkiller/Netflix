﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.Storage.Table;

namespace Netflix.Repositories.AzureEntities
{
    public class GenreEntity: TableEntity
    {
        public string Name { get; set; }
    }
}