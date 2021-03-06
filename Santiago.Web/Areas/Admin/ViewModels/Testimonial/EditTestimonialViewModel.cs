﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Santiago.Web.Areas.Admin.ViewModels.Testimonial
{
    public class EditTestimonialViewModel
    {
        [Display(Name = "ID отзыва")]
        public int Id { get; set; }

        [MaxLength(256, ErrorMessage = "Длина имени автора не должна превышать {1} символов")]
        [RegularExpression(@"[^<>]+", ErrorMessage = "Введены недопустимые символы")]
        [Required(ErrorMessage = "Введите имя автора")]
        [Display(Name = "Имя автора", Prompt = "Имя автора")]
        public string AuthorName { get; set; }

        [Required(ErrorMessage = "Необходимо загрузить фотографию автора")]
        [Display(Name = "Фотография автора")]
        public int AuthorImageFileId { get; set; }

        [AllowHtml]
        [Required(ErrorMessage = "Введите текст отзыва")]
        [Display(Name = "Текст", Prompt = "Текст отзыва")]
        public string Text { get; set; }

        [Display(Name = "Дата создания")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Дата последнего изменения")]
        public DateTime LastModifiedDate { get; set; }
    }
}