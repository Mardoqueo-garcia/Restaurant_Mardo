using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Mardo
{
    public class MyHomeMasterFlyoutMenuItem
    {
        public MyHomeMasterFlyoutMenuItem()
        {
            TargetType = typeof(MyHomeMasterFlyoutMenuItem);
        }

        public int Id { get; set; }

        //para pasarle el titulo que tendra nuestra lista en pantalla
        public string Title { get; set; }

        //para pasarle los iconos que mostraremos en nuestra lista en pantalla
        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }
}