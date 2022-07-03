using System;
using System.Collections.Generic;

namespace Data.ValueObject
{ 
    [Serializable]
    public class SizeList
    {
        public List<SizeData> SizeDatas = new List<SizeData>();
    }
}

