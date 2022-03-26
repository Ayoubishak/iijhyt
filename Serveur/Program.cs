using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using IGestEmpBiblio;
using MySql.Data.MySqlClient;
namespace Serveur
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Getting Connection ...");
          //  MySqlConnection conn = GestEmpBiblioImpl.GetDBConnection();
            /*
                        try
                        {
                            Console.WriteLine("Openning Connection ...");

                            conn.Open();

                            Console.WriteLine("Connection successful!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                        }

               Console.Read();
               */

            try
            {
                BiblioImpl.Rendu += GestEmpImpl.notifierParEmail;
                TcpChannel channel = new TcpChannel(1069);
                ChannelServices.RegisterChannel(channel, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(BiblioImpl), "class1", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(GestEmpImpl), "class2", WellKnownObjectMode.Singleton);
                //RemotingConfiguration.RegisterWellKnownServiceType(typeof(MailBox), "ObjMailBox", WellKnownObjectMode.SingleCall);
                //  RemotingConfiguration.RegisterWellKnownServiceType(typeof(Fabrique), "ObjMailBox", WellKnownObjectMode.Singleton);
                Console.WriteLine("Serveur démarré...");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Serveur: Erreur d'initialisation !" + ex.Message);
            }
        }

                
        }
}
