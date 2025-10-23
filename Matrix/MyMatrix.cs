namespace ConsoleMatrix;

internal class MyMatrix
{
    private int[,] _matrix;

    // Конструктор за замовчуванням (2x2)
    public MyMatrix()
    {
        _matrix = new int[2, 2];
    }

    // Конструктор з параметрами 
    public MyMatrix(int n, int m)
    {
        _matrix = new int[n, m];
    }

    // Заповнення випадковими числами
    public void InitRandom(int min = 1, int max = 10)
    {
        Random rand = new Random();
        int n = _matrix.GetLength(0);
        int m = _matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                _matrix[i, j] = rand.Next(min, max);
            }
        }
    }

    // Індексатор для доступу до елементів
    public int this[int row, int col]
    {
        get => _matrix[row, col];
    }

    // Додавання матриць
    public MyMatrix Add(MyMatrix other)
    {
        int n = _matrix.GetLength(0);
        int m = _matrix.GetLength(1);
        MyMatrix result = new MyMatrix(n, m);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                result._matrix[i, j] = this._matrix[i, j] + other._matrix[i, j];
            }
        }
        return result;
    }

    // Віднімання матриць
    public MyMatrix Minus(MyMatrix other)
    {
        int n = _matrix.GetLength(0);
        int m = _matrix.GetLength(1);
        MyMatrix result = new MyMatrix(n, m);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                result._matrix[i, j] = this._matrix[i, j] - other._matrix[i, j];
            }
        }
        return result;
    }

    // множення матриць
    public MyMatrix Multiply(MyMatrix other)
    {
        int n1 = _matrix.GetLength(0);
        int m1 = _matrix.GetLength(1);
        int n2 = other._matrix.GetLength(0);
        int m2 = other._matrix.GetLength(1);

        // Перевірка можливості множення
        if (m1 != n2)
        {
            throw new Exception("Множення неможливе! Кількість стовпців A ≠ кількості рядків B");
        }

        // Створюємо матрицю розміру n1 x m2
        MyMatrix result = new MyMatrix(n1, m2);

        // Алгоритм множення матриць
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < m2; j++)
            {
                int sum = 0;
                for (int k = 0; k < m1; k++)
                {
                    sum += this._matrix[i, k] * other._matrix[k, j];
                }
                result._matrix[i, j] = sum;
            }
        }
        return result;
    }

    // Вивід у вигляді рядка
    public override string ToString()
    {
        int n = _matrix.GetLength(0);
        int m = _matrix.GetLength(1);
        string result = "";
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                result += _matrix[i, j] + "\t";
            }
            result += "\n";
        }
        return result;
    }

    // Перевантаження операторів
    public static MyMatrix operator +(MyMatrix a, MyMatrix b)
    {
        return a.Add(b);
    }

    public static MyMatrix operator -(MyMatrix a, MyMatrix b)
    {
        return a.Minus(b);
    }

    public static MyMatrix operator *(MyMatrix a, MyMatrix b)
    {
        return a.Multiply(b);
    }
}
