using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace product__easy_learn_
{
    public class UploadFile
    {
        private readonly IWebHostEnvironment _webhostenviroment;
        public UploadFile(IWebHostEnvironment webHostEnvironment)
        {
            _webhostenviroment = webHostEnvironment;
        }
        public string upload(IFormFile file)
        {
            if (file == null) return "";
            var path = _webhostenviroment.WebRootPath + "\\images\\teacher\\" + file.FileName;// توی پوشه images توی wwwroot و پوشه تیچر
            using var f = System.IO.File.Create(path);//این create ربطی به crate پروژه نداره و مربوط به کراد نیست و با ان فرق داره.
            file.CopyTo(f);
            return file.FileName;
        }
        public string upload1(IFormFile file)
        {
            if (file == null) return "";
            var path = _webhostenviroment.WebRootPath + "\\images\\course1\\" + file.FileName;// توی پوشه images توی wwwroot و پوشه تیچر
            using var f = System.IO.File.Create(path);//این create ربطی به crate پروژه نداره و مربوط به کراد نیست و با ان فرق داره.
            file.CopyTo(f);
            return file.FileName;
        }
        public string uploadVideo(IFormFile file)
        {
            if (file == null) return "";
            var path = _webhostenviroment.WebRootPath + "\\videos\\course\\" + file.FileName;// توی پوشه images توی wwwroot و پوشه تیچر
            using var f = System.IO.File.Create(path);//این create ربطی به crate پروژه نداره و مربوط به کراد نیست و با ان فرق داره.
            file.CopyTo(f);
            path = path.Split("wwwroot")[1];
            return file.FileName;
        }
    }
}
