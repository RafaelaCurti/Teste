﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data.Interface
{
    public interface IDefaulConnectionDapper
    {
        IDbConnection Connection();
    }
}
