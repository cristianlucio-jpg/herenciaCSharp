# Proyecto: herenciaCSharp

## Descripción
Este proyecto contiene ejercicios en C# que aplican **herencia y polimorfismo** para modelar figuras geométricas.  
Cada clase representa una figura distinta y sobrescribe métodos para calcular **área y perímetro**, manteniendo un enfoque en **código limpio y documentado**.

## Objetivos
- Aplicar clases abstractas para definir contratos comunes.
- Implementar polimorfismo en operaciones geométricas.
- Documentar con XML y mantener código modular y claro.
- Practicar principios **SOLID** y **KISS**.

## Contenido del proyecto
| Ejercicio | Clase/Archivo | Descripción |
|-----------|---------------|-------------|
| Figuras   | circulo.cs, cuadrado.cs, elipse.cs, figura.cs, programa.cs, rectángulo.cs, rombo.cs, trapecio.cs, triangulo.cs  | Modelado de figuras geométricas con herencia y polimorfismo. |

## Pilares aplicados
- **Abstracción:** Clase abstracta `figura`.  
- **Herencia:** Figuras (`Rectangulo`, `Circulo`, etc.) heredan de `figura`.  
- **Polimorfismo:** Sobrescritura de `areaFigura`, `perimetroFigura`.  
- **Encapsulación:** Propiedades en cada figura.  

## Sobrecarga
- Constructores sobrecargados para inicializar figuras con distintos parámetros.    

## Principios aplicados
- **SOLID:** Cada clase representa una figura con responsabilidad única.  
- **SRP (Responsabilidad Única):**  
  Cada clase representa una figura geométrica con una única responsabilidad: calcular área      y perímetro.  
  Ejemplo: `circulo` gestiona únicamente el radio y sus cálculos, mientras que `rectangulo` gestiona base y altura.

- **OCP (Abierto/Cerrado):**  
  El sistema está abierto a extensión pero cerrado a modificación.  
  Puedes añadir nuevas figuras (`hexagono`, `pentagono`) sin alterar las clases existentes ni la clase abstracta `figura`.

- **LSP (Sustitución de Liskov):**  
  Todas las figuras (`rectangulo`, `circulo`, `trapecio`, etc.) heredan de `figura` y pueden usarse donde se espere una `figura`.  
  Ejemplo: una lista de `figura` puede contener cualquier tipo de figura y todas responden polimórficamente.

- **ISP (Segregación de Interfaces):**  
  Aunque no se usan interfaces explícitas, las clases no tienen métodos innecesarios.  
  Cada figura implementa solo lo que necesita: `areaFigura`, `perimetroFigura` y `mostrarInformacion`.

- **DIP (Inversión de Dependencias):**  
  El `programa` depende de la abstracción `figura` y no de detalles internos de cada clase.  
  Esto permite que el código sea flexible y escalable, ya que se basa en contratos 
- **KISS:** Métodos claros para área y perímetro.  
- **YAGNI:** Sin atributos innecesarios.  

## Estructura del proyecto
```text
figurasCSharp/
├── src/
│   └── ejercicio01CalculadoraPerimetroArea/
└── README.md

Rectángulo - Perímetro: 30 - Área: 50
Círculo - Perímetro: 43,982297150257104 - Área: 153,93804002589985
Elipse - Perímetro: 31,41592653589793 - Área: 75,39822368615503
trapecio - Perímetro: 26 - Área: 32
rombo - Perímetro: 16 - Área: 12
cuadrado - Perímetro: 20 - Área: 25
Triángulo - Perímetro: 12 - Área: 6

## Autor
Cristian Alexis Lucio Narváez  
Proyecto académico y portafolio profesional en C#.


