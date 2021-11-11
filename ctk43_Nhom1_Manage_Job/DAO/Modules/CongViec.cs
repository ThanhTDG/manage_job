using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctk43_Nhom1_Manage_Job.DAO.Modules
{
	 public class CongViec
	 {
		  private int iD;
		  private string ten;
		  private DateTime thoiGianBD;
		  private DateTime thoiGianKT;
		  private string trangThai;
		  private int tienDo;
		  private int mucDo;
		  private int iDChuDe;
		  private string email;
		  public int ID { get => iD; set => iD = value; }
		  public string Ten { get => ten; set => ten = value; }
		  public DateTime ThoiGianBD { get => thoiGianBD; set => thoiGianBD = value; }
		  public string TrangThai { get => trangThai; set => trangThai = value; }
		  public int TienDo { get => tienDo; set => tienDo = value; }
		  public int MucDo { get => mucDo; set => mucDo = value; }
		  public int IDChuDe { get => iDChuDe; set => iDChuDe = value; }
		  public string Email { get => email; set => email = value; }
		  public DateTime ThoiGianKT { get => thoiGianKT; set => thoiGianKT = value; }

		  public CongViec()
		  {

		  }

		  public CongViec(int iD, string ten, DateTime thoiGianBD, DateTime thoiGianKT, string trangThai, int tienDo, int mucDo, int iDChuDe, string email)
		  {
				this.iD = iD;
				this.ten = ten;
				this.thoiGianBD = thoiGianBD;
				this.thoiGianKT = thoiGianKT;
				this.trangThai = trangThai;
				this.tienDo = tienDo;
				this.mucDo = mucDo;
				this.iDChuDe = iDChuDe;
				this.email = email;
		  }
	 }
}
