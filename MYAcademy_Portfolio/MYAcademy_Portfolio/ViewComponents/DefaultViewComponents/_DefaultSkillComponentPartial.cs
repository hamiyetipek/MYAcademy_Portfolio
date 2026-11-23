using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYAcademy_Portfolio.Context;


namespace MYAcademy_Portfolya.ViewComponents.DefaultViewComponents
{
    public class _DefaultSkillComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;
        public _DefaultSkillComponentPartial(PortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.SkillCategories
                 .Include(x => x.Skills)          
                 .OrderBy(x => x.DisplayOrder)
                 .ToList();
            return View(values);
        }

    }
}