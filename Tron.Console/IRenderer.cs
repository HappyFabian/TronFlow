using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Console
{
    public interface IRenderer
    {
        void SetBoardSize(int width, int height);
        void RenderBoard();
    }
}
