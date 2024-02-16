using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Enums
{
    public enum Category
    {
        ///<summary>
        ///0 - Outras
        ///</summary>
        [Description("Outras")]
        Other = 0,

        ///<summary>
        ///1 - Ficção Científica
        ///</summary>
        [Description("Ficção Científica")]
        ScienceFiction = 1,

        ///<summary>
        ///2 - Romance
        ///</summary>
        [Description("Romance")]
        Romance = 2,

        ///<summary>
        ///3 - Mistério
        ///</summary>
        [Description("Mistério")]
        Mystery = 3,

        ///<summary>
        ///4 - Suspense
        ///</summary>
        [Description("Suspense")]
        Thriller = 4,

        ///<summary>
        ///5 - Fantasia
        ///</summary>
        [Description("Fantasia")]
        Fantasy = 5,

        ///<summary>
        ///6 - Não Ficção
        ///</summary>
        [Description("Não Ficção")]
        NonFiction = 6,

        ///<summary>
        ///7 - Biografia
        ///</summary>
        [Description("Biografia")]
        Biography = 7,

        ///<summary>
        ///8 - Autoajuda
        ///</summary>
        [Description("Autoajuda")]
        SelfHelp = 8,

        ///<summary>
        ///9 - História
        ///</summary>
        [Description("História")]
        History = 9,

        ///<summary>
        ///10 - Poesia
        ///</summary>
        [Description("Poesia")]
        Poetry = 10
    }
}
