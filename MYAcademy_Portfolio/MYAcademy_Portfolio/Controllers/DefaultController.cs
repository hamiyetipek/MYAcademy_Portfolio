using Microsoft.AspNetCore.Mvc;
using MYAcademy_Portfolio.Context;
using MYAcademy_Portfolio.Entities;

namespace MYAcademy_Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        private readonly PortfolioContext _context;

        public DefaultController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendMessage(Message message)
        {
         
            message.SendDate = DateTime.Now;
            message.IsRead = false;
            ModelState.Remove(nameof(Message.SendDate));
            ModelState.Remove(nameof(Message.IsRead));

            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Lütfen tüm zorunlu alanları uygun şekilde doldurun.";
                return RedirectToAction(nameof(Index));
            }

            try
            {
                await _context.Messages.AddAsync(message); 
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Mesajınız başarıyla gönderildi. En kısa sürede dönüş yapacağım.";
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "Mesaj kaydedilirken bir hata oluştu. Lütfen tekrar deneyin.";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}