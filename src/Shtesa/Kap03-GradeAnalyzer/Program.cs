int n1 = 10, n2 = 8, n3 = 9;
double mesatarja = (n1 + n2 + n3) / 3.0;

bool kaKaluar = n1 >= 6 && n2 >= 6 && n3 >= 6;
bool shkelqyeshem = mesatarja >= 9.0;

Console.WriteLine($"Mesatarja: {mesatarja:F2}");
Console.WriteLine($"Ka kaluar: {kaKaluar}");
Console.WriteLine($"Shkëlqyeshëm: {shkelqyeshem}");
