using API.Models;
using API.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IUpdateContentService
    {
        public Task<string> UpdateContents(int id, Update contents);
    }
}
