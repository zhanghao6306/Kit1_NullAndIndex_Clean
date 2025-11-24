using System;

namespace Kit1_NullAndIndexLib
{
    public static class DangerousOps
    {
        public static int LengthOfName(string? name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name), "Name cannot be null");
            return name.Length;
        }

        public static int GetAt(int[] data, int index)
        {
            if (data == null) throw new ArgumentNullException(nameof(data), "Data array cannot be null");
            if (index < 0 || index >= data.Length)
                throw new ArgumentOutOfRangeException(nameof(index), $"Index must be between 0 and {data.Length - 1}");
            return data[index];
        }

        public static int[] MakeArray(int n)
        {
            var a = new int[n];
            for (int i = 0; i < n; i++) a[i] = i + 1;
            return a;
        }
    }
}
