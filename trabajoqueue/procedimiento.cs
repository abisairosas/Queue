using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace trabajoqueue
{
    class procedimiento
    {
        public void proceso()
        {
            #region VARIBLES Y METODOS
            //VARIABLES
            int OPCION = 0;
            int id = 0;
            string nombre = "";
            string apellido = "";
            string rfc = "";
            double retiro = 0.0;
            //SE GENERA EL TIPO DE METODO A UTILIZAR
            Queue datos = new Queue();
            Stack<almacenamiento> guardar = new Stack<almacenamiento>();
            #endregion
            //PROCESO DO PARA INICIAR
            do
            {
                //SE INICIA UN DO PARA HACER UN CICLO DEL MENU
                do
                {
                    Console.Clear();
                    Console.WriteLine("                                     MENÚ");
                    Console.WriteLine("=============================================================================");
                    Console.WriteLine("1.- REGISTRAR");
                    Console.WriteLine("2.- IMPRIMIR DATOS CON RETIRO MAYOR A [1000]");
                    Console.WriteLine("3.- IMPRIMIR DATOS CON MENOR MAYOR A [1000]");
                    Console.WriteLine("4.- DAR DE ALTA EL REGISTRO");
                    Console.WriteLine("5.- IMPRIMIR DATOS DE LOS REGISTROS");
                    Console.WriteLine("6.- SALIR");
                    Console.WriteLine("=============================================================================");
                    Console.WriteLine("INGRESE UN NUMERO DEL MENÚ");
                    OPCION = Convert.ToInt32(Console.ReadLine());
                } while (OPCION < 1 || OPCION > 6);
                Console.Clear();
                //FINALIZO EL CICLO DEL DO EN EL MENU
                //SIGUE EL CILO PRIMERO PARA EL SWICHT 
                #region METODO DEL SWICHT
                switch (OPCION)
                {
                    case 1:
                        {
                          
                            Console.WriteLine("INGRESE SU ID [número]");
                             id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("INGRESE EL NOMBRE");
                             nombre = Console.ReadLine();
                            Console.WriteLine("INGRESE EL APELLIDO");
                             apellido = Console.ReadLine();
                            Console.WriteLine("INGRESE SU RFC");
                             rfc = Console.ReadLine();
                            Console.WriteLine("INGRESE LA CANTIDAD A RETIRAR");
                             retiro = Convert.ToDouble(Console.ReadLine());
                            datos.Enqueue(id);
                            guardar.Push(new almacenamiento()
                            {
                                id = id,
                                nombre = nombre,
                                apellido=apellido,
                                rfc=rfc,
                                retiro=retiro
                            });
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("INFORMACIÓN DE RETIRO MAYOR A [1000]");
                            Console.WriteLine("==================================================================");
                            datosmayor(guardar);
                            Console.WriteLine("\nPREIONA UNA TECLA PARA CONTINUAR");
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("INFORMACIÓN DE RETIRO MENOR A [1000]");
                            Console.WriteLine("==================================================================");
                            datosmmenor(guardar);
                            Console.WriteLine("\nPREIONA UNA TECLA PARA CONTINUAR");
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("ELIMINACIÓN DE PRIMER REGISTRO");
                            Console.WriteLine("==========================================================");
                            datos.Dequeue();
                            Console.WriteLine("PERSONA DADA DE ALTA");
                            Console.WriteLine("==========================================================");
                            Console.WriteLine("\nPREIONA UNA TECLA PARA CONTINUAR");
                            Console.ReadLine();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("INFORMACIÓN DE TODOS LOS REGISTROS");
                            Console.WriteLine("=================================================================");
                            imprimirtodos(guardar);
                            Console.WriteLine("\nPREIONA UNA TECLA PARA CONTINUAR");
                            Console.ReadLine();
                            break;
                        }
                }
                #endregion
                //SALIO DEL CICLO DEL SWHICT PARA INICIAR DE NUEVO EL DO O SALIR DE LA APP
            } while (OPCION != 6);
            Console.WriteLine("PRECIONE UN TECLA PARA CONTINUAR");

        }
        //SE MOSTRARAN TODOS LOS DATOS
        #region MOSTRAR TODOS LOS DATOS
        public static void imprimirtodos(Stack<almacenamiento> fila)
        {
            foreach (var d in fila)
            {
                Console.WriteLine("ID: {0}", d.id);
                Console.WriteLine("NOMBRE: {0}", d.nombre);
                Console.WriteLine("APELLIDO: {0}", d.apellido);
                Console.WriteLine("RFC: {0}", d.rfc);
                Console.WriteLine("CANTIDAD {0}", d.retiro);
                Console.WriteLine("======================================");
            }
        }
        #endregion
        //SOLO MOSTRAR DATOS MAYOR A 1000
        #region MOSTRAR DATOS MAYORES A 1000
        public static void datosmayor(Stack<almacenamiento> mayor)
        {
            foreach (var d in mayor)
            {
                if (d.retiro>= 1000)
                {
                Console.WriteLine("ID: {0}", d.id);
                Console.WriteLine("NOMBRE: {0}", d.nombre);
                Console.WriteLine("APELLIDO: {0}", d.apellido);
                Console.WriteLine("RFC: {0}", d.rfc);
                Console.WriteLine("CANTIDAD {0}", d.retiro);
                Console.WriteLine("======================================");
                }
            }
        }
        #endregion
        //SOLO MOSTRAR DATOS MENOR A 1000
        #region MOSTRAR DATOS MENOR A 1000
        public static void datosmmenor(Stack<almacenamiento> menor)
        {
            foreach (var d in menor)
            {
                if (d.retiro < 1000)
                {
                    Console.WriteLine("ID: {0}", d.id);
                    Console.WriteLine("NOMBRE: {0}", d.nombre);
                    Console.WriteLine("APELLIDO: {0}", d.apellido);
                    Console.WriteLine("RFC: {0}", d.rfc);
                    Console.WriteLine("CANTIDAD {0}", d.retiro);
                    Console.WriteLine("======================================");
                }
            }
        }
        #endregion
    }
}
