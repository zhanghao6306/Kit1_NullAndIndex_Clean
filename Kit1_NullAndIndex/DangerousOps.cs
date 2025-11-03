using System;

namespace Kit1_NullAndIndexLib
{
    public static class DangerousOps
    {
        public static int LengthOfName(string? name)
        {
            return name.Length; // NullReferenceException if name is null
        }

        public static int GetAt(int[] data, int index)
        {
            return data[index]; // IndexOutOfRangeException if index invalid
        }

        public static int[] MakeArray(int n)
        {
            var a = new int[n];
            for (int i = 0; i < n; i++) a[i] = i + 1;
            return a;
        }
    }
}
