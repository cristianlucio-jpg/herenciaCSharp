/// <summary>
/// Clase que representa una elipse.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
public class elipse : figura 
{
    public double semiejeMenorElipse { get; set; } //valor ingresado en cm.
    public double semiejeMayorElipse { get; set; } //valor ingresado en cm

    /// <summary>
    /// Constructor de la clase Elipse.
    /// </summary>
    /// <param name="semiejeMayorElipse">Longitud del semieje mayor.</param>
    /// <param name="semiejeMenorElipse">Longitud del semieje menor.</param>
    public elipse(double semiejeMayorElipse, double semiejeMenorElipse) 
    : base("Elipse")
    {
        this.semiejeMayorElipse = semiejeMayorElipse;
        this.semiejeMenorElipse = semiejeMenorElipse;
    }

    /// <summary>
    /// Calcula el perímetro aproximado de la elipse.
    /// </summary>
    /// <returns>Perímetro = π * (semiejeMayor + semiejeMenor).</returns>
    public override double perimetroFigura() 
    => Math.PI * (semiejeMayorElipse + semiejeMenorElipse);
     
    /// <summary>
    /// Calcula el área de la elipse.
    /// </summary>
    /// <returns>Área = π * semiejeMayor * semiejeMenor.</returns>
    public override double areaFigura() => Math.PI * semiejeMayorElipse 
    * semiejeMenorElipse;
     
    /// <summary>
    /// Muestra información detallada de la elipse.
    /// </summary>
    public override void mostrarInformacion()
    {
        Console.WriteLine($"Figura: {nombreFigura} - SemiejeMayor: {semiejeMayorElipse} ");
        Console.Write($"- SemiejeMenor: {semiejeMenorElipse} - Perímetro: {perimetroFigura()}");
        Console.Write($"- Área: {areaFigura()}");
    }
}
                            