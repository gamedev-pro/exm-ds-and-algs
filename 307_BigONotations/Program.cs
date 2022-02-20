// O(1)
int Alg(int[] a, int[] b)
{
    var rnd = new Random();
    return a[rnd.Next(0, a.Length)] + b[rnd.Next(0, b.Length)];
}

// O(N)
void Alg(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= arr[i];
    }
}

// O(log N)
void Alg(int n)
{
    int k = 0;
    for (int i = 2; i <= n; i = i * 2)
    {
        k = k + n / 2;
    }
}

// O (log N)
void Alg(int n)
{
    int a = 0, i = n;
    while (i > 0)
    {
        a += i;
        i /= 2;
    }
}

// O (n^2)
void Alg(int n)
{
    int a = 0;
    for (var i = 0; i < n; i++)
    {
        for (var j = n; j > i; j--)
        {
            a = a + i + j;
        }
    }
}

// O (n + m)
void Alg(int n, int m)
{
    int a = 0, b = 0;
    var rnd = new Random();
    for (var i = 0; i < n; i++)
    {
        a = a + rnd.Next();
    }
    for (var j = 0; j < m; j++)
    {
        b = b + rnd.Next();
    }
}

// O (log N)
int FindIndexOnSortedArray(int[] arr, int searchElement)
{
    //assume-se que arr é ordenado
    var start = 0;
    var end = arr.Length - 1;
    var i = (int)((start + end) * 0.5f);

    while (i >= start && i <= end)
    {
        var element = arr[i];
        if (element == searchElement)
        {
            return i;
        }
        else if (searchElement > element)
        {
            start = i;
        }
        else
        {
            end = i;
        }

        i = (int)((start + end) * 0.5f);
    }

    // Not found
    return -1;
}

