using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.AboutDto
{
    public class AboutAddDto
    {
        [Required(ErrorMessage = "Lütfen Etiket-1'i yazınız")]
        public string Title1 { get; set; }

        [Required(ErrorMessage = "Lütfen Etiket-2'i yazınız")]
        public string Title2 { get; set; }

        [Required(ErrorMessage = "Lütfen Açıklamayı  yazınız")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Puanını yazınız")]
        public int RoomCount { get; set; }
        [Required(ErrorMessage = "Lütfen Kadro Puanını yazınız")]
        public int StaffCount { get; set; }
        [Required(ErrorMessage = "Lütfen Müşteri Puanını yazınız")]
        public int CustomerCount { get; set; }
    }
}
