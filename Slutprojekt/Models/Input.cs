using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt.Models
{
  public class Input
  {
    public Keys Down { get; set; }

    public Keys Left { get; set; }

    public Keys Right { get; set; }

    public Keys Up { get; set; }

    public Keys Attack{ get; set; }

    public Keys currentkey {get; set;}
    public Keys lastkey {get; set;}

   

  }
}