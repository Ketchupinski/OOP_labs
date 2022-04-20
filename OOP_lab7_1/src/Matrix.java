import java.util.Scanner;

public class Matrix
{
    private int K;
    private int N;
    private int[][] mat;

    private static Scanner scan = new Scanner(System.in);

    public Matrix()
    {
        this.K = 0;
        this.N = 0;
        this.mat = new int[K][N];
    }

    public Matrix(int k, int n)
    {
        if (k > 0 && n > 0)
        {
            this.K = k;
            this.N = n;
            this.mat = new int[K][N];
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    mat[i][j] = 0;
                }
            }
        }
    }

    public void setMat(int[][] mat) {
        this.mat = mat;
    }

    public void setN(int n) {
        N = n;
    }

    public void setK(int k) {
        K = k;
    }

    public int[][] getMat() {
        return mat;
    }

    public int getN() {
        return N;
    }

    public int getK() {
        return K;
    }

    public static Matrix Create()
    {
        int k = 0, n = 0;
        do
        {
            System.out.println("Please, input number of lines:");
            String st = scan.nextLine();
            k = Integer.parseInt(st);
            System.out.println("Please, input number of rows:");
            st = scan.nextLine();
            n = Integer.parseInt(st);
        } while (!(k > 0 && n > 0));
        return new Matrix(k, n);
    }

    public void Fill()
    {
        for (int i = 0; i < K; i++)
        {
            for (int j = 0; j < N; j++)
            {
                System.out.println("Input number in line " + (i + 1) + " in row " + (j + 1));
                String str = scan.nextLine();
                this.mat[i][j] = Integer.parseInt(str);
            }
        }
    }

    public void Display()
    {
        for (int i = 0; i < K; i++)
        {
            for (int j = 0; j < N; j++)
            {
                System.out.print(mat[i][j] + " ");
            }
            System.out.println();
        }
    }

    public static Matrix Minus(Matrix a, Matrix b)
    {
        if (a.N == b.N && a.K == b.K)
        {
            var matrix = new Matrix(a.K, a.N);
            for (int i = 0; i < a.K; i++)
            {
                for (int j = 0; j < a.N; j++)
                {
                    matrix.mat[i][j] = a.mat[i][j] - b.mat[i][j];
                }
            }
            return matrix;
        }
        else
        {
            System.out.println(("Matrix must have same size! Returning zero matrix..."));
            return new Matrix();
        }
    }

    @Override
    public boolean equals(Object matrix) {
        Matrix b = (Matrix)matrix;
        if (this.N == b.getN() && this.K == b.getK())
        {
            for (int i = 0; i < this.K; i++)
            {
                for (int j = 0; j < this.N; j++)
                {
                    if (this.mat[i][j] != b.mat[i][j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        else
        {
            return false;
        }
    }

    public double Norm() // обчислення норми матриці (корінь із суми квадратів елементів).
    {
        double sum = 0;
        for (int i = 0; i < K; i++)
        {
            for (int j = 0; j < N; j++)
            {
                sum += Math.pow(mat[i][j], 2);
            }
        }
        return Math.round(Math.sqrt(sum));
    }
}
