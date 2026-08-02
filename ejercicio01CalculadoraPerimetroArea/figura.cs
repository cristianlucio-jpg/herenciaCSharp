using System;

/// <summary>
/// Clase abstracta que representa una figura geométrica.
/// Define el contrato para calcular área y perímetro.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
public abstract class figura
{
    public string nombreFigura { get; set; } //Longitud ingresada en centimentros
    
    /// <summary>
    /// Constructor de la clase Figura.
    /// </summary>
    /// <param name="nombreFigura">Nombre de la figura.</param>
    public figura(string nombreFigura)
    {
        this.nombreFigura = nombreFigura;
    }

    public abstract double areaFigura();

    public abstract double perimetroFigura();

    public virtual void mostrarInformacion()
    {
        Console.WriteLine($"Figura: {nombreFigura}");
    }
}
