using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISynthSounds
{
    public interface ISynthPlugin
    {
        string Name { get; }
        string Description { get; }
        //notes
        float C { get; }
        float C_S { get; }
        float D { get; }
        float D_S { get; }
        float E { get; }
        float F { get; }
        float F_S { get; }
        float G { get; }
        float G_S { get; }
        float A { get; }
        float A_S { get; }
        float B { get; }
        //playing function
        void PlayNote(float f);
    }
}
