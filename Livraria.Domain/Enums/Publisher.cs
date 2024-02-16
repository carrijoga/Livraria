using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Enums
{
    public enum Publisher
    {
        ///<summary>
        ///0 - Outras
        ///</summary>
        [Description("Outras")]
        Other = 0,

        ///<summary>
        ///1 - Companhia das Letras
        ///</summary>
        [Description("Companhia das Letras")]
        CompanhiaDasLetras = 1,

        ///<summary>
        ///2 - Editora Record
        ///</summary>
        [Description("Editora Record")]
        EditoraRecord = 2,

        ///<summary>
        ///3 - Editora Sextante
        ///</summary>
        [Description("Editora Sextante")]
        EditoraSextante = 3,

        ///<summary>
        ///4 - Intrínseca
        ///</summary>
        [Description("Intrínseca")]
        Intrinseca = 4,

        ///<summary>
        ///5 - Editora Rocco
        ///</summary>
        [Description("Editora Rocco")]
        EditoraRocco = 5,

        ///<summary>
        ///6 - Editora Globo
        ///</summary>
        [Description("Editora Globo")]
        EditoraGlobo = 6,

        ///<summary>
        ///7 - Editora Objetiva
        ///</summary>
        [Description("Editora Objetiva")]
        EditoraObjetiva = 7,

        ///<summary>
        ///8 - Editora Abril
        ///</summary>
        [Description("Editora Abril")]
        EditoraAbril = 8,

        ///<summary>
        ///9 - Editora Saraiva
        ///</summary>
        [Description("Editora Saraiva")]
        EditoraSaraiva = 9,

        ///<summary>
        ///10 - Editora Nova Fronteira
        ///</summary>
        [Description("Editora Nova Fronteira")]
        EditoraNovaFronteira = 10
    }
}
