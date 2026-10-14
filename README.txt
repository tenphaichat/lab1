LAB 1: LÀM QUEN VISUAL STUDIO VÀ LẬP TRÌNH CONSOLE
1. HƯỚNG DẪN BIÊN DỊCH VÀ CHẠY
- Yêu cầu môi trường: Visual Studio 2022 hoặc .NET SDK (>= .NET 8 / .NET 9).
- Mở bằng Visual Studio:
  + Mở file solution: IT3212_Labs.sln
  + Nhấn F5 hoặc Ctrl+F5 để build và chạy ứng dụng Console.
- Chạy bằng dòng lệnh (CLI):
  + Di chuyển vào thư mục lab1:
      cd lab1
  + Chạy lệnh:
      dotnet run --project Lab01_Console/Lab01_Console.csproj

2. DANH SÁCH BÀI TẬP ĐÃ HOÀN THÀNH
Menu điều hướng từ bài 1 đến bài 10:
PHẦN 1: BÀI TẬP CÓ HƯỚNG DẪN (1 - 5)
Bài 1: Nhập thông tin cá nhân (họ tên, năm sinh), tính tuổi gần đúng, kiểm tra int.TryParse().
Bài 2: Tính diện tích xung quanh (Sxq) và thể tích (V) hình trụ tròn, chặn số âm hoặc 0.
Bài 3: Nhập điểm và xếp loại học tập (Xuất sắc, Giỏi, Khá, Trung bình, Yếu), kiểm tra miền [0, 10].
Bài 4: Menu con lặp bằng do-while và switch tính tổng 1..n hoặc in bảng cửu chương 7.
Bài 5: Xử lý ngoại lệ phép chia với try - catch (FormatException, DivideByZeroException) và finally.

PHẦN 2: BÀI TẬP TỰ THỰC HIỆN (6 - 10)
Bài 6: Giải phương trình bậc hai (ax^2 + bx + c = 0):
      - Xét đầy đủ: a = 0 (bậc nhất bx + c = 0, vô nghiệm, vô số nghiệm, nghiệm đơn), delta > 0, delta = 0, delta < 0. Định dạng nghiệm 2 chữ số thập phân.
Bài 7: Thống kê dãy số nguyên:
      - Nhập n số nguyên.
      - Tính tổng, trung bình cộng, giá trị lớn nhất (Max), nhỏ nhất (Min), và đếm số lượng số chẵn.
Bài 8: Liệt kê các số nguyên tố không vượt quá n:
      - Kiểm tra số nguyên tố lặp đến căn bậc 2 (Math.Sqrt(n)).
Bài 9: Đọc số nguyên từ 0 đến 99 bằng tiếng Việt:
      - Sử dụng cấu trúc switch-case để xử lý hàng chục và hàng đơn vị (mười, hai mươi, mốt, lăm, tư,...).
Bài 10: Menu vẽ hình ký tự bằng dấu *:
      - Tam giác vuông đặc kích thước n.
      - Tam giác vuông rỗng kích thước n.
      - Hình vuông rỗng kích thước n.

3. DỮ LIỆU KIỂM THỬ MẪU (TEST CASES)
Bài 1: Họ tên = "Phan Văn Thắng", Năm sinh = 2006 -> Tuổi: 2026 - 2006 = 20.
Bài 2: r = 3.5, h = 8 -> Sxq = 175.93; V = 307.88.
Bài 3: Điểm = 8.5 -> Xếp loại: Giỏi; Điểm = 11 -> Báo lỗi ngoài khoảng [0, 10].
Bài 5: a = 15, b = 0 -> Bắt ngoại lệ: "Không thể chia cho 0."
Bài 6: a = 1, b = -5, c = 6 -> Nghiệm x1 = 3.00, x2 = 2.00.
         a = 1, b = 2, c = 1 -> Nghiệm kép: x1 = x2 = -1.00.
         a = 1, b = 1, c = 1 -> Vô nghiệm thực.
Bài 7: n = 5, dãy [12, -4, 7, 0, 15] -> Tổng = 30, TB = 6.00, Max = 15, Min = -4, Số chẵn = 3.
Bài 8: n = 30 -> Các số nguyên tố: 2 3 5 7 11 13 17 19 23 29.
Bài 9: 5 -> "năm", 15 -> "mười lăm", 24 -> "hai mươi tư", 71 -> "bảy mươi mốt".
Bài 10: n = 5 -> Vẽ tam giác vuông đặc/rỗng và hình vuông rỗng với dấu *.
