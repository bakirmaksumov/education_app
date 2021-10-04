using PdfSharpCore.Pdf.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VetCV.HtmlRendererCore.PdfSharpCore;
//using TheArtOfDev.HtmlRenderer.PdfSharp;

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
                config.PageSize = PdfSharpCore.PageSize.A4;
                config.SetMargins(30);

                var pdf = PdfGenerator.GeneratePdf(htmlContent, config);
                int pages = pdf.PageCount;
                pdf.Save(memory, false);
                result = memory.ToArray();
            }
            return result;
        }
    }
}
