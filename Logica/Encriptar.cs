using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Encriptar
    {
        static string key = "May123*";
        public static string ficPruebas = Path.Combine(Application.StartupPath, "Clave.xml");
        public static UTF8Encoding UTFEnc = new UTF8Encoding();
        public static RSACryptoServiceProvider RSACryp = new RSACryptoServiceProvider();
        public static byte[] byteString, byteEncriptar, byteDescencriptar;
        public static string strDesencriptar = string.Empty;
        public static string strEncriptar = string.Empty;

        public static void crearXMLclaves(string ficPruebas)
        {
            string xmlKey = RSACryp.ToXmlString(true);
            string dirPruebas = Path.GetDirectoryName(ficPruebas);
            if (Directory.Exists(dirPruebas) == false)
            {
                Directory.CreateDirectory(dirPruebas);
            }
            using (StreamWriter sw = new StreamWriter(ficPruebas, false, Encoding.UTF8))
            {
                sw.WriteLine(xmlKey);
                sw.Close();
            }
        }

        public static string Lee_clavesXML(string fichero)
        {
            string s;

            using (StreamReader sr = new StreamReader(fichero, Encoding.UTF8))
            {
                s = sr.ReadToEnd();
                sr.Close();
            }

            return s;
        }

        public static string Encriptar1(string texto)
        {
            //arreglo de bytes donde guardaremos la llave
            byte[] keyArray;
            //arreglo de bytes donde guardaremos el texto
            //que vamos a encriptar
            byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);

            //se utilizan las clases de encriptación
            //provistas por el Framework
            //Algoritmo MD5
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            //se guarda la llave para que se le realice
            //hashing
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            //Algoritmo 3DAS
            TripleDESCryptoServiceProvider tdes =
            new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            //se empieza con la transformación de la cadena
            ICryptoTransform cTransform =
            tdes.CreateEncryptor();

            //arreglo de bytes donde se guarda la
            //cadena cifrada
            byte[] ArrayResultado =
            cTransform.TransformFinalBlock(Arreglo_a_Cifrar,
            0, Arreglo_a_Cifrar.Length);

            tdes.Clear();

            //se regresa el resultado en forma de una cadena
            return Convert.ToBase64String(ArrayResultado,
            0, ArrayResultado.Length);
        }

        public static string Descencriptar1(string textoEncriptado)
        {
            byte[] keyArray;
            //convierte el texto en una secuencia de bytes
            byte[] Array_a_Descifrar =
            Convert.FromBase64String(textoEncriptado);

            //se llama a las clases que tienen los algoritmos
            //de encriptación se le aplica hashing
            //algoritmo MD5
            MD5CryptoServiceProvider hashmd5 =
            new MD5CryptoServiceProvider();

            keyArray = hashmd5.ComputeHash(
            UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes =
            new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform =
            tdes.CreateDecryptor();

            try
            {
                byte[] resultArray =
                   cTransform.TransformFinalBlock(Array_a_Descifrar,
                   0, Array_a_Descifrar.Length);

                tdes.Clear();
                //se regresa en forma de cadena
                return UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch (Exception)
            {
                return null;
            }
        }

        //public static string Encriptar1(string texto)
        //{
        //    if (File.Exists(ficPruebas) == false)
        //    {
        //        crearXMLclaves(ficPruebas);
        //    }

        //    string xmlKeys = Lee_clavesXML(ficPruebas);
        //    RSACryp.FromXmlString(xmlKeys);
        //    if (!(string.IsNullOrEmpty(texto)))
        //    {
        //        try
        //        {
        //            byteString = UTFEnc.GetBytes(texto);
        //            byteEncriptar = RSACryp.Encrypt(byteString, false);
        //            strEncriptar = Convert.ToBase64String(byteEncriptar);
        //        }
        //        catch (Exception e)
        //        {
        //            MessageBox.Show(e.Message);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Escriba un Texto a Encriptar");
        //    }
        //    return (strEncriptar);
        //}

        //public static string Descencriptar1(string texto)
        //{
        //    string xmlKeys = Lee_clavesXML(ficPruebas);
        //    RSACryp.FromXmlString(xmlKeys);
        //    if (!(string.IsNullOrEmpty(texto)))
        //    {
        //        try
        //        {
        //            byteString = Convert.FromBase64String(texto);
        //            byteDescencriptar = RSACryp.Decrypt(byteString, false);
        //            strDesencriptar = UTFEnc.GetString(byteDescencriptar, 0,
        //            byteDescencriptar.Length);
        //        }
        //        catch (Exception e)
        //        {
        //            MessageBox.Show(e.Message);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Escriba un Texto a Encriptar");
        //    }
        //    return (strDesencriptar);
        //}
    }
}
