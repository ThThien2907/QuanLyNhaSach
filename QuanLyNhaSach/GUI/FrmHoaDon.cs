using QuanLyNhaSach.BLL;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Drawing2D;

namespace QuanLyNhaSach.GUI
{
    public partial class FrmHoaDon : Form
    {
        BLLHoaDon BLLHoaDon = new BLLHoaDon();
        BLLSach BLLSach = new BLLSach();
        BLLChiTietHoaDon BLLChiTietHoaDon = new BLLChiTietHoaDon();
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        private bool isUpdate = false;
        private bool isAdd = false;
        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            CreateLsvHoaHon();
            CreateLsvSach();
            CreateLsvChiTietHD();

            LoadDataHoaDon();
            LoadDataSach();

            SetDefault();
        }
        private void CreateLsvHoaHon()
        {
            this.lsvHoaDon.Clear();
            this.lsvHoaDon.Items.Clear();
            this.lsvHoaDon.Columns.Add("MÃ HÓA ĐƠN", 140);
            this.lsvHoaDon.Columns.Add("TÊN KHÁCH HÀNG", 200);
            this.lsvHoaDon.Columns.Add("NGÀY LẬP", 150);
            this.lsvHoaDon.Columns.Add("TỔNG TIỀN", 170);
            this.lsvHoaDon.GridLines = true;
            this.lsvHoaDon.FullRowSelect = true;
        }
        private void CreateLsvSach()
        {
            this.lsvSach.Clear();
            this.lsvSach.Items.Clear();
            this.lsvSach.Columns.Add("MÃ SÁCH", 90);
            this.lsvSach.Columns.Add("TÊN SÁCH", 200);
            this.lsvSach.Columns.Add("SỐ LƯỢNG", 90);
            this.lsvSach.Columns.Add("GIÁ BÌA", 70);
            this.lsvSach.Columns.Add("TÊN TÁC GIẢ", 170);
            this.lsvSach.Columns.Add("THỂ LOẠI", 90);
            this.lsvSach.Columns.Add("NHÀ XUẤT BẢN", 170);
            this.lsvSach.GridLines = true;
            this.lsvSach.FullRowSelect = true;
        }
        private void CreateLsvChiTietHD()
        {
            this.lsvChiTietHoaDon.Clear();
            this.lsvChiTietHoaDon.Items.Clear();
            this.lsvChiTietHoaDon.Columns.Add("MÃ HÓA ĐƠN", 120);
            this.lsvChiTietHoaDon.Columns.Add("MÃ SÁCH", 90);
            //this.lsvChiTietHoaDon.Columns.Add("TÊN SÁCH", 200);
            this.lsvChiTietHoaDon.Columns.Add("SỐ LƯỢNG", 100);
            this.lsvChiTietHoaDon.Columns.Add("GIÁ TIỀN", 110);
            this.lsvChiTietHoaDon.Columns.Add("THÀNH TIỀN", 180);
            this.lsvChiTietHoaDon.GridLines = true;
            this.lsvChiTietHoaDon.FullRowSelect = true;
        }
        private void LoadDataHoaDon()
        {
            DataTable dataTable = new DataTable();
            dataTable = BLLHoaDon.GetDataHoaDon();
            lsvHoaDon.Items.Clear();
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                this.lsvHoaDon.Items.Add(row["MAHOADON"].ToString());
                this.lsvHoaDon.Items[i].SubItems.Add(row["TENKHACHHANG"].ToString());
                this.lsvHoaDon.Items[i].SubItems.Add(row["NGAYLAP"].ToString());
                this.lsvHoaDon.Items[i].SubItems.Add(row["TONGTIEN"].ToString());
                i++;
            }
        }
        private void LoadDataSach()
        {
            DataTable dataTable = new DataTable();
            dataTable = BLLSach.GetDataSach();
            int i = 0;
            lsvSach.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                this.lsvSach.Items.Add(row["MASACH"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENSACH"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["SOLUONG"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["GIABAN"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENTG"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENLOAISACH"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENNHAXUATBAN"].ToString());
                i++;
            }
        }
        private void LoadDataChiTietHoaDon()
        {
            DataTable dataTable = new DataTable();
            dataTable = BLLChiTietHoaDon.GetDataChiTietHoaDon(txbMaHD.Text);
            int i = 0;
            lsvChiTietHoaDon.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                this.lsvChiTietHoaDon.Items.Add(row["MAHOADON"].ToString());
                this.lsvChiTietHoaDon.Items[i].SubItems.Add(row["MASACH"].ToString());
                this.lsvChiTietHoaDon.Items[i].SubItems.Add(row["SOLUONG"].ToString());
                this.lsvChiTietHoaDon.Items[i].SubItems.Add(row["GIATIEN"].ToString());
                this.lsvChiTietHoaDon.Items[i].SubItems.Add(row["THANHTIEN"].ToString());
                i++;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvHoaDon.SelectedItems.Count <= 0)
            {
                btnCTHD.Enabled = false;
                btnDeleteHD.Enabled = false;
                btnXuatHD.Enabled = false;
            }
            else
            {
                btnCTHD.Enabled = true;
                btnDeleteHD.Enabled = true;
                btnXuatHD.Enabled = true;
                ListViewItem item = lsvHoaDon.SelectedItems[0];
                txbMaHD.Text = lsvHoaDon.SelectedItems[0].Text;
                txbTenKH.Text = lsvHoaDon.SelectedItems[0].SubItems[1].Text;
                dtpNgayLap.Value = DateTime.Parse(lsvHoaDon.SelectedItems[0].SubItems[2].Text);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                if (nbudSoLuong.Value > 0)
                {
                    if (lsvSach.SelectedItems.Count > 0)
                    {
                        ListViewItem itemSach = lsvSach.SelectedItems[0];
                        int soLuongSach = BLLSach.GetSoLuongSach(itemSach.Text);
                        if (soLuongSach < int.Parse(nbudSoLuong.Value.ToString()))
                        {
                            MessageBox.Show("Vượt quá số lượng sách trong kho!!!");
                        }
                        else
                        {
                            ListViewItem itemChiTietHD = new ListViewItem();

                            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                            chiTietHoaDon.MAHOADON = txbMaHD.Text;
                            chiTietHoaDon.MASACH = itemSach.Text;
                            chiTietHoaDon.SOLUONG = int.Parse(nbudSoLuong.Value.ToString());
                            chiTietHoaDon.GIATIEN = int.Parse(itemSach.SubItems[3].Text);
                            chiTietHoaDon.THANHTIEN = chiTietHoaDon.SOLUONG * chiTietHoaDon.GIATIEN;

                            bool checkSachTrongHD = false;

                            foreach (ListViewItem item in lsvChiTietHoaDon.Items)
                            {
                                if (itemSach.Text.Trim() == item.SubItems[1].Text.Trim())
                                {
                                    chiTietHoaDon.SOLUONG = int.Parse(item.SubItems[2].Text) + int.Parse(nbudSoLuong.Value.ToString());
                                    chiTietHoaDon.THANHTIEN = chiTietHoaDon.SOLUONG * chiTietHoaDon.GIATIEN;
                                    checkSachTrongHD = true;
                                    break;
                                }
                            }

                            if (checkSachTrongHD)
                            {
                                if (BLLChiTietHoaDon.UpdateChiTietHoaDon(chiTietHoaDon))
                                {
                                    BLLSach.UpdateSoLuongSach(itemSach.Text, soLuongSach - int.Parse(nbudSoLuong.Value.ToString()));
                                    LoadDataChiTietHoaDon();
                                    LoadDataSach();
                                    btnAddCTHD.Enabled = true;
                                    btnSaveCTHD.Enabled = false;

                                    ActiveSachPanel(false);
                                }
                            }
                            else
                            {
                                if (BLLChiTietHoaDon.AddChiTietHoaDon(chiTietHoaDon))
                                {
                                    BLLSach.UpdateSoLuongSach(itemSach.Text, soLuongSach - int.Parse(nbudSoLuong.Value.ToString()));
                                    LoadDataChiTietHoaDon();
                                    LoadDataSach();
                                    btnAddCTHD.Enabled = true;
                                    btnSaveCTHD.Enabled = false;

                                    ActiveSachPanel(false);
                                }

                            }
                        }
                    }
                    else MessageBox.Show("Vui lòng chọn sách !!!");
                }
                else MessageBox.Show("Vui lòng chọn số lượng !!!");
            }
            else if (isUpdate)
            {
                if (nbudSoLuong.Value > 0)
                {
                    if (lsvChiTietHoaDon.SelectedItems.Count <= 0) return;

                    ListViewItem cthdItem = lsvChiTietHoaDon.SelectedItems[0];

                    int soLuongSach = BLLSach.GetSoLuongSach(cthdItem.SubItems[1].Text);
                    int newSoLuong = int.Parse(nbudSoLuong.Value.ToString());
                    int oldSoLuong = int.Parse(cthdItem.SubItems[2].Text);

                    ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                    chiTietHoaDon.MAHOADON = cthdItem.Text;
                    chiTietHoaDon.MASACH = cthdItem.SubItems[1].Text;
                    chiTietHoaDon.SOLUONG = int.Parse(nbudSoLuong.Value.ToString());
                    chiTietHoaDon.GIATIEN = int.Parse(cthdItem.SubItems[3].Text);
                    chiTietHoaDon.THANHTIEN = chiTietHoaDon.SOLUONG * chiTietHoaDon.GIATIEN;


                    if (newSoLuong > oldSoLuong)
                    {
                        if (soLuongSach >= newSoLuong - oldSoLuong)
                        {
                            if (BLLChiTietHoaDon.UpdateChiTietHoaDon(chiTietHoaDon))
                            {
                                BLLSach.UpdateSoLuongSach(cthdItem.SubItems[1].Text, soLuongSach - (newSoLuong - oldSoLuong));
                                LoadDataChiTietHoaDon();
                                LoadDataSach();
                                btnAddCTHD.Enabled = true;
                                btnUpdateCTHD.Enabled = false;
                                btnDeleteCTHD.Enabled = false;
                                btnSaveCTHD.Enabled = false;
                                lsvChiTietHoaDon.Enabled = true;

                                ActiveSachPanel(false);
                            }
                        }
                        else MessageBox.Show("Vượt quá số lượng sách trong kho!!!");
                    }
                    else
                    {
                        if (BLLChiTietHoaDon.UpdateChiTietHoaDon(chiTietHoaDon))
                        {
                            BLLSach.UpdateSoLuongSach(cthdItem.SubItems[1].Text, soLuongSach + (oldSoLuong - newSoLuong));
                            LoadDataChiTietHoaDon();
                            LoadDataSach();
                            btnAddCTHD.Enabled = true;
                            btnUpdateCTHD.Enabled = false;
                            btnDeleteCTHD.Enabled = false;
                            btnSaveCTHD.Enabled = false;
                            lsvChiTietHoaDon.Enabled = true;

                            ActiveSachPanel(false);
                        }
                    }
                }
                else MessageBox.Show("Vui lòng chọn số lượng !!!");
            }
        }
        private void ActiveSachPanel(bool trueFalse)
        {
            lsvSach.Enabled = trueFalse;
            nbudSoLuong.Enabled = trueFalse;
            nbudSoLuong.Value = 0;

        }

        private void SetDefault()
        {
            btnAddCTHD.Enabled = false;
            btnSaveCTHD.Enabled = false;
            btnUpdateCTHD.Enabled = false;
            btnDeleteCTHD.Enabled = false;

            btnCreateHD.Enabled = true;
            btnCTHD.Enabled = false;
            btnDeleteHD.Enabled = false;
            btnSaveHD.Enabled = false;
            btnConfirm.Enabled = false;

            txbMaHD.Clear();
            txbTenKH.Clear();

            lsvHoaDon.Enabled = true;
            lsvChiTietHoaDon.Enabled = false;
            ActiveSachPanel(false);
        }

        private void lsvChiTietHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvChiTietHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem cthdItem = lsvChiTietHoaDon.SelectedItems[0];
                nbudSoLuong.Value = int.Parse(cthdItem.SubItems[2].Text);

                btnUpdateCTHD.Enabled = true;
                btnDeleteCTHD.Enabled = true;
            }
            else
            {
                nbudSoLuong.Value = 0;

                btnUpdateCTHD.Enabled = false;
                btnDeleteCTHD.Enabled = false;
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (lsvHoaDon.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn chắc chắc muốn xóa hóa đơn " + txbMaHD.Text + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataTable dataTable = new DataTable();
                    dataTable = BLLChiTietHoaDon.GetDataChiTietHoaDon(txbMaHD.Text);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string maHD = row["MAHOADON"].ToString();
                        string maSach = row["MASACH"].ToString();
                        int soLuong = int.Parse(row["SOLUONG"].ToString());
                        int soLuongSachTrongKho = BLLSach.GetSoLuongSach(maSach);

                        if (BLLChiTietHoaDon.DeleteChiTietHoaDon(maHD, maSach))
                        {
                            BLLSach.UpdateSoLuongSach(maSach, soLuongSachTrongKho + soLuong);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi !!!");
                            break;
                        }
                    }
                    if (BLLHoaDon.DeleteHoaDon(lsvHoaDon.SelectedItems[0].Text))
                    {
                        MessageBox.Show("Xóa thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnCTHD.Enabled = false;
                        btnDeleteHD.Enabled = false;
                        btnXuatHD.Enabled = false;
                        txbMaHD.Clear();
                        txbTenKH.Clear();
                        LoadDataHoaDon();
                        LoadDataSach();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
        }


        private void btnDeleteCTHD_Click(object sender, EventArgs e)
        {
            if (lsvChiTietHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem cthdItem = lsvChiTietHoaDon.SelectedItems[0];
                if (MessageBox.Show("Bạn chắc chắc muốn xóa sách " + cthdItem.SubItems[1].Text + " khỏi hóa đơn ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int soLuongSach = BLLSach.GetSoLuongSach(cthdItem.SubItems[1].Text);

                    if (BLLChiTietHoaDon.DeleteChiTietHoaDon(cthdItem.Text, cthdItem.SubItems[1].Text))
                    {
                        BLLSach.UpdateSoLuongSach(cthdItem.SubItems[1].Text, soLuongSach + int.Parse(cthdItem.SubItems[2].Text));
                        LoadDataChiTietHoaDon();
                        LoadDataSach();
                        btnAddCTHD.Enabled = true;
                        btnUpdateCTHD.Enabled = false;
                        btnDeleteCTHD.Enabled = false;
                    }
                }
            }
        }
        
        private void btnUpdateCTHD_Click(object sender, EventArgs e)
        {
            isAdd = false;
            isUpdate = true;
            btnSaveCTHD.Enabled = true;
            btnAddCTHD.Enabled = false;
            btnDeleteCTHD.Enabled = false;

            nbudSoLuong.Enabled = true;
            lsvChiTietHoaDon.Enabled = false;
        }

        private void btnCreateHD_Click(object sender, EventArgs e)
        {
            txbMaHD.Enabled = true;
            txbTenKH.Enabled = true;
            txbMaHD.Clear();
            txbTenKH.Clear();
            txbMaHD.Focus();
            dtpNgayLap.Value = DateTime.Now;

            lsvHoaDon.Enabled = false;
            btnConfirm.Enabled = true;
            btnCTHD.Enabled = false;
            btnDeleteHD.Enabled = false;
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            if (lsvHoaDon.SelectedItems.Count > 0)
            {
                dtpNgayLap.Value = DateTime.Now;

                btnCreateHD.Enabled = false;
                btnDeleteHD.Enabled = false;
                btnXuatHD.Enabled = false;

                btnSaveHD.Enabled = true;
                lsvChiTietHoaDon.Enabled = true;
                lsvHoaDon.Enabled = false;

                btnAddCTHD.Enabled = true;

                LoadDataChiTietHoaDon();

            }
        }

        private void btnAddCTHD_Click(object sender, EventArgs e)
        {
            isAdd = true;
            isUpdate = false;
            btnUpdateCTHD.Enabled = false;
            btnDeleteCTHD.Enabled = false;
            btnSaveCTHD.Enabled = true;

            lsvSach.Enabled = true;
            nbudSoLuong.Enabled = true;
            nbudSoLuong.Value = 0;

        }

        private void btnSaveHD_Click(object sender, EventArgs e)
        {
            HoaDon newHD = new HoaDon();
            newHD.MAHOADON = txbMaHD.Text;
            newHD.TENKHACHHANG = txbTenKH.Text;
            newHD.NGAYLAP = dtpNgayLap.Text;
            int S = 0;
            foreach (ListViewItem item in lsvChiTietHoaDon.Items)
            {
                S += int.Parse(item.SubItems[4].Text);
            }
            newHD.TONGTIEN = S;
            if (BLLHoaDon.UpdateHoaDon(newHD))
            {
                FrmHoaDon_Load(sender, e);
                SetDefault();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txbMaHD.Text != string.Empty && txbTenKH.Text != string.Empty)
            {
                if (!BLLHoaDon.Check(txbMaHD.Text))
                {
                    HoaDon newHD = new HoaDon();
                    newHD.MAHOADON = txbMaHD.Text;
                    newHD.TENKHACHHANG = txbTenKH.Text;
                    newHD.NGAYLAP = dtpNgayLap.Text;
                    newHD.TONGTIEN = 0;
                    if (BLLHoaDon.AddHoaDon(newHD))
                    {
                        btnCreateHD.Enabled = false;
                        btnConfirm.Enabled = false;

                        txbMaHD.Enabled = false;
                        txbTenKH.Enabled = false;
                        dtpNgayLap.Enabled = false;

                        btnAddCTHD.Enabled = true;
                        btnSaveCTHD.Enabled = false;
                        btnSaveHD.Enabled = true;

                        lsvChiTietHoaDon.Enabled = true;
                        lsvChiTietHoaDon.Items.Clear();
                    }
                }
                else MessageBox.Show("Mã hóa đơn đã tồn tại !!!");
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
        }

        private async void btnXuatHD_Click(object sender, EventArgs e)
        {
            if (lsvHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvHoaDon.SelectedItems[0];
                // URL API để tạo mã QR
                string apiUrl = "https://api.vietqr.io/v2/generate";

                // Thông tin thanh toán
                var paymentInfo = new
                {
                    accountNo = "050125778485",
                    acqId = 970403,
                    amount = item.SubItems[3].Text.Split('.')[0],
                    accountName = "TA THANH THIEN",
                    addInfo = "Thanh toán hóa đơn " + item.Text.Trim(),
                    template = "qr_only",
                };

                // Gọi API để tạo mã QR
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.PostAsJsonAsync(apiUrl, paymentInfo);
                    var responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                    if (response.IsSuccessStatusCode)
                    {
                        //var qrCodeUrl = await response.Content.ReadAsStringAsync();
                        var qrDataUrl = ExtractQrDataUrl(responseContent);
                        CreatePdfWithQrCode(qrDataUrl, item);
                    }
                    else
                    {
                        Console.WriteLine("Lỗi khi gọi API: " + response.ReasonPhrase);
                    }
                }
            }
            
        }

        private string ExtractQrDataUrl(string jsonResponse)
        {
            // Giả sử jsonResponse là chuỗi JSON chứa trường qrDataURL
            // Bạn có thể sử dụng thư viện JSON như Newtonsoft.Json để phân tích chuỗi JSON này
            dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonResponse);
            return json.data.qrDataURL;
        }

        private void CreatePdfWithQrCode(string qrDataUrl, ListViewItem item)
        {
            try
            {
                // Giải mã base64 để lấy byte array của hình ảnh mã QR
                string base64Data = qrDataUrl.Split(',')[1]; // Bỏ phần "data:image/png;base64,"
                byte[] qrImageBytes = Convert.FromBase64String(base64Data);


                //Tạo đối tượng Document
                Document doc = new Document(PageSize.A4, 50, 50, 25, 25);

                // Đường dẫn lưu file PDF
                string path = "D:/hoa_don_mua_hang.pdf";

                // Tạo đối tượng PdfWriter
                PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

                // Mở document để ghi nội dung
                doc.Open();

                string fontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fonts", "TIMES.TTF");
                // Tạo font chữ
                BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontContentBold = new iTextSharp.text.Font(bf, 13, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontContentNomal = new iTextSharp.text.Font(bf, 13, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font fontContentItalic = new iTextSharp.text.Font(bf, 13, iTextSharp.text.Font.ITALIC);

                // Thêm tiêu đề hóa đơn
                Paragraph p = new Paragraph("HÓA ĐƠN MUA HÀNG TẠI NHÀ SÁCH TQT", fontTitle);
                p.Alignment = Element.ALIGN_CENTER;
                doc.Add(p);

                // Thêm khoảng trống
                doc.Add(new Paragraph("\n"));

                PdfPTable table = new PdfPTable(4);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 1, 1, 1, 1 });

                table.AddCell(new PdfPCell(new Phrase("Mã hóa đơn: ", fontContentNomal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                table.AddCell(new PdfPCell(new Phrase(item.Text, fontContentBold)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                table.AddCell(new PdfPCell(new Phrase("Tên khách hàng: ", fontContentNomal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                table.AddCell(new PdfPCell(new Phrase(item.SubItems[1].Text, fontContentBold)) { Border = iTextSharp.text.Rectangle.NO_BORDER });

                doc.Add(table);

                //doc.Add(new Paragraph("\n"));
                Paragraph underline = new Paragraph("----------------------------------------------------------------------------------------------------------", fontContentNomal);
                underline.Alignment = Element.ALIGN_CENTER;
                doc.Add(underline);

                doc.Add(new Paragraph("\n"));

                // Thêm nội dung hóa đơn
                table = new PdfPTable(4);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 2, 1, 1, 1 });

                // Thêm các ô vào bảng
                table.AddCell(new PdfPCell(new Phrase("TÊN SẢN PHẨM", fontContentBold)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                table.AddCell(new PdfPCell(new Phrase("SỐ LƯỢNG", fontContentBold)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                table.AddCell(new PdfPCell(new Phrase("GIÁ TIỀN", fontContentBold)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                table.AddCell(new PdfPCell(new Phrase("THÀNH TIỀN", fontContentBold)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

                DataTable dt = BLLChiTietHoaDon.GetDataChiTietHoaDon(item.Text);

                foreach (DataRow row in dt.Rows)
                {

                    table.AddCell(new PdfPCell(new Phrase(BLLSach.GetTenSach(row["MASACH"].ToString()), fontContentNomal)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                    table.AddCell(new PdfPCell(new Phrase(row["SOLUONG"].ToString(), fontContentNomal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                    table.AddCell(new PdfPCell(new Phrase(row["GIATIEN"].ToString(), fontContentNomal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                    table.AddCell(new PdfPCell(new Phrase(row["THANHTIEN"].ToString(), fontContentNomal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                }

                // Thêm bảng vào document
                doc.Add(table);

                doc.Add(underline);

                doc.Add(new Paragraph("\n"));

                table = new PdfPTable(4);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 2, 1, 1, 1 });


                table.AddCell(new PdfPCell(new Phrase("TỔNG TIỀN PHẢI THANH TOÁN : ", fontContentBold)) { Border = iTextSharp.text.Rectangle.NO_BORDER, NoWrap = true });
                table.AddCell(new PdfPCell(new Phrase("", fontContentBold)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                table.AddCell(new PdfPCell(new Phrase("", fontContentBold)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                table.AddCell(new PdfPCell(new Phrase(item.SubItems[3].Text + " VND", fontContentBold)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT, NoWrap = true });

                doc.Add(table);

                doc.Add(new Paragraph("\n"));

                // Thêm mã QR vào PDF
                iTextSharp.text.Image qrImage = iTextSharp.text.Image.GetInstance(qrImageBytes);
                qrImage.Alignment = Element.ALIGN_CENTER;
                qrImage.ScaleAbsolute(200, 200);
                doc.Add(qrImage);

                doc.Add(new Paragraph("\n"));

                p = new Paragraph("Mọi thắc mắc xin vui lòng liên hệ với nhân viên cửa hàng hoặc Hotline: 0901010109", fontContentNomal);
                p.Alignment = Element.ALIGN_CENTER;
                doc.Add(p);

                doc.Add(new Paragraph("\n"));

                p = new Paragraph("Xin cảm ơn quý khách!!!", fontContentItalic);
                p.Alignment = Element.ALIGN_CENTER;
                doc.Add(p);

                // Đóng document
                doc.Close();

                MessageBox.Show("Xuất hóa đơn thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Xuất hóa đơn không thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
