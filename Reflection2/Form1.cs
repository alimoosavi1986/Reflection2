using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflection2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            //string typeClass;
            //foreach (Type item in types)
            //{
            //    if (item.IsClass)
            //    {
            //        typeClass = item.Name;
            //    }
            //}

            //var referencedAssemblies = Assembly.GetExecutingAssembly().GetReferencedAssemblies();
            //var referencedTypes = referencedAssemblies.SelectMany(x => Assembly.Load(x.FullName).GetTypes());


            //Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            //List<Assembly> myAssemblies = new List<Assembly>();

            //foreach (Assembly assembly in assemblies)
            //{
            //    if (assembly.GetName().Name.Contains("Classes"))
            //    {
            //        myAssemblies.Add(assembly);
            //    }
            //}

        }

        private void btnGetClassNameWithSpeceficAttribute_Click(object sender, EventArgs e)
        {

            Assembly assembly = Assembly.LoadFrom(@"C:\\Users\\Ali\\Desktop\\Reflection\\Reflection2\\Classes\\bin\\Debug\\Classes.dll");
            Type[] types = assembly.GetTypes();
            string typeClass;
            foreach (Type item in types)
            {
                if (item.IsClass)
                {
                    foreach (Attribute attr in item.GetCustomAttributes(false))
                    {
                        if (attr.GetType().Name== "Check")
                        {
                            listBox1.Items.Add(item.Name);
                        }
                    }
                }
            }

        }
    }
}
