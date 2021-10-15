﻿using DataContracts;
using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Constant : Functoid

    {
     
        public override List<Column> Transform(List<Column> columnList, List<Parameter> parameters)
        {
            var cellList = new List<Cell>();
            cellList.Add(new Cell()
            {
                content = "test constant",
            });
            cellList.Add(new Cell()
            {
                content = "test constant",
            });


            cellList.Add(new Cell()
            {
                content = "test constant",
            }); columnList = new List<Column>();
            columnList.Add(new Column()
            {
                id = Guid.NewGuid(),
                name = "title",
                cells = cellList,
            });

            return columnList;
        }
    }
}