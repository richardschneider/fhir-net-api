﻿using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hl7.Fhir.Search
{
    public static class QueryExtensions
    {     
        /// <summary>
        /// Add one or more search parameters to query on
        /// </summary>
        /// <param name="qry"></param>
        /// <param name="criteria"></param>
        public static Query Where(this Query qry, IEnumerable<Criterium> criteria)
        {
            if (criteria == null) throw Error.ArgumentNull("criteria");

            foreach (var criterium in criteria)
            {
                var keyValue = criterium.ToString().SplitLeft('=');
                qry.AddParameter(keyValue.Item1, keyValue.Item2);
            }

            // Just for chaining calls
            return qry;
        }

        public static Query Where(this Query qry, params Criterium[] criteria)
        {
            if (criteria == null) throw Error.ArgumentNull("criteria");

            qry.Where((IEnumerable<Criterium>)criteria);

            // Just for chaining calls
            return qry;
        }

        public static Query Custom(this Query qry, string customQueryName)
        {
            if (customQueryName == null) throw Error.ArgumentNull("customQueryName");

            qry.QueryName = customQueryName;
            return qry;
        }

        public static Query OrderBy(this Query qry, string paramName, SortOrder order = SortOrder.Ascending)
        {
            if (paramName == null) throw Error.ArgumentNull("paramName");

            qry.Sort = Tuple.Create(paramName, order);
            return qry;
        }

        public static Query LimitPageSizeTo(this Query qry, int count)
        {
            qry.Count = count;
            return qry;
        }

        public static Query SummaryOnly(this Query qry, bool summaryOnly = true)
        {
            qry.Summary = summaryOnly;
            return qry;
        }

        //public static Query Include(this Query qry, string path)
        //{
            
        //}
    
    }




}