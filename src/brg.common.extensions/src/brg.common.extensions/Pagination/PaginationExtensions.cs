﻿using System;
using System.Linq;
using brg.common.extensions.Auxiliar;

namespace brg.common.extensions.Pagination
{
    public static class PaginationExtensions
    {
        public static Pagination<T> Paginate<T>(this IQueryable<T> query, int page, int limit) where T : class
        {
            var pagination = new Pagination<T>();
            var records = query.Count();
            var pages = (double)records / limit;
            var round = (int)Math.Ceiling(pages);
            var skip = (page - 1) * limit;

            pagination.Page = page;
            pagination.Limit = limit;
            pagination.Records = records;
            pagination.Previous = (page - 1 == 0) ? 1 : page - 1;
            pagination.Next = (page + 1 == round + 1) ? round : page + 1;
            pagination.Pages = round;
            pagination.Results = query.Skip(skip).Take(limit).ToList();

            return pagination;
        }
    }
}