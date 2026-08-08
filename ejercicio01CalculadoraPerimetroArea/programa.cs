/// <summary>
/// Clase principal del programa (programa).
/// Se encarga de ejecutar el método Main, inicializar figuras con valores predefinidos
/// y mostrar el cálculo de área y perímetro.
/// </summary>

/// <author>Cristian Alexis Lucio Narváez</author>
using System;
class programa
{
    static void Main(string[] args)
    {
        // Rectángulo (nombre, base, altura)
        rectangulo rectangulo = new rectangulo("Rectángulo", 5, 10);
        Console.Write($"Rectángulo - Perímetro: {rectangulo.perimetroFigura():0.##} ");
        Console.WriteLine($"- Área: {rectangulo.areaFigura():0.##}");

       // círculo (nombre, radio)
        circulo circulo = new circulo("Círculo", 7);
        Console.Write($"Círculo - Perímetro: {circulo.perimetroFigura():0.##} ");
        Console.WriteLine($"- Área: {circulo.areaFigura():0.##}");

        // elipse (semiejeMayor, semiejeMenor)
        elipse elipse = new elipse(6, 4);
        Console.Write($"Elipse - Perímetro: {elipse.perimetroFigura():0.##} ");
        Console.WriteLine($"- Área: {elipse.areaFigura():0.##}");

        // trapecio (nombre, baseMayor, baseMenor, lado1, lado2, altura)
        trapecio trapecio = new trapecio("Trapecio", 10, 6, 5, 5, 4);
        Console.Write($"Trapecio - Perímetro: {trapecio.perimetroFigura():0.##} ");
        Console.WriteLine($"- Área: {trapecio.areaFigura():0.##}");

        // rombo (lado, diagonalMayor, diagonalMenor)
        rombo rombo = new rombo(4, 6, 4);
        Console.Write($"Rombo - Perímetro: {rombo.perimetroFigura():0.##} ");
        Console.WriteLine($"- Área: {rombo.areaFigura():0.##}");

        // Cuadrado (nombre, lado)
        cuadrado cuadrado = new cuadrado("Cuadrado", 5);
        Console.Write($"Cuadrado - Perímetro: {cuadrado.perimetroFigura():0.##} ");
        Console.WriteLine($"- Área: {cuadrado.areaFigura():0.##}");

        // triangulo(lado1Triangulo, lado2Triangulo, lado3Triangulo, baseTriangulo, alturaTriangulo)
        triangulo triangulo = new triangulo(3, 4, 5, 3, 4);
        Console.Write($"Triángulo - Perímetro: {triangulo.perimetroFigura():0.##} ");
        Console.WriteLine($"- Área: {triangulo.areaFigura():0.##}");
    }
}
