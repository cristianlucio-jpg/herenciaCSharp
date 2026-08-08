/// <summary>
/// Clase que representa un círculo.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
public class circulo : figura
{
    public double radioCirculo { get; set; } //Longitud ingresada en centimentros

    /// <summary>
    /// Constructor de la clase Circulo.
    /// </summary>
    /// <param name="nombreFigura">Nombre de la figura.</param>
    /// <param name="radioCirculo">Radio del círculo.</param>
    public circulo(string nombre, double radioCirculo) : base(nombre)
    {
        this.radioCirculo = radioCirculo;
    }

    /// <summary>
    /// Calcula el perímetro del círculo.
    /// </summary>
    /// <returns>Perímetro = 2 * π * radioCirculo.</returns>
    public override double perimetroFigura() =>  2 * Math.PI * radioCirculo;

    // <summary>
    /// Calcula el área del círculo.
    /// </summary>
    /// <returns>Área = π * radioCirculo².</returns>
    public override double areaFigura() => Math.PI * Math.Pow(radioCirculo, 2);

    public override void mostrarInformacion()
    {
        Console.WriteLine($"Figura: {nombreFigura} - Radio: {radioCirculo} - Perímetro: {perimetroFigura()} - Área: {areaFigura()}");
    }
}


