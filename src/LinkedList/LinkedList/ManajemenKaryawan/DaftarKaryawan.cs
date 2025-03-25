using System.Text;
using System.Collections.Generic;

namespace LinkedList.ManajemenKaryawan
{
    public class DaftarKaryawan
    {
        KaryawanNode? head;
        KaryawanNode? tail;

        public void TambahKaryawan(Karyawan karyawan)
        {
            KaryawanNode baru = new KaryawanNode(karyawan);
            if (head == null)
            {
                head = baru;
                tail = baru;
            }
            else
            {
                tail!.Next = baru;
                baru.Prev = tail;
                tail = baru;
            }
        }

        public bool HapusKaryawan(string nomorKaryawan)
        {
            if (head == null)
            {
                return false;
            }
            KaryawanNode? current = head;
            while (current != null)
            {
                if (current.Karyawan.NomorKaryawan == nomorKaryawan)
                {
                    if (current.Prev == null && current.Next == null)
                    {
                        head = null;
                        tail = null;
                    }
                    else if (current.Prev == null)
                    {
                        head = current.Next;
                        head!.Prev = null;
                    }
                    else if (current.Next == null)
                    {
                        tail = current.Prev;
                        tail.Next = null;
                    }
                    else
                    {
                        current.Prev.Next = current.Next;
                        current.Next.Prev = current.Prev;
                    }
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public Karyawan[] CariKaryawan(string kataKunci)
        {
            List<Karyawan> hasil = new List<Karyawan>();
            KaryawanNode? current = head;
            while (current != null)
            {
                if (current.Karyawan.Nama.Contains(kataKunci) || current.Karyawan.Posisi.Contains(kataKunci))
                {
                    hasil.Add(current.Karyawan);
                }
                current = current.Next;
            }
            return hasil.ToArray();
        }

        public string TampilkanDaftar()
        {
            StringBuilder sb = new StringBuilder();
            KaryawanNode? current = tail;
            while (current != null)
            {
                sb.AppendLine($"{current.Karyawan.NomorKaryawan}; {current.Karyawan.Nama}; {current.Karyawan.Posisi}");
                current = current.Prev;
            }
            return sb.ToString().TrimEnd();
        }
    }
}
