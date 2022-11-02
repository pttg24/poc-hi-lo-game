using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLoGame.Services
{
    public interface IMultiPlayerModeService
    {
        void PlayGame(int min, int max, int players);
    }
}
