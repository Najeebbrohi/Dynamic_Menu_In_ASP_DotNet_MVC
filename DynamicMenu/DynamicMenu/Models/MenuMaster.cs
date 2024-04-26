using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMenu.Models
{
    public class MenuMaster
    {
        public MenuMaster()
        {
            MenuList = new List<MenuMaster>();
        }
        [Key]
        public int Id { get; set; }
        public string MenuText { get; set; }
        public int? ParentId { get; set; }
        public string MenuUrl { get; set; }
        [NotMapped]
        public List<MenuMaster> MenuList { get; set; }

        public List<MenuMaster> MenuTree(List<MenuMaster> menuList, int? parentId)
        {
            return menuList.Where(x => x.ParentId == parentId).Select(
                x => new MenuMaster
                {
                    Id = x.Id,
                    MenuText = x.MenuText,
                    ParentId = x.ParentId,
                    MenuUrl = x.MenuUrl,
                    MenuList = MenuTree(menuList,x.Id)
                }).ToList();
        }
    }
}