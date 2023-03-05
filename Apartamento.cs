namespace Tarea2_;

    class Apartamento : Casa{

        public Apartamento(): base(50){
        }

        override public void MostrarDatos(){
            Console.WriteLine("Soy un Apartamento, mi area es " + this.area + " m2");
        }
    }