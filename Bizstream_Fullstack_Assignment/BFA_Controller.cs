using System;
using ContactUS.ViewModel;
using System.Net.Mail;

namespace ContactUS.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactViewModel vm)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    MailMessage msz = new MailMessage();
                    msz.From = new MailAddress(vm.Email); //Email which you are getting from contact us page 
                    msz.To.Add("emailaddress@mail.com"); //Where mail will be sent 
                    msz.Body = vm.Message;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.mail.com";
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential
					("youremailid@mail.com", "password");
                    smtp.EnableSsl = true;
                    smtp.Send(msz);
                    ModelState.Clear();
                    ViewBag.Message = "Thank you for Contacting us ";
                }
                catch(Exception ex )
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
                }              
            }
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}