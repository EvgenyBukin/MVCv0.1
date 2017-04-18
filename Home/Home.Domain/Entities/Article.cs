using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Home.Domain.Entities
{
    public class Article
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int ArticleId { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Пожалуйста, введите название")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Пожалуйста, введите описание")]
        public string Description { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Текст")]
        [Required(ErrorMessage = "Пожалуйста, введите основной текст")]
        public string ArticleTxt { get; set; }

        [Display(Name = "Изображение_1")]
        [Required(ErrorMessage = "Пожалуйста, введите путь к изображению")]
        public string Img1 { get; set; }

        [Display(Name = "Видео")]
        [Required(ErrorMessage = "Пожалуйста, введите путь к видео")]
        public string Img2 { get; set; }

        [Display(Name = "Дата")]
        [Required(ErrorMessage = "Пожалуйста, введите дату")]
        public string Data { get; set; }

        [Display(Name = "Автор")]
        [Required(ErrorMessage = "Пожалуйста, введите автора")]
        public string Author { get; set; }

        [Display(Name = "Изображение_2")]
        [Required(ErrorMessage = "Пожалуйста, введите путь к изображению")]
        public string Img3 { get; set; }
    }
}
