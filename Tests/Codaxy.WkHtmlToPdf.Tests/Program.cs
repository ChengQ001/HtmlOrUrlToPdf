using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace Codaxy.WkHtmlToPdf.Tests
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("开始噶事" + DateTime.Now);
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<p>");
            sb.AppendFormat("	<table style=\"width:100%;\" cellpadding=\"2\" cellspacing=\"0\" border=\"1\" bordercolor=\"#000000\">");
            sb.AppendFormat("		<tbody>");
            sb.AppendFormat("			<tr>");
            sb.AppendFormat("				<td>");
            sb.AppendFormat("					111");
            sb.AppendFormat("				</td>");
            sb.AppendFormat("				<td>");
            sb.AppendFormat("					111111111111111");
            sb.AppendFormat("				</td>");
            sb.AppendFormat("			</tr>");
            sb.AppendFormat("			<tr>");
            sb.AppendFormat("				<td>");
            sb.AppendFormat("					撒打算");
            sb.AppendFormat("				</td>");
            sb.AppendFormat("				<td>");
            sb.AppendFormat("					阿萨德阿萨德");
            sb.AppendFormat("				</td>");
            sb.AppendFormat("			</tr>");
            sb.AppendFormat("			<tr>");
            sb.AppendFormat("				<td>");
            sb.AppendFormat("					阿萨德撒的");
            sb.AppendFormat("				</td>");
            sb.AppendFormat("				<td>");
            sb.AppendFormat("					撒的撒的&nbsp;");
            sb.AppendFormat("				</td>");
            sb.AppendFormat("			</tr>");
            sb.AppendFormat("		</tbody>");
            sb.AppendFormat("	</table>");
            sb.AppendFormat("<br />");
            sb.AppendFormat("<span id=\"__kindeditor_bookmark_start_1__\"></span>");
            sb.AppendFormat("</p>");

            Console.InputEncoding = Encoding.UTF8;

            PdfConvert.Environment.Debug = false;
            //PdfConvert.ConvertHtmlToPdf(new PdfDocument { Url = "http://www.ichengq.xyz" }, new PdfOutput
            //{
            //    OutputFilePath = "Ichengq.pdf"
            //});

            PdfConvert.ConvertHtmlToPdf(new PdfDocument
            {
                Url = "http://vip.vsread.com/book/detail/107408",
                HeaderLeft = "[title]",
                HeaderRight = "[date] [time]",
                FooterCenter = "Page [page] of [topage]",
                FooterFontSize = "10",
                HeaderFontSize = "10",
                HeaderFontName = "Comic Sans MS",
                FooterFontName = "Helvetica",


            }, new PdfOutput
            {
                OutputFilePath = "Ichengq1.pdf"
            });
            if (File.Exists(System.AppDomain.CurrentDomain.BaseDirectory+"Ichengq2.pdf"))
            {
                File.Delete(System.AppDomain.CurrentDomain.BaseDirectory + "Ichengq2.pdf");
            }
            PdfConvert.ConvertHtmlToPdf(
                new PdfDocument
                {
                    Html = sb.ToString(),
                    HeaderLeft = "[title]",
                    HeaderRight = "[date] [time]",
                    FooterCenter = "Page [page] of [topage]",
                    FooterFontSize = "10",
                    HeaderFontSize = "10",
                    HeaderFontName = "Comic Sans MS",
                    FooterFontName = "Helvetica",


                },
                new PdfOutput { OutputFilePath = "Ichengq2.pdf" }
            );

            //PdfConvert.ConvertHtmlToPdf(
            //    new PdfDocument { Html = "<html><h1>測試</h1></html>" },
            //    new PdfOutput { OutputFilePath = "Ichengq3.pdf" }
            //);
            Console.WriteLine("结束" + DateTime.Now);

        
            Console.ReadKey();

        
        }
    }
}
