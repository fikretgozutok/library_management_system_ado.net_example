﻿using Business.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookManager : BookService
    {
        public BookManager(BookDal repository) : base(repository) { }
    }
}
