namespace Tarea2_;
class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona();
        persona.MostrarDatos();
        persona.nombre = "Yahir malvadin beshito";
        Apartamento nuevoApartamento = new Apartamento();
        Puerta nuevaPuerta = new Puerta();
        nuevaPuerta.SetColor("Morado\n");
        nuevoApartamento.SetPuerta(nuevaPuerta);
        persona.SetCasa(nuevoApartamento);
        persona.MostrarDatos();
    }
}
