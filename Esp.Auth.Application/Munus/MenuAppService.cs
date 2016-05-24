using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esp.Auth.Munus.Dto;
using Abp.Domain.Repositories;
using Esp.Auth.Menus;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Esp.Auth.Munus
{
    public class MenuAppService : ApplicationService, IMenuAppService
    {
        private readonly IRepository<Menu, long> _menuRepository;

        public MenuAppService(IRepository<Menu, long> menuRepository)
        {
            this._menuRepository = menuRepository;
        }
        public async Task<ListResultOutput<MenuListDto>> GetMenus()
        {
            var menus = await _menuRepository.GetAllListAsync();

            return new ListResultOutput<MenuListDto>(
                    menus.MapTo<List<MenuListDto>>()
                );
        }
    }
}
