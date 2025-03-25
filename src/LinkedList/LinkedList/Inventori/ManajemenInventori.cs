using System.Text;
using System.Collections.Generic;

namespace LinkedList.Inventori
{
    public class ManajemenInventori
    {
        LinkedList<Item> items = new LinkedList<Item>();

        public void TambahItem(Item item)
        {
            items.AddLast(item);
        }

        public bool HapusItem(string nama)
        {
            var current = items.First;
            while (current != null)
            {
                if (current.Value.Nama == nama)
                {
                    items.Remove(current);
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public string TampilkanInventori()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in items)
            {
                sb.AppendLine($"{item.Nama}; {item.Kuantitas}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
