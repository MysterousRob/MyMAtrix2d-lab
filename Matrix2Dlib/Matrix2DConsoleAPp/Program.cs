using Matrix2dLib;


var m = new Matrix2d();
Console.WriteLine(m);

var m1 = new Matrix2d(1, 2, 3, 4);
Console.WriteLine(m1);


var m2 = Matrix2d.Transpose(m1);
var m3 = (int[,])m2;


var identityMatrix = Matrix2d.Id;
Console.WriteLine($"Identity Matrix: {identityMatrix}");

var zeroMatrix = Matrix2d.Zero;
Console.WriteLine($"Zero Matrix: {zeroMatrix}");

var m1 = new Matrix2d(1, 2, 3, 4);
var m2 = new Matrix2d(5, 6, 7, 8);

Console.WriteLine($"Matrix 1: {m1}");
Console.WriteLine($"Matrix 2: {m2}");

Console.WriteLine($"Matrix 1 + Matrix 2: {m1 + m2}");
Console.WriteLine($"Matrix 1 - Matrix 2: {m1 - m2}");
Console.WriteLine($"Matrix 1 * Matrix 2: {m1 * m2}");

Console.WriteLine($"Transpose of Matrix 1: {Matrix2d.Transpose(m1)}");
Console.WriteLine($"Determinant of Matrix 1: {m1.Det()}");

// Scalar multiplication
Console.WriteLine($"3 * Matrix 1: {3 * m1}");
Console.WriteLine($"Matrix 1 * 3: {m1 * 3}");

// Negation
Console.WriteLine($"-Matrix 1: {-m1}");

// Conversion to int[,]
int[,] array = (int[,])m1;
Console.WriteLine($"Matrix as Array: [[{array[0, 0]}, {array[0, 1]}], [{array[1, 0]}, {array[1, 1]}]]");

// Parsing from string
try
{
    var parsedMatrix = Matrix2d.Parse("[[2,1],[3,2]]");
    Console.WriteLine($"Parsed Matrix: {parsedMatrix}");
}
catch (FormatException ex)
{
    Console.WriteLine($"Error parsing matrix: {ex.Message}");
}