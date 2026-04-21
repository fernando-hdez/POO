using System;

class Program {
    internal class Usuario {
        public string nombre;
        public string mail;
        public string password;

        public void mostrarNombre() {
            Console.WriteLine($"Mi nombre es {nombre}");
        }
    }
    public class Administrador : Usuario {
        public string id;
        
        public void ExpulsarUsuario() {
            Console.WriteLine("Eliminando usuario...");
        }
        public void AgregandoUsuario() {
            Console.WriteLine("Agregando usuario...");
        }
    }
    public class Moderador : Usuario {
        public string id;
        
        public void EliminarMensaje() {
            Console.WriteLine("Eliminando mensaje...");
        }
    }


    internal class Arbol {
        public string especie;
        public float altura;
        public string fruto;

        public void MostrarFruto() {
            Console.WriteLine($"Este arbol da {fruto}");
        }
    }
    public class Manzano : Arbol {
        string especie = "manzano";
        float altura = 280;
        string fruto = "manzanas";
    }

    public class Palmera : Arbol {
        string especie = "palmera";
        float altura = 350;
        string fruto = "cocos";
    }


    internal class primate {
        public float altura;
        public float peso;

        public void MostrarPeso() {
            Console.WriteLine($"Este primate pesa {peso} kilos");
        }
    }
    public class gorila : primate {
        float altura = 170;
        float peso = 50000;

        public void MostrarPeso() {
            Console.WriteLine($"Este primate es un gorila y pesa {peso} kilos");
        }
    }
    public class capuccino : primate {
        float altura = 47;
        float peso = 100;
    }

    static void Main(string[] args) {
        gorila gorila = new gorila();
        gorila.MostrarPeso();

        Administrador administrador = new Administrador();
        administrador.AgregandoUsuario();
    }
}