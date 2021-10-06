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
                return htmlString;
        }
        public StringBuilder StringToStringBuilder(Invoice model)
        {
            var builder = new StringBuilder();
            builder.AppendLine(model.Id.ToString());
            builder.AppendLine(model.User.FirstName + " " + model.User.LastName);
            builder.AppendLine(model.SchoolId.ToString());
            builder.AppendLine(DateTime.Now.ToShortDateString());
            builder.AppendLine(model.Amount.ToString());

            return builder;

        }
    }
}
