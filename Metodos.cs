using System;
namespace CopiarBitacoras
{
    class Metodos
    {
        //Obtener fecha
        DateTime fechaHoy = DateTime.Now.Date;
        

        //Rutas y ficheros 
        private  string _origenNombre="";
        private  string _destinoNombre="";
        private  string _origen="";
        private  string _destino="";
        
            public  string origenNombre {
                get
                {
                    return _origenNombre; 
                }
                set
                {
                    _origenNombre = value;
                }
            }

            public  string destinoNombre {
                get
                {
                    return _destinoNombre;
                }
                set
                {
                    _destinoNombre = value;;
                }
            }
            public  string origen{
                get
                {
                    return _origen;
                }
                set
                {
                    _origen = value;
                }
            }
            public string destino{
                get
                {
                    return _destino;
                }          
                set
                {
                    _destino = value;
                }
            }
        public void Copiar()
        {
            //Define rutas
            string sourceFile = System.IO.Path.Combine(origen,origenNombre);
            string destFile = System.IO.Path.Combine(destino,destinoNombre);

            //Leer si existe el archivo
                //Dado caso verifico si existe el archivo
                if (System.IO.File.Exists(destFile))
                {
                    //Se da aviso que existe el archivo
                    Console.WriteLine("El archivo " + destinoNombre + " ya existe!!!");
                }
                else
                {
                    //caso que la ruta tenga la extension correcta, pero el archivo no exista en el disco
                    // Se realiza la copia
                    //Copia el archivo
                    System.IO.File.Copy(sourceFile,destFile,true);
                    Console.WriteLine("Se copio " + destinoNombre );
                }

        }

    }
}