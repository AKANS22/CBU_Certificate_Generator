//using System.Drawing;

//namespace CBU_Certificate_Generator.Services
//{
//    public class CertificateService2
//    {
//        public async Task<IFormFile> GenerateCertificate(string fullNmae, string courseName, string date, string base64Image)
//        {
//            string[] staticText1 = new string[]
//            {
//                "Certificate of Completion",
//                "This is to certify that on",
//                "successfully completed",
//                "By completing this course",
//                "you have equipped yourself with the knowledge and skills to enhance your carrer",
//                "prospects and foster growth"
//            };


      
//            // Decode the base64 input image
//            byte[] imageData = Convert.FromBase64String(base64Image);
//            using (MemoryStream memoryStream = new MemoryStream(imageData))
//            using (Bitmap image = new Bitmap(memoryStream))
//            {
//                using (Graphics graphics = Graphics.FromImage(image))
//                {
//                    // Choose a font and brush for the text
//                    Font staticFontHead = new Font("Calibri", 98, FontStyle.Bold);
//                    Brush brush = new SolidBrush(Color.White);
//                    Font staticFontBody = new Font("Calibri", 49, FontStyle.Regular);
//                    Font staticFontfullName = new Font("Calibri", 98, FontStyle.Regular);
//                    Font staticFontcourseName = new Font("Calibri", 72, FontStyle.Regular);
//                    Font staticFontdate = new Font("Calibri", 49, FontStyle.Regular);




//                //    // Calculate text size and position
//                //    SizeF textSize = graphics.MeasureString(text, font);
//                //    float x = (image.Width - textSize.Width) / 2;
//                //    float y = (image.Height - textSize.Height) / 2;

//                //    // Draw the text on the image
//                //    graphics.DrawString(text, font, brush, x, y);
//                //}

//                //// Convert the modified image to base64
//                //return ConvertImageToBase64(image);
//            }
//        }
//    }
//}
