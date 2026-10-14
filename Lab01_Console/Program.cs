using System;
using System.Text;

namespace Lab01_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int chon = -1;
            while (chon != 0)
            {
                Console.WriteLine("\nCHƯƠNG TRÌNH THỰC HÀNH LAB 1");
                Console.WriteLine("1. Nhập thông tin cá nhân và tính tuổi");
                Console.WriteLine("2. Tính diện tích xung quanh và thể tích hình trụ");
                Console.WriteLine("3. Xếp loại kết quả học tập");
                Console.WriteLine("4. Tính tổng 1..n hoặc in bảng cửu chương");
                Console.WriteLine("5. Xử lý ngoại lệ phép chia hai số nguyên");
                Console.WriteLine("6. Giải phương trình bậc hai (ax^2 + bx + c = 0)");
                Console.WriteLine("7. Thống kê dãy số nguyên (Tổng, TB, Max, Min, Chẵn)");
                Console.WriteLine("8. Liệt kê các số nguyên tố <= n");
                Console.WriteLine("9. Đọc số nguyên từ 0 đến 99");
                Console.WriteLine("10. Vẽ tam giác vuông, hình vuông bằng dấu *");
                Console.WriteLine("0. Thoát");
                Console.Write("Mời bạn chọn bài (0-10): ");

                if (!int.TryParse(Console.ReadLine(), out chon))
                {
                    Console.WriteLine("Vui lòng nhập số nguyên từ 0 đến 10!");
                    continue;
                }

                Console.WriteLine();
                switch (chon)
                {
                    case 1:
                        Bai1();
                        break;
                    case 2:
                        Bai2();
                        break;
                    case 3:
                        Bai3();
                        break;
                    case 4:
                        Bai4();
                        break;
                    case 5:
                        Bai5();
                        break;
                    case 6:
                        Bai6();
                        break;
                    case 7:
                        Bai7();
                        break;
                    case 8:
                        Bai8();
                        break;
                    case 9:
                        Bai9();
                        break;
                    case 10:
                        Bai10();
                        break;
                    case 0:
                        Console.WriteLine("Đã thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Số bạn chọn không có trong danh sách. Vui lòng chọn lại.");
                        break;
                }

                if (chon != 0)
                {
                    Console.WriteLine("\nẤn Enter để tiếp tục...");
                    Console.ReadLine();
                }
            }
        }

        // Bài 1: Thông tin cá nhân
        static void Bai1()
        {
            Console.WriteLine("Bài 1: Nhập thông tin cá nhân và tính tuổi");
            Console.Write("Họ và tên: ");
            string? hoTen = Console.ReadLine();

            Console.Write("Năm sinh: ");
            int namSinh;
            if (!int.TryParse(Console.ReadLine(), out namSinh) || namSinh < 1900 || namSinh > DateTime.Now.Year)
            {
                Console.WriteLine("Năm sinh không hợp lệ.");
                return;
            }

            int tuoi = DateTime.Now.Year - namSinh;
            Console.WriteLine("Xin chào {0}, tuổi gần đúng: {1}", hoTen, tuoi);
        }

        // Bài 2: Hình trụ
        static void Bai2()
        {
            Console.WriteLine("Bài 2: Tính diện tích xung quanh và thể tích hình trụ");
            double r, h;
            Console.Write("Bán kính r = ");
            if (!double.TryParse(Console.ReadLine(), out r) || r <= 0)
            {
                Console.WriteLine("Bán kính phải lớn hơn 0.");
                return;
            }

            Console.Write("Chiều cao h = ");
            if (!double.TryParse(Console.ReadLine(), out h) || h <= 0)
            {
                Console.WriteLine("Chiều cao phải lớn hơn 0.");
                return;
            }

            double dienTichXQ = 2 * Math.PI * r * h;
            double theTich = Math.PI * r * r * h;
            Console.WriteLine("Sxq = {0:N2}; V = {1:N2}", dienTichXQ, theTich);
        }

        // Bài 3: Xếp loại học tập
        static void Bai3()
        {
            Console.WriteLine("Bài 3: Xếp loại kết quả học tập");
            Console.Write("Nhập điểm: ");
            double diem;
            if (!double.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
            {
                Console.WriteLine("Điểm phải thuộc [0, 10].");
            }
            else if (diem >= 9) Console.WriteLine("Xếp loại: Xuất sắc");
            else if (diem >= 8) Console.WriteLine("Xếp loại: Giỏi");
            else if (diem >= 6.5) Console.WriteLine("Xếp loại: Khá");
            else if (diem >= 5) Console.WriteLine("Xếp loại: Trung bình");
            else Console.WriteLine("Xếp loại: Yếu");
        }

        // Bài 4: Menu tính tổng hoặc bảng cửu chương
        static void Bai4()
        {
            Console.WriteLine("Bài 4: Menu tính tổng hoặc in bảng cửu chương 7");
            int chon;
            do
            {
                Console.WriteLine("1. Tổng 1..n");
                Console.WriteLine("2. Bảng cửu chương 7");
                Console.WriteLine("0. Quay lại");
                Console.Write("Chọn: ");
                int.TryParse(Console.ReadLine(), out chon);

                switch (chon)
                {
                    case 1:
                        Console.Write("n = ");
                        if (int.TryParse(Console.ReadLine(), out int n) && n >= 1)
                        {
                            long tong = 0;
                            for (int i = 1; i <= n; i++) tong += i;
                            Console.WriteLine("Tổng = " + tong);
                        }
                        else
                        {
                            Console.WriteLine("n phải là số nguyên dương.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Bảng cửu chương 7:");
                        for (int i = 1; i <= 10; i++)
                            Console.WriteLine("7 x {0} = {1}", i, 7 * i);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
                Console.WriteLine();
            } while (chon != 0);
        }

        // Bài 5: Ngoại lệ phép chia
        static void Bai5()
        {
            Console.WriteLine("Bài 5: Xử lý ngoại lệ phép chia");
            try
            {
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine()!);
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine()!);
                Console.WriteLine("a / b = " + (a / b));
            }
            catch (FormatException)
            {
                Console.WriteLine("Dữ liệu phải là số nguyên.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Không thể chia cho 0.");
            }
            finally
            {
                Console.WriteLine("Kết thúc phép tính.");
            }
        }

        // Bài 6: Phương trình bậc hai
        static void Bai6()
        {
            Console.WriteLine("Bài 6: Giải phương trình bậc hai ax^2 + bx + c = 0");
            Console.Write("a = ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Hệ số a không hợp lệ.");
                return;
            }

            Console.Write("b = ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Hệ số b không hợp lệ.");
                return;
            }

            Console.Write("c = ");
            if (!double.TryParse(Console.ReadLine(), out double c))
            {
                Console.WriteLine("Hệ số c không hợp lệ.");
                return;
            }

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0) Console.WriteLine("Phương trình vô số nghiệm.");
                    else Console.WriteLine("Phương trình vô nghiệm.");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("Phương trình có một nghiệm: x = {0:N2}", x);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm thực.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Phương trình có nghiệm kép: x1 = x2 = {0:N2}", x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phương trình có 2 nghiệm phân biệt:");
                    Console.WriteLine("x1 = {0:N2}", x1);
                    Console.WriteLine("x2 = {0:N2}", x2);
                }
            }
        }

        // Bài 7: Thống kê dãy số
        static void Bai7()
        {
            Console.WriteLine("Bài 7: Thống kê dãy số nguyên");
            Console.Write("Nhập số lượng phần tử n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("n phải là số nguyên dương.");
                return;
            }

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử thứ {0}: ", i + 1);
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.Write("Nhập lại số nguyên: ");
                }
            }

            long tong = 0;
            int max = arr[0];
            int min = arr[0];
            int soChan = 0;

            for (int i = 0; i < n; i++)
            {
                tong += arr[i];
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
                if (arr[i] % 2 == 0) soChan++;
            }

            double trungBinh = (double)tong / n;

            Console.WriteLine("Tổng: " + tong);
            Console.WriteLine("Trung bình: {0:N2}", trungBinh);
            Console.WriteLine("Số lớn nhất: " + max);
            Console.WriteLine("Số nhỏ nhất: " + min);
            Console.WriteLine("Số lượng số chẵn: " + soChan);
        }

        // Bài 8: Số nguyên tố <= n
        static void Bai8()
        {
            Console.WriteLine("Bài 8: Liệt kê các số nguyên tố không vượt quá n");
            Console.Write("Nhập n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 2)
            {
                Console.WriteLine("Không có số nguyên tố nào <= " + n);
                return;
            }

            Console.Write("Các số nguyên tố <= {0}: ", n);
            for (int i = 2; i <= n; i++)
            {
                if (KiemTraNguyenTo(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static bool KiemTraNguyenTo(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        // Bài 9: Đọc số 0..99
        static void Bai9()
        {
            Console.WriteLine("Bài 9: Đọc số nguyên từ 0 đến 99");
            Console.Write("Nhập số (0-99): ");
            if (!int.TryParse(Console.ReadLine(), out int so) || so < 0 || so > 99)
            {
                Console.WriteLine("Số không hợp lệ.");
                return;
            }

            if (so < 10)
            {
                switch (so)
                {
                    case 0: Console.WriteLine("không"); break;
                    case 1: Console.WriteLine("một"); break;
                    case 2: Console.WriteLine("hai"); break;
                    case 3: Console.WriteLine("ba"); break;
                    case 4: Console.WriteLine("bốn"); break;
                    case 5: Console.WriteLine("năm"); break;
                    case 6: Console.WriteLine("sáu"); break;
                    case 7: Console.WriteLine("bảy"); break;
                    case 8: Console.WriteLine("tám"); break;
                    case 9: Console.WriteLine("chín"); break;
                }
                return;
            }

            int chuc = so / 10;
            int donVi = so % 10;
            string strChuc = "";

            switch (chuc)
            {
                case 1: strChuc = "mười"; break;
                case 2: strChuc = "hai mươi"; break;
                case 3: strChuc = "ba mươi"; break;
                case 4: strChuc = "bốn mươi"; break;
                case 5: strChuc = "năm mươi"; break;
                case 6: strChuc = "sáu mươi"; break;
                case 7: strChuc = "bảy mươi"; break;
                case 8: strChuc = "tám mươi"; break;
                case 9: strChuc = "chín mươi"; break;
            }

            if (donVi == 0)
            {
                Console.WriteLine(strChuc);
                return;
            }

            string strDonVi = "";
            switch (donVi)
            {
                case 1: strDonVi = (chuc > 1) ? "mốt" : "một"; break;
                case 2: strDonVi = "hai"; break;
                case 3: strDonVi = "ba"; break;
                case 4: strDonVi = (chuc > 1) ? "tư" : "bốn"; break;
                case 5: strDonVi = "lăm"; break;
                case 6: strDonVi = "sáu"; break;
                case 7: strDonVi = "bảy"; break;
                case 8: strDonVi = "tám"; break;
                case 9: strDonVi = "chín"; break;
            }

            Console.WriteLine(strChuc + " " + strDonVi);
        }

        // Bài 10: Vẽ hình
        static void Bai10()
        {
            Console.WriteLine("Bài 10: Vẽ hình bằng dấu *");
            Console.WriteLine("1. Tam giác vuông đặc");
            Console.WriteLine("2. Tam giác vuông rỗng");
            Console.WriteLine("3. Hình vuông rỗng");
            Console.Write("Chọn hình: ");

            int loai;
            if (!int.TryParse(Console.ReadLine(), out loai) || loai < 1 || loai > 3)
            {
                Console.WriteLine("Lựa chọn không hợp lệ.");
                return;
            }

            Console.Write("Nhập kích thước n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 2)
            {
                Console.WriteLine("n phải >= 2.");
                return;
            }

            switch (loai)
            {
                case 1:
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= i; j++)
                            Console.Write("* ");
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            if (j == 1 || j == i || i == n)
                                Console.Write("* ");
                            else
                                Console.Write("  ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            if (i == 1 || i == n || j == 1 || j == n)
                                Console.Write("* ");
                            else
                                Console.Write("  ");
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        }
    }
}
