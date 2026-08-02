//// <summary>
/// Clase principal del programa (programa).
/// Se encarga de ejecutar el método Main, solicitar las dimensiones de las figuras por consola
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
        Console.WriteLine($"Rectángulo - Perímetro: {rectangulo.perimetroFigura()} - Área: {rectangulo.areaFigura()}");

       // círculo (nombre, radio)
        circulo circulo = new circulo("Círculo", 7);
        Console.WriteLine($"Círculo - Perímetro: {circulo.perimetroFigura()} - Área: {circulo.areaFigura()}");

        // elipse (semiejeMayor, semiejeMenor)
        elipse elipse = new elipse(6, 4);
        Console.WriteLine($"Elipse - Perímetro: {elipse.perimetroFigura()} - Área: {elipse.areaFigura()}");

        // trapecio (nombre, baseMayor, baseMenor, lado1, lado2, altura)
        trapecio trapecio = new trapecio("Trapecio", 10, 6, 5, 5, 4);
        Console.WriteLine($"trapecio - Perímetro: {trapecio.perimetroFigura()} - Área: {trapecio.areaFigura()}");

        // rombo (lado, diagonalMayor, diagonalMenor)
        rombo rombo = new rombo(4, 6, 4);
        Console.WriteLine($"rombo - Perímetro: {rombo.perimetroFigura()} - Área: {rombo.areaFigura()}");

        // Cuadrado (nombre, lado)
        cuadrado cuadrado = new cuadrado("Cuadrado", 5);
        Console.WriteLine($"cuadrado - Perímetro: {cuadrado.perimetroFigura()} - Área: {cuadrado.areaFigura()}");

        // triangulo(lado1Triangulo, lado2Triangulo, lado3Triangulo, baseTriangulo, alturaTriangulo)
        triangulo triangulo = new triangulo(3, 4, 5, 3, 4);
        Console.WriteLine($"Triángulo - Perímetro: {triangulo.perimetroFigura()} - Área: {triangulo.areaFigura()}");
    }
}
