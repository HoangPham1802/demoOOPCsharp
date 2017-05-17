using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demoOOPCsharp
{
    public abstract class ConNguoi
    {
        public string ten;
        string ngaysinh;
        int gioitinh;
        string diachi;

        public void an() { }
        public void ngu() { }
        public void chay() { }
        public void choi() { }
        public void gioithieu() { }
        public abstract void sudungMayTinh();
    }
}
