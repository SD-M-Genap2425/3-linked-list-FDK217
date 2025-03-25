namespace LinkedList.ManajemenKaryawan
{
    public class KaryawanNode
    {
        public Karyawan Karyawan { get; set; }
        public KaryawanNode? Next { get; set; }
        public KaryawanNode? Prev { get; set; }
        public KaryawanNode(Karyawan karyawan)
        {
            Karyawan = karyawan;
            Next = null;
            Prev = null;
        }
    }
}