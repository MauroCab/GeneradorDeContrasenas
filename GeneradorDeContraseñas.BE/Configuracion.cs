using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GeneradorDeContraseñas.BE
{
    public class Configuracion
    {
        //1
        //Mayusculas
        public void GuardarValorMayus(bool aValor)
        {
            XmlWriter escribir = XmlWriter.Create("ValorMayus.xml");

            escribir.WriteStartDocument();

            escribir.WriteStartElement("ValorDeChkMayusculas");
            escribir.WriteValue(aValor);
            escribir.WriteEndElement();

            escribir.WriteEndDocument();

            escribir.Close();

        }

        public bool LeerValorMayus()
        {
            using (XmlReader xmlReader = XmlReader.Create("ValorMayus.xml"))
            {
                bool ValorADevolver = false; 

              
                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "ValorDeChkMayusculas")
                    {
                        xmlReader.Read(); 
                        ValorADevolver = xmlReader.ReadContentAsBoolean(); 
                    }
                }

                return ValorADevolver;
            }
        }

        //Numeros

        public void GuardarValorNumeros(bool aValor)
        {
            XmlWriter escribir = XmlWriter.Create("ValorNumeros.xml");

            escribir.WriteStartDocument();

            escribir.WriteStartElement("ValorDeChkNumeros");
            escribir.WriteValue(aValor);
            escribir.WriteEndElement();

            escribir.WriteEndDocument();

            escribir.Close();

        }

        public bool LeerValorNumeros()
        {
            using (XmlReader xmlReader = XmlReader.Create("ValorNumeros.xml"))
            {
                bool ValorADevolver = false;


                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "ValorDeChkNumeros")
                    {
                        xmlReader.Read();
                        ValorADevolver = xmlReader.ReadContentAsBoolean();
                    }
                }

                return ValorADevolver;
            }
        }

        //Simbolos

        public void GuardarValorSimbolos(bool aValor)
        {
            XmlWriter escribir = XmlWriter.Create("ValorSimbolos.xml");

            escribir.WriteStartDocument();

            escribir.WriteStartElement("ValorDeChkSimbolos");
            escribir.WriteValue(aValor);
            escribir.WriteEndElement();

            escribir.WriteEndDocument();

            escribir.Close();

        }

        public bool LeerValorSimbolos()
        {
            using (XmlReader xmlReader = XmlReader.Create("ValorSimbolos.xml"))
            {
                bool ValorADevolver = false;


                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "ValorDeChkSimbolos")
                    {
                        xmlReader.Read();
                        ValorADevolver = xmlReader.ReadContentAsBoolean();
                    }
                }

                return ValorADevolver;
            }
        }

        //Longitud

        public void GuardarValorLongitud(String aValor)
        {
            XmlWriter escribir = XmlWriter.Create("ValorLongitud.xml");

            escribir.WriteStartDocument();

            escribir.WriteStartElement("ValorDeTxtbxLongitud");
            escribir.WriteValue(aValor);
            escribir.WriteEndElement();

            escribir.WriteEndDocument();

            escribir.Close();

        }

        public string LeerValorLongitud()
        {
            using (XmlReader xmlReader = XmlReader.Create("ValorLongitud.xml"))
            {
                string ValorADevolver = "";


                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "ValorDeTxtbxLongitud")
                    {
                        xmlReader.Read();
                        ValorADevolver = xmlReader.ReadContentAsString();
                    }
                }

                return ValorADevolver;
            }
        }


    }
}
