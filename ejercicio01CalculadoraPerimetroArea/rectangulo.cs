/// <summary>
/// Clase que representa un rectángulo.
/// Hereda de figura y define su base y altura.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
public class rectangulo : figura
{
    public double baseRectangulo { get; set; } //Longitud ingresada en centimentros

    public double alturaRectangulo { get; set; } //Longitud ingresada en centimentros

    /// <summary>
    /// Constructor de la clase rectangulo.
    /// </summary>
    /// <param name="nombreFigura">Nombre de la figura.</param>
    /// <param name="baseRectangulo">Base del rectángulo.</param>
    /// <param name="alturaRectangulo">Altura del rectángulo.</param>
    public rectangulo(string nombreFigura, double baseRectangulo, double alturaRectangulo) 
        : base(nombreFigura)
    {
        this.baseRectangulo = baseRectangulo;
        this.alturaRectangulo = alturaRectangulo;
    }

    /// <summary>
    /// Calcula el perímetro del rectángulo.
    /// </summary>
    /// <returns>Perímetro = 2 * (baseRectangulo + alturaRectangulo).</returns>
    public override double perimetroFigura() => 2 * (baseRectangulo + alturaRectangulo);

    /// <summary>
    /// Calcula el área del rectángulo.
    /// </summary>
    /// <returns>Área = baseRectangulo * alturaRectangulo.</returns>
    public override double areaFigura() => baseRectangulo * alturaRectangulo;

    /// <summary>
    /// Muestra información detallada del rectángulo.
    /// </summary>
    public override void mostrarInformacion()
    {
        Console.WriteLine(
            $"Figura: {nombreFigura} - Base: {baseRectangulo} - Altura: {alturaRectangulo} - Perímetro: {perimetroFigura()} - Área: {areaFigura()}"
        );
    }
}
