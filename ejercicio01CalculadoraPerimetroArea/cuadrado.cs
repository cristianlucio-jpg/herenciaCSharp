/// <summary>
/// Clase que representa un cuadrado.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
public class cuadrado : figura
{
        public double ladoCuadrado { get; set; } //Longitud ingresada en centimentros

    public cuadrado(string nombreFigura, double ladoFigura) : base(nombreFigura)
    {
        this.ladoCuadrado = ladoFigura;
    }

    /// <summary>
    /// Calcula el perímetro del cuadrado.
    /// </summary>
    /// <returns>Perímetro = 4 * ladoCuadrado.</returns>
    public override double perimetroFigura() => 4 * ladoCuadrado;

    /// <summary>
    /// Calcula el área del cuadrado.
    /// </summary>
    /// <returns>Área = ladoCuadrado * ladoCuadrado.</returns>
    public override double areaFigura() => ladoCuadrado * ladoCuadrado;

    public override void mostrarInformacion()
    {
         Console.Write($"Figura: {nombreFigura} - Lado: {ladoCuadrado} ");
         Console.WriteLine($"- Perímetro: {perimetroFigura()} - Área: {areaFigura()}");
    }
    
}