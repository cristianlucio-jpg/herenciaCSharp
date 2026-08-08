/// <summary>
/// Clase que representa un trapecio.
/// Hereda de figura y define sus bases, lados y altura.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
public class trapecio : figura
{
    public double baseMayorTrapecio { get; set; } //Longitud ingresada en centimentros
    public double baseMenorTrapecio { get; set; } //Longitud ingresada en centimentros
    public double lado1Trapecio { get; set; } //Longitud ingresada en centimentros

    public double lado2Trapecio { get; set; } //Longitud ingresada en centimentros
    public double alturaTrapecio { get; set; } //Longitud ingresada en centimentros

    /// <summary>
    /// Constructor de la clase trapecio.
    /// </summary>
    /// <param name="nombreFigura">Nombre de la figura.</param>
    /// <param name="baseMayorTrapecio">Base mayor.</param>
    /// <param name="baseMenorTrapecio">Base menor.</param>
    /// <param name="lado1Trapecio">Primer lado.</param>
    /// <param name="lado2Trapecio">Segundo lado.</param>
    /// <param name="alturaTrapecio">Altura.</param>
    public trapecio(string nombreFigura, double baseMayorTrapecio, double baseMenorTrapecio, double lado1Trapecio, double lado2Trapecio, double alturaTrapecio) 
        : base(nombreFigura)
    {
        this.baseMayorTrapecio = baseMayorTrapecio;
        this.baseMenorTrapecio = baseMenorTrapecio;
        this.lado1Trapecio = lado1Trapecio;
        this.lado2Trapecio = lado2Trapecio;
        this.alturaTrapecio = alturaTrapecio;
    }

    /// <summary>
    /// Calcula el perímetro del trapecio.
    /// </summary>
    /// <returns>Suma de las bases y los lados.</returns>
    public override double perimetroFigura() => baseMayorTrapecio + baseMenorTrapecio + lado1Trapecio + lado2Trapecio;

    /// <summary>
    /// Calcula el área del trapecio.
    /// </summary>
    /// <returns>Área = ((baseMayorTrapecio + baseMenorTrapecio) * alturaTrapecio) / 2.</returns>
    public override double areaFigura() => ((baseMayorTrapecio + baseMenorTrapecio) * alturaTrapecio) / 2;

    /// <summary>
    /// Muestra información detallada del trapecio en cm.
    /// </summary>
    public override void mostrarInformacion()
    {
        Console.WriteLine(
            $"Figura: {nombreFigura} - BaseMayor: {baseMayorTrapecio} - BaseMenor: {baseMenorTrapecio} - Lado1: {lado1Trapecio} - Lado2: {lado2Trapecio} - Altura: {alturaTrapecio} - Perímetro: {perimetroFigura()} - Área: {areaFigura()}"
        );
    }
}
