// Программа принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.


double ax = 7;
double ay = -5;
double az = 0;
double bx = 1;
double by = -1;
double bz = 9;

double cx = ax - bx;
double cy = ay - by;
double cz = az - bz;
double ab = Math.Sqrt(cx*cx + cy*cy + cz*cz);
Console.WriteLine(ab);