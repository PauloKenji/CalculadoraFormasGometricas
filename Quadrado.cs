public class Quadrado{
    private double LadoValue;
    public double Lado
    {
        get { return LadoValue; }
        set 
        { 
            LadoValue = value; 
            VerificarValor(LadoValue); 
        }
    }    
    public double Area { get => Lado*Lado; }
    public double Perimetro { get => Lado * 4; }

    public Quadrado(double Lado)
    {
        this.Lado = Lado;
    }

    public void VerificarValor(double Lado){
        if(Lado <= 0) throw new ArgumentException("Lado não pode ser menor ou igual a zero");
    }
    
}