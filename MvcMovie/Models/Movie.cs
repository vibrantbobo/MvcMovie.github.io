using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; } //电影id
        [Display(Name = "电影名称")]
        public string Title { get; set; } //电影名称
        [Display(Name = "上映日期")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } //上映日期
        [Display(Name = "电影类型")]
        public string Genre { get; set; } //电影类型
        [Display(Name = "票价")]
        public decimal Price { get; set; } //电影票价
    }
}
