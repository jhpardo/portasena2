public class Automovil {
    string color;
    string marca;
    string modelo;
    int anio;
    int velocidadmax;
    double creditos;

    public Automovil()
    {
    }

    public Automovil(string color, string marca, string modelo, int anio, int velocidadmax, double creditos)
    {
        this.color = color;
        this.marca = marca;
        this.modelo = modelo;
        this.anio = anio;
        this.velocidadmax = velocidadmax;
        this.creditos = creditos;
    }

    public void rodar(){
        Console.WriteLine($"Vehiculo... Marca: {this.marca} Modelo: {this.modelo} Año: {this.anio}");
        Console.WriteLine("Vehículo rodando " + "*" + "*" + "*" + "*");
    }

    public void comprarAutomovil(double salCredits, double valCredits){

        if (salCredits < valCredits)
        {
            Console.WriteLine("No tiene suficiente saldo");
        }

    }


}