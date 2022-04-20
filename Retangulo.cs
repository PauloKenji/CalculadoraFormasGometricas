public class Retangulo{
    private double LadoValor;
    public double Lado
    {
        get { return LadoValor; }
        set { 
            LadoValor = value; 
            ValidarValor(LadoValor);
        }
    }
    private double BaseValor;
    public double Base
    {
        get { return BaseValor; }
        set 
        { 
            BaseValor = value; 
            ValidarValor(LadoValor);
        }
    }
    public double Area { get => Lado * Base; }
    public double Perimetro { get => 2 * (Lado + Base); }

    public Retangulo(double Lado, double Base)
    {
        this.Lado = Lado;
        this.Base = Base;
    }

    public void ValidarValor(double Valor){
        if(Valor <= 0) throw new ArgumentException("Valor não pode ser igual ou menor que zero");
    }

    
}