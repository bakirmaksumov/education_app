using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.PdfSharp;
//using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace EducationApplication.Common
{
    public static class PdfConverter
    {
        public static Byte[] PdfSharpConverter(string htmlContent)
        {
            Byte[] result = null;
            var document = new PdfDocument();
            PdfGenerator.AddPdfPages(document, htmlContent, PdfSharpCore.PageSize.A4);
            using (var memory = new MemoryStream())
            {
                document.Save(memory);
                result = memory.ToArray();
                //var config = new PdfGenerateConfig();
                //config.PageSize = PdfSharpCore.PageSize.A4;
                //config.SetMargins(30);

                //var pdf = PdfGenerator.GeneratePdf(htmlContent, config);
                //int pages = pdf.PageCount;
                //pdf.Save(memory);
                //result = memory.ToArray();
            }
            return result;
        }
    }
}
