using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Esp.Auth.Munus.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esp.Auth.Munus
{
    public interface IMenuAppService:IApplicationService
    {
        Task<ListResultOutput<MenuListDto>> GetMenus();


    }
}
