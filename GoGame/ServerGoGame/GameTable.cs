using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerGoGame
{
    public class GameTable
    {
        public Player[] gamePlayer;
        public Service service;

        public GameTable(ListBox listbox)
        {
            gamePlayer = new Player[2];
            service = new Service(listbox);
        }

    }
}
