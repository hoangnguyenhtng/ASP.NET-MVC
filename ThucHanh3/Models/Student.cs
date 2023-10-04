using System.ComponentModel.DataAnnotations;

namespace ThongTinSinhVien.Models
{
	public class Student
	{
		public int Id { get; set; }//Mã sinh viên

		[Required]
		[StringLength(100, MinimumLength = 4, ErrorMessage = "Tên phải có ít nhất 4 ký tự và tối đa 100 ký tự.")]
		public string? Name { get; set; } //Họ tên

		[Required(ErrorMessage = "Email bắt buộc phải được nhập!")]
		[RegularExpression(@"^[a-zA-Z0-9._%+-]+@gmail\.com$",
		ErrorMessage = "Địa chỉ email phải có đuôi gmail.com.")]
		public string? Email { get; set; } //Email

		[StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có ít nhất 8 ký tự.")]
		[Required(ErrorMessage = "Mật khẩu bắt buộc phải được nhập")]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&*()])[A-Za-z\d@#$%^&*()]+$",
		ErrorMessage = "Mật khẩu phải chứa ít nhất một ký tự viết hoa, viết thường, chữ số và ký tự đặc biệt.")]
		public string? Password { get; set; }//Mật khẩu

		[Required]
		public Branch? Branch { get; set; }//Ngành học

		[Required]
		public Gender? Gender { get; set; }//Giới tính
		public bool IsRegular { get; set; }//Hệ: true-chính qui, false-phi cq

		[DataType(DataType.MultilineText)]
		[Required]
		public string? Address { get; set; }//Địa chỉ

		[Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
		[DataType(DataType.Date)]
		[Required]
		public DateTime DateOfBorth { get; set; }//Ngày sinh

		[Required(ErrorMessage = "Điểm bắt buộc phải được nhập.")]
		[Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0.")]
		public double Mark { get; set; }
	}
}