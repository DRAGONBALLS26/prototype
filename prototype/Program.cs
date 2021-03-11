using System;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Invitatie obj1 = new Invitatie();
            obj1.p_Catre = "Dan";
            obj1.p_Titlu = "Invitatie la ziua mea de nastere";
            obj1.p_Continut = "Deci , baieti va invit la ziua mea de nastere!!!";
            obj1.TrimisDe= "Dragomir";
            obj1.p_Data = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            //Here our first object has created  
            Invitatie[] objList = new Invitatie[6];
            String[] nameList = { "Dan", "Cristi", "Alin", "Stefan", "Lucian", "Dummitru" };
            int i = 0;
            foreach (String name in nameList)
            {
                //objList[i] = new Invitie();  
                objList[i] = obj1.CloneMe(obj1);
                objList[i].p_Catre = nameList[i];
                i++;
            }
            // Print all Invitation Card here  
            foreach (Invitatie obj in objList)
            {
                Console.WriteLine("To :- " + obj.p_Catre);
                Console.WriteLine("Title :- " + obj.p_Titlu);
                Console.WriteLine("Content :- " + obj.p_Continut);
                Console.WriteLine("Send By :- " + obj.p_TrimisDe);
                Console.WriteLine("Date :- " + obj.Data);
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
    }

