using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class dynamic
    {
        static void Main(string[] args)
        {
            #region Kiểu dữ liệu dynamic
            //Kiểu dữ liệu dynamic

            //dynamic StringValue = ""; // Các đối tượng thuộc kiểu dynamic sẽ không xác định đc kiểu cho đến khi chương trình được thực thi.

            //StringValue++; // StringValue ở đây là dạng chuỗi và không thể thực hiện được toán tử ++
            //               // tuy nhiên không có lỗi xảy ra trong quá trình viết code mà lỗi sẽ xảy ra khi chạy trương trình vì kiểu dữ liệu đang dùng là dynamic

            #endregion

            #region Chương trình sử dụng dynamic

            //// khai báo 2 biến name và mission kiểu string và khởi tạo giá trị.
            //string name = "bui quang huy";
            //string mission = "hoc viet code";
            ///*
            //thực hiện gán biến kiểu string cho biến kiểu dynamic bằng cách ép kiểu ngầm định (implicit)
            //sau phép gán này thì biến dynamicvalue chứa giá trị là "hoc viet code" nhưng kiểu dữ liệu của nó vẫn chưa được xác định.
            // */
            //dynamic dynamicvalue = mission;

            //// thực hiện cộng chuỗi và in ra màn hình bình thường.

            //Console.WriteLine("Mission of " + name + " is " + dynamicvalue);

            #endregion
        }
    }
}
