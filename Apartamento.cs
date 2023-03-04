namespace Tarea2_;

    class Apartamento : Casa{

        public Apartamento(): base(50){
        }

        new public void MostrarDatos(){
            Console.WriteLine("Soy una Apartamento, mi area es " + area + " m2");
        }
    }