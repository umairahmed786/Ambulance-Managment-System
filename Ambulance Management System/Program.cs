using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Ambulance_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static public Graph graph = new Graph();
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadData();
            LoadEcf();
            loadHospitalData();
            LoadGraph();
            FileStream fs = new FileStream("D:/Github/dsa2021g46/Ambulance Management System/employeeData.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr1 = new StreamReader(fs);
            Console.WriteLine();
            sr1.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr1.ReadLine();
            int idx1 = 0;
            while (str != null)
            {

                string a = Program.getfield(str, 0);
                string b = Program.getfield(str, 1);
                string c = Program.getfield(str, 2);
                string d = Program.getfield(str, 3);
                string e = Program.getfield(str, 4);
                string f = Program.getfield(str, 5);
                string g = Program.getfield(str, 6);
                string h = Program.getfield(str, 7);
                string i = Program.getfield(str, 8);
                string j = Program.getfield(str, 9);
                string k = Program.getfield(str, 10);

                Employee employee = new Employee(a, b, c, d, e, f, g, j, h, k, i);
                Node node = new Node(employee, null, null, null);
                addEmployee.tree.employeeAddition( node);



                idx1++;
                str = sr1.ReadLine();
            }


            Console.ReadLine();
            sr1.Close();
            fs.Close();


         


            Application.Run(new mainPage());


        }
        public static void LoadEcf()
        {
            FileStream fs = new FileStream("D:/Github/dsa2021g46/Ambulance Management System/ecfData.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr1 = new StreamReader(fs);
            Console.WriteLine();
            sr1.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr1.ReadLine();
            int idx1 = 0;
            while (str != null)
            {

                string a = Program.getfield(str, 0);
                string b = Program.getfield(str, 1);
                string c = Program.getfield(str, 2);
                string d = Program.getfield(str, 3);
                string e = Program.getfield(str, 4);
                string f = Program.getfield(str, 5);
                string g = Program.getfield(str, 6);
                string h = Program.getfield(str, 7);
                string i = Program.getfield(str, 8);
                string j = Program.getfield(str, 9);
                string k = Program.getfield(str, 10);
                string l = Program.getfield(str, 11);

                ECF_class ecf = new ECF_class(a, b, c, d, e, f, g, h, i, j, k,l);
                ECFNode node = new ECFNode(ecf, null, null, null);
                ECF.tree2.insert(node);



                idx1++;
                str = sr1.ReadLine();
            }


            Console.ReadLine();
            sr1.Close();
            fs.Close();
        }

        public static void LoadData()
        {
            StreamReader str2 = new StreamReader("D:/Github/dsa2021g46/Ambulance Management System/busData.txt");
            string data = str2.ReadLine();
            while(data!=null)
            {
                string name = getfield(data, 0);
                string color = getfield(data, 1);
                string model = getfield(data, 2);
                string number = getfield(data, 3);
                Bus b = new Bus(name, color, model, number);
                addBus.BusData.insert(new BusNode(b));
                data = str2.ReadLine();
            }
            str2.Close();
        }

        public static void loadHospitalData()
        {
            FileStream fs = new FileStream("D:/Github/dsa2021g46/Ambulance Management System/hospitalData.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr1 = new StreamReader(fs);
            Console.WriteLine();
            sr1.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr1.ReadLine();
            int idx1 = 0;
            while (str != null)
            {

                string a = Program.getfield(str, 0);
                string b = Program.getfield(str, 1);
                string c = Program.getfield(str, 2);
                string d = Program.getfield(str, 3);
                string e = Program.getfield(str, 4);
                string f = Program.getfield(str, 5);

                Hospital hospital = new Hospital(a, b, Int32.Parse(c), Int32.Parse(d), e, f);
                HospitalNode hn = new HospitalNode(hospital, null, null);
                addHospital.dll.hospitalAddition(hn);




                idx1++;
                str = sr1.ReadLine();
            }


            Console.ReadLine();
            sr1.Close();
            fs.Close();


        }
        public static void LoadGraph()
        {
            FileStream fs = new FileStream("D:/Github/dsa2021g46/Ambulance Management System/verteces.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr1 = new StreamReader(fs);
            Console.WriteLine();
            sr1.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr1.ReadLine();
            int idx1 = 0;
            while (str != null)
            {

                string a = Program.getfield(str, 0);
                string b = Program.getfield(str, 1);
                int c = Int32.Parse(Program.getfield(str, 2));
                graph.AddEdge(a,b,c);
                idx1++;
                str = sr1.ReadLine();
            }


            Console.ReadLine();
            sr1.Close();
            fs.Close();
        }

        public static string getfield(string record, int position)
        {
            int idx = 0;
            int firstspace = 0;
            string naam = "";
            while (firstspace < position + 1 && idx < record.Length)
            {
                if (record[idx] == ',')
                {
                    firstspace = firstspace + 1;
                }
                else if (firstspace == position)
                {
                    naam = naam + record[idx];
                }
                idx = idx + 1;
            }
            return naam;
        }
    }
}
