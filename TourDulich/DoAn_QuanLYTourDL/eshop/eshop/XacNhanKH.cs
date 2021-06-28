using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eshop
{
    public partial class XacNhanKH : Form
    {
        public XacNhanKH()
        {
            InitializeComponent();
        }
        TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            KHACH_HANG ten = db.KHACH_HANG.Find(txt_makh.Text);
            if (ten.TenKH==FrTrangChu.tenkh)
            {
                MessageBox.Show("Xác Nhận Thành Công");
                if (!KhachSan.textks.Equals(""))
                {
                    db.KHACH_SAN.Add(new KHACH_SAN
                          {
                              MaKS = "KS" + FrTrangChu.maks(),
                              TenKS = KhachSan.vitri,
                              NgayNhanPhong = KhachSan.ngaynhan,
                              NgayTraPhong = KhachSan.ngaytra,
                              SoPhong = int.Parse(KhachSan.sophong),
                              SoNgayO = int.Parse(KhachSan.sodem),
                              KhachTrenMotPhong = int.Parse(KhachSan.nguoitrenphong),
                              MaKH = txt_makh.Text,
                              tongtien = KhachSan.tongtien
                          });
                    db.HOA_DON.Add(new HOA_DON
                    {
                        MaHD = "HD" + FrTrangChu.sohd(),
                        MaKH = txt_makh.Text,
                        SoLuongVe = 1,
                        Loaive = KhachSan.loaive,
                        NgayLap = DateTime.Now,
                        TongTien = KhachSan.tongtien
                    });
                    db.SaveChanges();

                    MessageBox.Show("Đặt Phòng Thành Công");
                    KhachSan.textks = "";
                }
                if (!DuaDoanSanBay.textsb.Equals(""))
                {
                    int count1 = db.DUA_DOAN_SAN_BAY.Where(ma => ma.MaSB == DuaDoanSanBay.masb).Where(makh => makh.MaKH == txt_makh.Text).Count();
                    if (count1 == 1)
                        MessageBox.Show("Bạn Đã đặt vé này rồi");
                    else
                    {
                        db.DUA_DOAN_SAN_BAY.Add(new DUA_DOAN_SAN_BAY
                        {
                            MaSB = DuaDoanSanBay.masb,
                            TuDiaDiem = DuaDoanSanBay.tudiadiem,
                            DenDiaDiem = DuaDoanSanBay.dendiadiem,
                            NgayDon = DuaDoanSanBay.ngaydon,
                            GioDoan = DuaDoanSanBay.giodon,
                            MaKH = txt_makh.Text,
                            tongtien = DuaDoanSanBay.tienthue
                        });
                        db.HOA_DON.Add(new HOA_DON
                        {
                            MaHD = "HD" + FrTrangChu.sohd(),
                            MaKH = txt_makh.Text,
                            SoLuongVe = 1,
                            Loaive = DuaDoanSanBay.loaive,
                            NgayLap = DateTime.Now,
                            TongTien = DuaDoanSanBay.tienthue
                        });
                        db.SaveChanges();
                        MessageBox.Show("Đặt Xe Thành Công");
                        DuaDoanSanBay.textsb = "";
                    }
                }
                if (!VeMayBay.textve.Equals(""))
                {
                    KHACH_HANG kh = db.KHACH_HANG.Find(txt_makh.Text);
                    db.VE_MAY_BAY.Add(new VE_MAY_BAY
                    {
                        MaVe = "MV" + FrTrangChu.sove(),
                        MaKH = txt_makh.Text,
                        TenKH = kh.TenKH,
                        DiemKhoiHanh = VeMayBay.diemdi,
                        DiemDen = VeMayBay.diemden,
                        NgayDi = VeMayBay.ngaydi,
                        NgayVe = VeMayBay.ngayve,
                        SoHanhKhach = int.Parse(VeMayBay.soluongkhach),
                        HangGhe = VeMayBay.hangghe,
                        Tongtien = VeMayBay.tongtien
                    });
                    db.HOA_DON.Add(new HOA_DON
                    {
                        MaHD = "HD" + FrTrangChu.sohd(),
                        MaKH = txt_makh.Text,
                        SoLuongVe = 1,
                        Loaive = VeMayBay.loaive,
                        NgayLap = DateTime.Now,
                        TongTien = VeMayBay.tongtien
                    });
                    db.SaveChanges();
                    MessageBox.Show("Đặt Vé Thành Công");
                    VeMayBay.textve = "";
                }
                if (!frTour.textdd.Equals(""))
                {
                    db.DATTOURs.Add(new DATTOUR
                    {
                        MAVET = "MVT" + FrTrangChu.mavt(),
                        TENT = frTour.tendd,
                        TIENT = int.Parse(frTour.tien),
                        MaKH = txt_makh.Text
                    });
                    db.HOA_DON.Add(new HOA_DON
                    {
                        MaHD = "HD" + FrTrangChu.sohd(),
                        MaKH = txt_makh.Text,
                        SoLuongVe = 1,
                        Loaive = frTour.loait,
                        NgayLap = DateTime.Now,
                        TongTien = int.Parse(frTour.tien)
                    });
                    db.SaveChanges();
                    MessageBox.Show("Đặt Tour Thành Công");
                    frTour.textdd = "";
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản của bạn");
            }
        }
    }
}
