
//using GISNA.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace GISNA.Controllers
//{
//    public class FormController : Controller
//    {
//        public IActionResult Index(validateForm va)
//        {
//            ViewBag.Name = va.Name;
//            ViewBag.Email= va.Email;
//            return View();
//        }
//    }
//}


//using GISNA.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace GISNA.Controllers
//{
//    public class FormController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }
//        public ActionResult Upload()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult Upload(IFormFile myfile)
//        {
//            try
//            {
//                string file_name = myfile.FileName;
//                file_name = Path.GetFileName(file_name);
//                string upload_folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot//uploads");
//                if (!Directory.Exists(upload_folder))
//                {
//                    Directory.CreateDirectory(upload_folder);
//                }
//                string upload_path = Path.Combine(upload_folder, file_name);

//                if (System.IO.File.Exists(upload_path))
//                {
//                    ViewBag.UploadStatus += file_name + "-Already Exists";
//                    Random file_number = new Random();
//                    file_name = file_number.Next().ToString() + file_name;
//                    upload_path = Path.Combine(upload_folder, file_name);
//                }
//                else
//                {
//                    ViewBag.UploadStatus += myfile.FileName + "uploaded successfully\n";
//                }
//                var UploadStream = new FileStream(upload_path, FileMode.Create);
//            }
//            catch (Exception ex)
//            {
//                ViewBag.UploadStatus += $"Unable to upload files{ex.Message}";
//            }
//            return View();
//        }
//    }
//}



using GISNA.Models;
using Microsoft.AspNetCore.Mvc;

namespace GISNA.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(List<IFormFile> myfiles)
        {
            ViewBag.UploadStatus = "Number of files uploaded!";
            if (myfiles.Count == 0)
            {
                ViewBag.UploadStatus = "No files selected";
            }
            try
            {
                if (myfiles.Count > 0)
                {
                    ViewBag.UploadStatus += myfiles.Count.ToString() + "";
                    foreach(var file in myfiles)
                    {
                        string file_name = file.FileName;
                        file_name = Path.GetFileName(file_name);
                        string upload_folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot//uploads");
                        if (!Directory.Exists(upload_folder))
                        {
                            Directory.CreateDirectory(upload_folder);
                        }
                        string upload_path = Path.Combine(upload_folder, file_name);
                        if (System.IO.File.Exists(upload_path))
                        {
                            ViewBag.UploadStatus += file_name + "-Already Exists";
                            Random file_number = new Random();
                            file_name = file_number.Next(10, 100).ToString() + file_name;
                            upload_path = Path.Combine(upload_folder, file_name);
                        }
                        else
                        {
                            ViewBag.UploadStatus += file_name + "Uploaded Successfully";
                        }
                        var uploadstream = new FileStream(upload_path, FileMode.Create);
                        file.CopyToAsync(uploadstream);
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.UploadStatus += $"unable to upload files{ex.Message}";
            }
            return View();
        }
    }
}