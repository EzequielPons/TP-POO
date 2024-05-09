
class Rectangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Rectangulo(double base, double altura)
    {
        Base = base;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return Base * Altura;
    }
}