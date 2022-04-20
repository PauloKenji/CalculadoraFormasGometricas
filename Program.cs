Quadrado q1 = new Quadrado(10);

Console.WriteLine(q1.Lado);
Console.WriteLine(q1.Area);
Console.WriteLine(q1.Perimetro);

q1.Lado = 20;

Console.WriteLine(q1.Lado);
Console.WriteLine(q1.Area);
Console.WriteLine(q1.Perimetro);

Quadrado q2 = new Quadrado(15);

Console.WriteLine(q2.Lado);
Console.WriteLine(q2.Area);
Console.WriteLine(q2.Perimetro);

//-------------------------------------------------

Retangulo r1 = new Retangulo(10,20);

Console.WriteLine("Lado: "+r1.Lado+" Base: "+r1.Base);
Console.WriteLine(r1.Area);
Console.WriteLine(r1.Perimetro);

//-------------------------------------------------

Circulo c1 = new Circulo(10);

Console.WriteLine(c1.Raio);
Console.WriteLine(c1.Area);
Console.WriteLine(c1.Perimetro);