using Data.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Business.Engines
{
    public class BaseEngine : IDisposable
    {
        internal CRMApi_CoreContext _context;

        public BaseEngine(CRMApi_CoreContext context)
        {
            this._context = context;
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}
