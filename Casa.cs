namespace Tarea2_;

class Casa{

    public int area;

    public Puerta puerta = new Puerta();

    public Casa(int area){
        this.puerta = new Puerta(); 
    }

    public void SetArea(int area){
        this.area = area;
    }

    public void SetPuerta(Puerta puerta){
        this.puerta = puerta;
    }

    public void MostrarDatos(){
        Console.WriteLine("Soy una Casa, mi área es " + this.area + " m2");
    }
}