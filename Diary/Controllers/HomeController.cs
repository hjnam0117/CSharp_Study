using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppReport2.Models;

namespace WebAppReport2.Controllers
{
    public class HomeController : Controller
    {
        private readonly DiaryDbContext _diaryDbContext;
        public HomeController(DiaryDbContext diaryDbContext)
        {
            _diaryDbContext = diaryDbContext;
        }

        public IActionResult Index()
        {
            var diaryDbContext = _diaryDbContext.Diary.ToList();
            return View(diaryDbContext);
        }
        public IActionResult Create()
        {
            return View();
        }

        // POST: 삽입기능
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,Date,Writer")] Diary diary)
        {
            if (ModelState.IsValid)
            {
                _diaryDbContext.Add(diary);
                await _diaryDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diary);
        }
        // 상세정보 출력
        public IActionResult Result(Diary d)
        {
            return View(d);
        }
        //삭제
        [HttpPost]
        public async Task<IActionResult> DeleteSelected(List<int> selectedDiarys)
        {
            var diarysToDelete = _diaryDbContext.Diary.Where(s => selectedDiarys.Contains(s.Id)).ToList();

            _diaryDbContext.Diary.RemoveRange(diarysToDelete);
            await _diaryDbContext.SaveChangesAsync();

            return RedirectToAction("Index");

        }
        public IActionResult Chart()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
