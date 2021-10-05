using EducationApplication.Model.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Common.Methods
{
    public class InvoiceBulderString
    {

        public string ReadHtmlFile()
        {
            string htmlString = String.Empty;
            string pathToHtmlFile = @"C:\Users\MrFree\Desktop\epam\Epam\education_last\education_app\EducationApplication\wwwroot\html\invoice.html";
            using (FileStream fs = File.Open(pathToHtmlFile, FileMode.Open, FileAccess.ReadWrite))
            {
                using (var sr = new StreamReader(fs))
                {
                    htmlString = sr.ReadToEnd();
                }
            }

            htmlString = "<html><head><title></title></head>< body style = 'padding:20px' ><div>itemcontent</div></ body ></html>";
                return htmlString;
        }
        public StringBuilder StringToStringBuilder(Invoice model)
        {
            var builder = new StringBuilder();
            builder.Append("<b>"+model.Id.ToString()+"</b>");
            //builder.Append("<b>" + model.User.FirstName + " " + model.User.LastName + "</b>");
            //builder.Append("<b>" + model.SchoolId.ToString() + "</b>");
            //builder.Append("<b>" + DateTime.Now.ToShortDateString() + "</b>");
            //builder.Append("<b>" + model.Amount.ToString() + "</b>");

            return builder;

        }
    }
}
