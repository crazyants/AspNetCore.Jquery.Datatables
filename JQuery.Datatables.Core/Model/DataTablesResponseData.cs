﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JQuery.Datatables.Core.Model
{
    public class DataTablesResponseData
    {
        public int iTotalRecords { get; set; }
        public int iTotalDisplayRecords { get; set; }
        public int sEcho { get; set; }
        public object[] aaData { get; set; }


        public DataTablesResponseData Transform<TData, TTransform>(Func<TData, TTransform> transformRow, ResponseOptions responseOptions = null)
        {
            var data = new DataTablesResponseData
            {
                aaData = aaData.Cast<TData>().Select(transformRow).Cast<object>().ToArray(),
                iTotalDisplayRecords = iTotalDisplayRecords,
                iTotalRecords = iTotalRecords,
                sEcho = sEcho
            };
            return data;
        }
    }
}
