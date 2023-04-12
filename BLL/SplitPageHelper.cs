using System.Collections.Generic;

namespace BLL
{
    public class SplitPageHelper<T>
    {
        private int MaxRow { get; set; }
        private List<T> li;

        public SplitPageHelper(int maxRow, List<T> li)
        {
            MaxRow = maxRow;
            this.li = li;
        }

        public List<T> GetRecords(int page)
        {
            int start = MaxRow * (page - 1);
            int num = MaxRow;
            if (start + MaxRow > li.Count)
                num = li.Count % MaxRow;
            return li.GetRange(start, num);
        }
    }
}
