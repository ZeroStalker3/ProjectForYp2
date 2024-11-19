using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForYp2.data
{
    class classdata
    {
        internal readonly UserContext userContext;

        public classdata()
        {
            userContext = new UserContext();
            databaseload();
        }

        private void databaseload()
        {
            userContext.Users.Load();
            userContext.Types.Load();
            userContext.Requests.Load();
            userContext.Comments.Load();
            userContext.OrgTechType.Load();
        }
    }
}
