/// <summary>
/// Representa un rombo con sus lados y diagonales.
/// Permite calcular el perímetro y el área.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>

public class rombo: figura
{
    /// <summary>
    /// Longitud del lado del rombo en centímetros.
    /// </summary>
    public double Lado { get; set; }

    /// <summary>
    /// Longitud de la diagonal mayor en centímetros.
    /// </summary>
    public double DiagonalMayor { get; set; }

    /// <summary>
    /// Longitud de la diagonal menor en centímetros.
    /// </summary>
    public double DiagonalMenor { get; set; }

    /// <summary>
    /// Constructor de la clase Rombo.
    /// </summary>
    /// <param name="lado">Longitud del lado en centímetros.</param>
    /// <param name="diagonalMayor">Longitud de la diagonal mayor en centímetros.</param>
    /// <param name="diagonalMenor">Longitud de la diagonal menor en centímetros.</param>
    public rombo(double lado, double diagonalMayor, double diagonalMenor): base("Rombo")
    {
        Lado = lado;
        DiagonalMayor = diagonalMayor;
        DiagonalMenor = diagonalMenor;
    }

    /// <summary>
    /// Calcula el perímetro del rombo.
    /// </summary>
    /// <returns>Perímetro en centímetros.</returns>
    public override double perimetroFigura()
    {
        return 4 * Lado;
    }

    /// <summary>
    /// Calcula el área del rombo.
    /// </summary>
    /// <returns>Área en centímetros cuadrados.</returns>
    public override double areaFigura()
    {
        return (DiagonalMayor * DiagonalMenor) / 2;
    }

     /// <summary>
    /// Muestra información detallada del rombo.
    /// </summary>
    public override void mostrarInformacion()
    {
        Console.WriteLine(
            $"Figura: {nombreFigura} - Lado: {Lado} - DiagonalMayor: {DiagonalMayor} - DiagonalMenor: {DiagonalMenor} - Perímetro: {perimetroFigura()} - Área: {areaFigura()}"
        );
    }
}
