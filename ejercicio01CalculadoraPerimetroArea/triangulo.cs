/// <summary>
/// Clase que representa un triángulo.
/// Hereda de figura y define sus bases, lados y altura.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
public class triangulo : figura
{
    
    public double lado1Triangulo { get; set; } //Longitud ingresada en centimentros
    public double lado2Triangulo { get; set; } //Longitud ingresada en centimentros
    public double lado3Triangulo { get; set; } //Longitud ingresada en centimentros  
    public double baseTriangulo { get; set; } //Longitud ingresada en centimentros  
    public double alturaTriangulo { get; set; } //Longitud ingresada en centimentros

    /// <summary>
    /// Constructor de la clase Triangulo.
    /// </summary>
    /// <param name="lado1Triangulo">Primer lado.</param>
    /// <param name="lado2Triangulo">Segundo lado.</param>
    /// <param name="lado3Triangulo">Tercer lado.</param>
    /// <param name="baseTriangulo">Base del triángulo.</param>
    /// <param name="alturaTriangulo">Altura del triángulo.</param>
    public triangulo(double lado1Triangulo, double lado2Triangulo, double lado3Triangulo, double baseTriangulo, double alturaTriangulo) : base("Triángulo")
    {
        this.lado1Triangulo = lado1Triangulo;
        this.lado2Triangulo = lado2Triangulo;
        this.lado3Triangulo = lado3Triangulo;
        this.baseTriangulo = baseTriangulo;
        this.alturaTriangulo = alturaTriangulo;
    }

    /// <summary>
    /// Calcula el perímetro del triángulo.
    /// </summary>
    /// <returns>Suma de los tres lados.</returns>
    public override double perimetroFigura()
    {
        return lado1Triangulo + lado2Triangulo + lado3Triangulo;
    }

    /// <summary>
    /// Calcula el área del triángulo.
    /// </summary>
    /// <returns>Área = (baseTriangulo * altura) / 2.</returns>
    public override double areaFigura() => (baseTriangulo * alturaTriangulo) / 2.0;
}
