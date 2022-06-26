using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RamnisrealtNET.Models;
using RamunisrealtNET.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace RamnisrealtNET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        IWebHostEnvironment _appEnvironment;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment appEnvironment)
        {
            _logger = logger;
            _appEnvironment = appEnvironment;
        }

        private RamunisrealtNET.Models.Ramunisrealt db;	       // класс, описывающий БД	

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Startsite()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Startsite(Servics ms, Cats mc, Reps mr, Districts md)
        {
        
            SqlConnection connection = new SqlConnection(@"Server=ASUSH510M-K; Database=realtstore; Trusted_Connection = True;");

            try
            {
                connection.Open();
                // Label6.Text = "Соединение установлено!";
            }
            catch (Exception)
            {
                // Label6.Text = "Соединение не установлено!";
            }

            var query1 = "INSERT INTO Servics VALUES ('Аренда'),('Продажа'),('Покупка'),('Арендование')";
            var query2 = "INSERT INTO Cats VALUES ('Квартира'),('Комната'),('Дом'),('Земля'),('Гараж'),('Коммерция')";
            var query3 = "INSERT INTO Reps VALUES ('Старый'),('Новый'),('Евро'),('Люкс')";
            var query4 = "INSERT INTO Districts VALUES ('Ленинский район'),('Первомайский район'),('Фрунзенский район'),('Первореченский район'),('Советский район'),('Город Артём'),('Остров Русский')";
            // Создать объект Command.
            SqlCommand cmd = new SqlCommand();

            // Сочетать Command с Connection.
            cmd.Connection = connection;
            cmd.CommandText = query1;
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = query2;
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = query3;
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = query4;
            await cmd.ExecuteNonQueryAsync();


            return RedirectToAction("Index", "Home");

        }

        public async Task<IActionResult> Purchase()
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            return View(await db.Contracts.Where(u => u.Client == User.Identity.Name).Where(u => u.Service.ID > 2).ToListAsync());
        }

        public async Task<IActionResult> Deals()
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            return View(await db.Contracts.Where(u => u.Realtor == User.Identity.Name).Where(u => u.Service.ID > 2).ToListAsync());
        }

        public async Task<IActionResult> Clientproperty(string uid)
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            return View(await db.Contracts.Where(u => u.Realtor == uid).Where(u => u.Service.ID < 3).ToListAsync());
        }

        public async Task<IActionResult> Property()
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();     

            return View(await db.Contracts.Where(u => u.Realtor == User.Identity.Name).Where(u => u.Service.ID <3).ToListAsync());
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            return View(await db.Contracts.Where(u => u.ID == id).ToListAsync());           
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, string city, string adres, int sq, int level, DateTime DS, int term, int price, string pay, string about, string pic)
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            if (id != null)
            {
                Contracts con = await db.Contracts.FirstOrDefaultAsync(p => p.ID == id);
                if (con != null)
                {
                    con.City = city;
                    con.Adres = adres;
                    con.Sq = sq;
                    con.Level = level;
                    con.DS = DS;
                    con.Term = term;
                    con.Price = price;
                    con.Pay = pay;
                    con.About = about;
                    con.Pic = pic;

                    db.Contracts.Update(con);
                    await db.SaveChangesAsync();
                }
            }

            return RedirectToAction("Property", "Home");
        }

        public async Task<IActionResult> Del(int id)
        {
            ViewBag.Numer = id;
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Del(Contracts model, int id)
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            if (id != null)
            {
                Contracts con = await db.Contracts.FirstOrDefaultAsync(p => p.ID == id);
                if (con != null)
                {
                    db.Contracts.Remove(con);
                    await db.SaveChangesAsync();
                }
            }
            return RedirectToAction("Property","Home");
        }

        public IActionResult Calc()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Newrent()
        {

            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();
            IEnumerable<Districts> regions = (IEnumerable<Districts>)db.Districts.ToList();
            IEnumerable<Cats> categors = (IEnumerable<Cats>)db.Cats.ToList();
            IEnumerable<Reps> repairs = (IEnumerable<Reps>)db.Reps.ToList();

            ViewBag.Regions = new SelectList(regions, "ID", "District");
            ViewBag.Categors = new SelectList(categors, "ID", "Cat");
            ViewBag.Repairs = new SelectList(repairs, "ID", "Rep");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Newrent(Contracts model, int cater, int dist,int repa)
        {
            
            DateTime now = DateTime.Now;

            if (ModelState.IsValid)
            {
               if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();
               if (db == null)
              {
                   return View();
               }
            }

            //if (model.Sq == null || model.DS == null || model.Term == null || model.Price == null || model.Pay == null)
               // return View(model);

            db.Contracts.Add(model);

            Districts dister = db.Districts.Where(u => u.ID == dist).FirstOrDefault();
            model.District = dister;

            Cats catere = db.Cats.Where(u => u.ID == cater).FirstOrDefault();
            model.Categor = catere;

            Reps remont = db.Reps.Where(u => u.ID == repa).FirstOrDefault();
            model.Repair = remont;

            Servics serv = db.Servics.Where(u => u.ID == 1).FirstOrDefault();
            model.Service = serv;

            model.Realtor = "seva.m@live.com";
            model.Client = User.Identity.Name;


            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Home");

        }

        [Authorize]
        [HttpGet]
        public IActionResult Newbuy()
        {

            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();
            IEnumerable<Districts> regions = (IEnumerable<Districts>)db.Districts.ToList();
            IEnumerable<Cats> categors = (IEnumerable<Cats>)db.Cats.ToList();
            IEnumerable<Reps> repairs = (IEnumerable<Reps>)db.Reps.ToList();

            ViewBag.Regions = new SelectList(regions, "ID", "District");
            ViewBag.Categors = new SelectList(categors, "ID", "Cat");
            ViewBag.Repairs = new SelectList(repairs, "ID", "Rep");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Newbuy(Contracts model, int cater, int dist, int repa)
        {
            if (ModelState.IsValid)
            {
                if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();
                if (db == null)
                {
                    return View();
                }
            }

            //if (model.Sq == null || model.DS == null || model.Term == null || model.Price == null || model.Pay == null)
            // return View(model);

            db.Contracts.Add(model);

            DateTime now = DateTime.Now;
            model.DZ = now;

            Districts dister = db.Districts.Where(u => u.ID == dist).FirstOrDefault();
            model.District = dister;

            Cats catere = db.Cats.Where(u => u.ID == cater).FirstOrDefault();
            model.Categor = catere;

            Reps remont = db.Reps.Where(u => u.ID == repa).FirstOrDefault();
            model.Repair = remont;

            Servics serv = db.Servics.Where(u => u.ID == 2).FirstOrDefault();
            model.Service = serv;

            model.Term = 999999999;
            model.Realtor = "seva.m@live.com";
            model.Client = User.Identity.Name;


            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Home");

        }

        public IActionResult Archive()
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            return View(db.Achives.Where(u => u.Client == User.Identity.Name).Where(u => u.Realtor == User.Identity.Name).ToList());
        }

        public IActionResult Confirm(int id)
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            return View(db.Files.Where(u => u.Contract.ID == id).ToList());
        }

        [HttpPost]
        public async Task<IActionResult> Confirm(int id, Achives am, Contracts cm)
        {
            DateTime now = DateTime.Now;
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            IEnumerable<Contracts> cont = (IEnumerable<Contracts>)db.Contracts.Where(u => u.ID == id).ToList();
            var pf = db.Files.Where(u => u.Id == id).Select(u => u.Path).FirstOrDefault();

            foreach (var item in cont)
            {
                db.Achives.Add(new RamunisrealtNET.Models.Achives { DZ = now, Client = item.Client, Realtor = item.Realtor, City = item.City, Adres = item.Adres, About = item.About, Sq = item.Sq, Level = item.Level, DS = item.DS, Term = item.Term, Price = item.Price, Pay = item.Pay, Pic = item.Pic, Payfile = pf }
                                                         );
                await db.SaveChangesAsync();
            }
            if (id != null)
            {
                FileModel file = await db.Files.FirstOrDefaultAsync(p => p.Contract.ID == id);
                if (file != null)
                {
                    db.Files.Remove(file);
                    await db.SaveChangesAsync();
                }

                Contracts con = await db.Contracts.FirstOrDefaultAsync(p => p.ID == id);
                if (con != null)
                {
                    db.Contracts.Remove(con);
                    await db.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index", "Home");
        }

            public IActionResult AddFile(int id)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile uploadedFile, FileModel model, int id)
        {
            DateTime now = DateTime.Now;

            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            Contracts cont = db.Contracts.Where(u => u.ID == id).FirstOrDefault();

            if (uploadedFile != null)
            {
                // путь к папке Files
                string path = "/Files/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                
                db.Files.Add(new RamunisrealtNET.Models.FileModel { Name = uploadedFile.FileName, Path = path, Contract = cont, DF = now });
                await db.SaveChangesAsync();

                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    

    List<Contracts> ad;

        [HttpGet]
        public IActionResult Add(int id)
        {
            
            ViewBag.Numer = "Договор № " + id;


            SqlConnection connection = new SqlConnection(@"Server=ASUSH510M-K; Database=realtstore; Trusted_Connection = True;");

            try
            {
                connection.Open();
                // Label6.Text = "Соединение установлено!";
            }
            catch (Exception)
            {
                // Label6.Text = "Соединение не установлено!";
            }

            var query = "SELECT Cats.Cat, Reps.Rep, Districts.District, Servics.Servic FROM Contracts INNER JOIN Cats ON Contracts.CategorID = Cats.ID INNER JOIN Reps ON Contracts.RepairID = Reps.ID INNER JOIN Districts ON Contracts.DistrictID = Districts.ID INNER JOIN Servics ON Contracts.ServiceID = Servics.ID WHERE Contracts.ID=" + id + "";
            // Создать объект Command.
            SqlCommand cmd = new SqlCommand();

            // Сочетать Command с Connection.
            cmd.Connection = connection;
            cmd.CommandText = query;


            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        ViewBag.q1 = reader[0].ToString();
                        ViewBag.q2 = reader[1].ToString();
                        ViewBag.q3 = reader[2].ToString();
                        ViewBag.q4 = reader[3].ToString();
                    }
                }
            }


            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            ad = db.Contracts.Where(u => u.ID == id).ToList();

            return View(ad);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Contracts model, int id)
        {
            DateTime now = DateTime.Now;

            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            //var userid = db.Clients.Where(u => u.Username == User.Identity.Name).Select(u => u.ID).FirstOrDefault();
      
            if (id != null)
            {
                Contracts con = await db.Contracts.FirstOrDefaultAsync(p => p.ID == id);
                if (con != null)
                {
                    con.DZ = now;
                    con.Client = User.Identity.Name;
                    con.Realtor = con.Client;

                    Servics servaren = db.Servics.Where(u => u.ID == 1).FirstOrDefault();
                    Servics servprod = db.Servics.Where(u => u.ID == 2).FirstOrDefault();
                    Servics servarened = db.Servics.Where(u => u.ID == 3).FirstOrDefault();
                    Servics servproded = db.Servics.Where(u => u.ID == 4).FirstOrDefault();
                    int sn = 3;
                    if (con.Service == servaren) { sn = 3; }
                    if (con.Service == servprod) { sn = 4; }
                    if (con.Service == servarened) { sn = 3; }
                    if (con.Service == servproded) { sn = 4; }

                    Servics serv = db.Servics.Where(u => u.ID == sn).FirstOrDefault();
                    con.Service = serv;

                    db.Contracts.Update(con);
                    await db.SaveChangesAsync();
                }
            }

            return RedirectToAction("Index", "Home");
        }


        List<Contracts> contractes;
        public IActionResult Rent()
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Service.ID == 1).ToList();

            return View("Board",contractes);
           // return View(db.Contracts.Where(u => u.Service.ID == 1).ToList());
            //return View(await db.Contracts.ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Rent(int CatType, int DistType,int ServType,int RepType,int LevelType,int SqType,int TermType, int PriceType)
        {
           
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Categor.ID == CatType).Where(u => u.Service.ID == ServType).Where(u => u.Repair.ID == RepType).Where(u => u.Level >= LevelType).Where(u => u.Sq <= SqType).Where(u => u.Term >= TermType).Where(u => u.Price <= PriceType).ToList();

            return View("Board", contractes);
        }

        public IActionResult Buy()
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Service.ID == 2).ToList();

            return View("Board",contractes);  
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Buy(int CatType, int DistType, int ServType, int RepType, int LevelType, int SqType, int TermType, int PriceType)
        {

            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Categor.ID == CatType).Where(u => u.Service.ID == ServType).Where(u => u.Repair.ID == RepType).Where(u => u.Level >= LevelType).Where(u => u.Sq <= SqType).Where(u => u.Term >= TermType).Where(u => u.Price <= PriceType).ToList();

            return View("Board", contractes);
        }

        public IActionResult Newbuild()
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            DateTime date1 = new DateTime(2000, 7, 20);

            contractes = db.Contracts.Where(u => u.Service.ID == 2).Where(u  => u.DS >= date1).ToList();

            return View("Board", contractes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Newbuild(int CatType, int DistType, int ServType, int RepType, int LevelType, int SqType, int TermType, int PriceType)
        {

            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Categor.ID == CatType).Where(u => u.Service.ID == ServType).Where(u => u.Repair.ID == RepType).Where(u => u.Level >= LevelType).Where(u => u.Sq <= SqType).Where(u => u.Term >= TermType).Where(u => u.Price <= PriceType).ToList();

            return View("Board", contractes);
        }

        public IActionResult Buyapart()
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Service.ID <= 2).Where(u => u.Categor.ID ==1).ToList();

            return View("Board", contractes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Buyapart(int CatType, int DistType, int ServType, int RepType, int LevelType, int SqType, int TermType, int PriceType)
        {

            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Categor.ID == CatType).Where(u => u.Service.ID == ServType).Where(u => u.Repair.ID == RepType).Where(u => u.Level >= LevelType).Where(u => u.Sq <= SqType).Where(u => u.Term >= TermType).Where(u => u.Price <= PriceType).ToList();

            return View("Board", contractes);
        }

        public IActionResult Buyroom()
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Service.ID <= 2).Where(u => u.Categor.ID == 2).ToList();

            return View("Board", contractes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Buyroom(int CatType, int DistType, int ServType, int RepType, int LevelType, int SqType, int TermType, int PriceType)
        {

            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Categor.ID == CatType).Where(u => u.Service.ID == ServType).Where(u => u.Repair.ID == RepType).Where(u => u.Level >= LevelType).Where(u => u.Sq <= SqType).Where(u => u.Term >= TermType).Where(u => u.Price <= PriceType).ToList();

            return View("Board", contractes);
        }

        public IActionResult Buyhouse()
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Service.ID <= 2).Where(u => u.Categor.ID == 3).ToList();

            return View("Board", contractes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Buyhouse(int CatType, int DistType, int ServType, int RepType, int LevelType, int SqType, int TermType, int PriceType)
        {

            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Categor.ID == CatType).Where(u => u.Service.ID == ServType).Where(u => u.Repair.ID == RepType).Where(u => u.Level >= LevelType).Where(u => u.Sq <= SqType).Where(u => u.Term >= TermType).Where(u => u.Price <= PriceType).ToList();

            return View("Board", contractes);
        }

        public IActionResult Buyland()
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Service.ID <= 2).Where(u => u.Categor.ID == 4).ToList();

            return View("Board", contractes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Buyland(int CatType, int DistType, int ServType, int RepType, int LevelType, int SqType, int TermType, int PriceType)
        {

            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Categor.ID == CatType).Where(u => u.Service.ID == ServType).Where(u => u.Repair.ID == RepType).Where(u => u.Level >= LevelType).Where(u => u.Sq <= SqType).Where(u => u.Term >= TermType).Where(u => u.Price <= PriceType).ToList();

            return View("Board", contractes);
        }

        public IActionResult Buygarage()
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Service.ID <= 2).Where(u => u.Categor.ID == 5).ToList();

            return View("Board", contractes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Buygarage(int CatType, int DistType, int ServType, int RepType, int LevelType, int SqType, int TermType, int PriceType)
        {

            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Categor.ID == CatType).Where(u => u.Service.ID == ServType).Where(u => u.Repair.ID == RepType).Where(u => u.Level >= LevelType).Where(u => u.Sq <= SqType).Where(u => u.Term >= TermType).Where(u => u.Price <= PriceType).ToList();

            return View("Board", contractes);
        }

        public IActionResult Buycommerce()
        {
            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Service.ID <= 2).Where(u => u.Categor.ID == 6).ToList();

            return View("Board", contractes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Buycommerce(int CatType, int DistType, int ServType, int RepType, int LevelType, int SqType, int TermType, int PriceType)
        {

            if (db == null) db = new RamunisrealtNET.Models.Ramunisrealt();

            contractes = db.Contracts.Where(u => u.Categor.ID == CatType).Where(u => u.Service.ID == ServType).Where(u => u.Repair.ID == RepType).Where(u => u.Level >= LevelType).Where(u => u.Sq <= SqType).Where(u => u.Term >= TermType).Where(u => u.Price <= PriceType).ToList();

            return View("Board", contractes);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
