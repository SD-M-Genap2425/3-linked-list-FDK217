using System.Text;
using System.Collections.Generic;

namespace LinkedList.Perpustakaan
{
    public class KoleksiPerpustakaan
    {
        BukuNode? head;

        public void TambahBuku(Buku buku)
        {
            if (head == null)
            {
                head = new BukuNode(buku);
            }
            else
            {
                BukuNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new BukuNode(buku);
            }
        }

        public bool HapusBuku(string judul)
        {
            if (head == null)
            {
                return false;
            }
            if (head.Data.Judul == judul)
            {
                head = head.Next;
                return true;
            }
            BukuNode current = head;
            while (current.Next != null)
            {
                if (current.Next.Data.Judul == judul)
                {
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public Buku[] CariBuku(string kataKunci)
        {
            List<Buku> hasil = new List<Buku>();
            BukuNode? current = head;
            while (current != null)
            {
                if (current.Data.Judul.Contains(kataKunci))
                {
                    hasil.Add(current.Data);
                }
                current = current.Next;
            }
            return hasil.ToArray();
        }

        public string TampilkanKoleksi()
        {
            StringBuilder sb = new StringBuilder();
            BukuNode? current = head;
            while (current != null)
            {
                sb.AppendLine($"\"{current.Data.Judul}\"; {current.Data.Penulis}; {current.Data.Tahun}");
                current = current.Next;
            }
            return sb.ToString().TrimEnd();
        }
    }
}
