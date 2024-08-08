using System;


namespace TinhSoNgayTrongThang
{
    class Program
    {
        static void Main(string[]args)
        {   
            int month=0;
            Console.Write("Nhap thang ma ban muon kiem tra: ");
            while(true)
            {
                if(Int32.TryParse(Console.ReadLine(),out month)&&month>0)

                {
                    break;
                }
                else
                Console.Write("Moi ban nhap lai thang muon kiem tra bang so: ");
            }

            string dayInMonth;
            switch(month)
            {
                case 2:
                dayInMonth="28 hoac 29 ngay";
                break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                dayInMonth="31 ngay";
                break;
                case 4:
                case 6:
                case 9:
                case 11:
                dayInMonth="30 ngay";
                break;
                default:
                dayInMonth = "";
                break;
            }
            if(dayInMonth!="")
            {
                    Console.WriteLine("Thang {0} co {1}",month, dayInMonth);
            }
            else 
            {
                Console.WriteLine("Thang ban nhap khong hop le");
            }
            
        }
    }
}