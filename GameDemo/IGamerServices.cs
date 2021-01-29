using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IGamerServices
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
