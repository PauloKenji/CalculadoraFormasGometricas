public class Circulo
{
    private double RaioValor;
    public double Raio
    {
        get { return RaioValor; }
        set 
        { 
            RaioValor = value; 
            ValidarValor(RaioValor);
        }
    }
    public double Area { get => Math.PI * (Raio * Raio); }
    public double Perimetro { get => (2 * Math.PI) * Raio; }

    public Circulo(double Raio)
    {
        this.Raio = Raio;
    }

    public void ValidarValor(double Valor)
    {
        if(Valor <= 0) throw new ArgumentException("Raio não pode ser menor ou igual a zero");
    }
    
}