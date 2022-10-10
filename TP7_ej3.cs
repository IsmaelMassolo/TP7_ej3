/*Crear una aplicación que solicite la temperatura diaria promedio para el lapso de una
semana (7 días). Al finalizar se debe informar cual es la temperatura mínima registrada,
cual la máxima y a que numero de día corresponde en cada caso.*/

using System;
namespace TP7_ej3
{
    class Program
    {       
        static void Main(string[] args)
        {
            int diaMax = 0, diaMin=0;
            float minima = 1000, maxima= -1000, tempD1=0, tempD2= 0, tempD3= 0, tempD4= 0, tempD5= 0, tempD6= 0, tempD7= 0;
            string temperatura="";
            for (int dia = 1; dia < 8; dia ++)
            {   
                titulo();
                Console.WriteLine("Ingrese la temperatura del "+ dia+"° día en grados Celcius");
                temperatura = Console.ReadLine ();
                switch (dia)
                {  
                    case 1: tempD1 = Convert.ToSingle(temperatura);
                        if (tempD1<minima){minima = Convert.ToSingle(temperatura); diaMin = dia;}
                        if (tempD1>maxima){maxima = Convert.ToSingle(temperatura); diaMax = dia;}
                    break;
                    case 2: tempD2 = Convert.ToSingle(temperatura);
                        if (tempD2<minima){minima = Convert.ToSingle(temperatura); diaMin = dia;}
                        if (tempD2>maxima){maxima = Convert.ToSingle(temperatura); diaMax = dia;}
                    break;
                    case 3: tempD3 = Convert.ToSingle(temperatura);
                        if (tempD3<minima){minima = Convert.ToSingle(temperatura); diaMin = dia;}
                        if (tempD3>maxima){maxima = Convert.ToSingle(temperatura); diaMax = dia;}
                    break;
                    case 4: tempD4 = Convert.ToSingle(temperatura);
                        if (tempD4<minima){minima = Convert.ToSingle(temperatura); diaMin = dia;}
                        if (tempD4>maxima){maxima = Convert.ToSingle(temperatura); diaMax = dia;}
                    break;
                    case 5: tempD5 = Convert.ToSingle(temperatura);
                        if (tempD5<minima){minima = Convert.ToSingle(temperatura); diaMin = dia;}
                        if (tempD5>maxima){maxima = Convert.ToSingle(temperatura); diaMax = dia;}
                    break;
                    case 6: tempD6 = Convert.ToSingle(temperatura);
                        if (tempD6<minima){minima = Convert.ToSingle(temperatura); diaMin = dia;}
                        if (tempD6>maxima){maxima = Convert.ToSingle(temperatura); diaMax = dia;}
                    break;
                    case 7: tempD7 = Convert.ToSingle(temperatura);
                        if (tempD7<minima){minima = Convert.ToSingle(temperatura); diaMin = dia;}
                        if (tempD7>maxima){maxima = Convert.ToSingle(temperatura); diaMax = dia;}
                    break;
                }
            }
            titulo();
            Console.WriteLine("La temperatura mínima registrada es de "+ minima +"° C., correspondiente al dia número "+diaMin);
            Console.WriteLine("La temperatura máxima registrada es de "+ maxima +"° C., correspondiente al dia número "+diaMax);
        }
        static void titulo ()
        {
            Console.Clear();
            Console.WriteLine ("<<<<<<<<<<TEMPERATURAS SEMANALES>>>>>>>>>>\n");
        }
    }
}