using Matrix2dLib;


var m = new Matrix2d();
Console.WriteLine(m);

var m1 = new Matrix2d(1, 2, 3, 4);
Console.WriteLine(m1);


var m2 = Matrix2d.Transpose(m1);
var m3 = (int[,])m2;