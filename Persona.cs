namespace Tarea2_;

class Persona{
    public string nombre = "";

    public Casa casa;

    public Persona(){

        this.nombre = "Juan";

        this.casa = new Casa(150);
    }

    public Persona(string nombre, Casa casa){

        this.nombre = nombre;

        this.casa = casa;
    }

    public void SetNombre(string nombre){

        this.nombre = nombre;
    }

    public void SetCasa(Casa casa){

        this.casa = casa;
    }

    public void MostrarDatos(){
        Console.WriteLine("Mi nombre es " + nombre);

        casa.MostrarDatos();
        casa.puerta.MostrarDatos();
    }
}