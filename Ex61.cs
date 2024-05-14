int[] arr = [-5, 236, 120, 70, -5, -5, 698, 280];

var num = arr.Where(x => x != -5).OrderBy(x => x).ToArray();

var cnt = 0;

Console.WriteLine(arr.Select(x => x >= 0 ? num[cnt++] : -5).ToArray());