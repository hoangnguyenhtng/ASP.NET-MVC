using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace quanlysv.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên

        [Required(ErrorMessage = "Tên bắt buộc phải được nhập")]
        [RegularExpression(@"^[A-Za-z\s]{4,100}$")]
        [StringLength(100, MinimumLength = 4)]
        public string? Name { get; set; } //Họ tên

        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@gmail\.com")]
        public string? Email { get; set; } //Email

        [Required(ErrorMessage = "Mật khẩu bắt buộc phải được nhập")]
        [StringLength(100, MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*()_+])[A-Za-z\d!@#$%^&*()_+]{8,}$")]
        public string? Password { get; set; }//Mật khẩu

        [Required]
        public Branch? Branch { get; set; }//Ngành học

        [Required(ErrorMessage = "Điểm bắt buộc phải được nhập")] 
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0")]
        public string? Point { get; set; } //Điểm

        [Required(ErrorMessage = "Giới tính bắt buộc phải được nhập")]
        public Gender? Gender { get; set; }//Giới tính

        public bool IsRegular { get; set; }//Hệ: true-chính quy, false-phi chính quy

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Địa chỉ bắt buộc phải được nhập")]
        public string? Address { get; set; }//Địa chỉ

        [Required(ErrorMessage = "Ngày tháng năm sinh bắt buộc phải được nhập")]
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }//Ngày sinh
    }
}
