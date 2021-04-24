using BookDemo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BookDemo.Controllers
{
    [Route("api/Book")]
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Book.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var bookFromDb = await _db.Book.FirstOrDefaultAsync(u => u.Id == id);

            if (bookFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _db.Book.Remove(bookFromDb);
            await _db.SaveChangesAsync();

            return Json(new { success = true, message = "Delete Successful" });
        }
    }
}