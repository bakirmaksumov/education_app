using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace EducationApplication.Common
{
    public static class PdfConverter
    {
        public static Byte[] PdfSharpConverter(string htmlContent)
        {
            Byte[] result = null;
            using (var memory = new MemoryStream())
            {
                var config = new PdfGenerateConfig();
                config.PageSize = PdfSharp.PageSize.A4;
                config.SetMargins(30);

                var pdf = PdfGenerator.GeneratePdf(htmlContent, config);
                pdf.Save(memory);
                result = memory.ToArray();
            }
            return result;
        }
    }
}
