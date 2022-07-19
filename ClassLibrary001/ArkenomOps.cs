using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary001
{
    public class ArkenomOps
    {
        public OperationResult CreateMusteriRecord(string ad, string soyad, string tckn)
        {

            OperationResult op = new OperationResult();
            op.hata = false;
            op.hataDetayi = "ıslem başarılı";
            op.sistemHatasi = 0;

            try
            {
                if (string.IsNullOrEmpty(ad))
                {
                    op.hata = true;
                    op.hataDetayi = "geçerli bir ad giriniz ";
                    return op;

                }

                if (tckn.Length > 11)
                {
                    op.hata = true;
                    op.hataDetayi = "tc 11 den büyük olamaz";
                    return op;
                }
            }
            catch (Exception ex)
            {
                op.hata = true;
                op.hataDetayi = "201" + ex.Message;
                op.sistemHatasi = 1;
            }
            return op;
        }

        public int SüreyiVer()
        {
            return DateTime.Now.Second;
        }
    }
}
