using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace EditeurCarteProjet2
{
    class InterfaceUtilisateur
    {

        Char _currentItem;
        public Char CurrentItem { get { return _currentItem; } set { _currentItem = value; } }


        Vector2 _tileSelected;

        public InterfaceUtilisateur()
        {
            _tileSelected = new Vector2(0, 0);

        }

        public void Update(MouseState _mouseState)
        {
            

            if (_mouseState.LeftButton == ButtonState.Pressed)
            {
                _currentItem = setCurrentItem(new Vector2(_mouseState.X, _mouseState.Y));
            }
        }

        public Char setCurrentItem(Vector2 _positionSouris)
        {

            Char sortie;

            Console.WriteLine(" souris : " + _positionSouris);

            if (_positionSouris.Y > 300 + 32)
            {
                _tileSelected.X = _positionSouris.X / 64;
                _tileSelected.Y = (_positionSouris.Y - (300 + 32)) / 32;
            }

            Console.WriteLine(" tileSlected : " + _tileSelected);

            if ((int)_tileSelected.X == 0 && (int)_tileSelected.Y == 0)
                sortie = 'a';
            else if ((int)_tileSelected.X == 1 && (int)_tileSelected.Y == 0)
                sortie = 'b';
            else if ((int)_tileSelected.X == 2 && (int)_tileSelected.Y == 0)
                sortie = 'c';
            else if ((int)_tileSelected.X == 3 && (int)_tileSelected.Y == 0)
                sortie = 'd';
            else if ((int)_tileSelected.X == 4 && (int)_tileSelected.Y == 0)
                sortie = 'e';
            else if ((int)_tileSelected.X == 5 && (int)_tileSelected.Y == 0)
                sortie = 'f';
            else if ((int)_tileSelected.X == 6 && (int)_tileSelected.Y == 0)
                sortie = 'g';
            else if ((int)_tileSelected.X == 7 && (int)_tileSelected.Y == 0)
                sortie = 'h';
            else if ((int)_tileSelected.X == 8 && (int)_tileSelected.Y == 0)
                sortie = 'i';
            else if ((int)_tileSelected.X == 9 && (int)_tileSelected.Y == 0)
                sortie = 'j';
            else if ((int)_tileSelected.X == 10 && (int)_tileSelected.Y == 0)
                sortie = 'k';
            else if ((int)_tileSelected.X == 11 && (int)_tileSelected.Y == 0)
                sortie = 'l';

            else if ((int)_tileSelected.X == 0 && (int)_tileSelected.Y == 1)
                sortie = 'm';
            else if ((int)_tileSelected.X == 1 && (int)_tileSelected.Y == 1)
                sortie = 'n';
            else if ((int)_tileSelected.X == 2 && (int)_tileSelected.Y == 1)
                sortie = 'o';
            else if ((int)_tileSelected.X == 3 && (int)_tileSelected.Y == 1)
                sortie = 'p';
            else if ((int)_tileSelected.X == 4 && (int)_tileSelected.Y == 1)
                sortie = 'q';
            else if ((int)_tileSelected.X == 5 && (int)_tileSelected.Y == 1)
                sortie = 'r';
            else if ((int)_tileSelected.X == 6 && (int)_tileSelected.Y == 1)
                sortie = 's';

            else if ((int)_tileSelected.X == 0 && ((int)_tileSelected.Y == 3 || (int)_tileSelected.Y == 2))
                sortie = 'T';
            else if ((int)_tileSelected.X == 1 && ((int)_tileSelected.Y == 3 || (int)_tileSelected.Y == 2))
                sortie = 'U';
            else if ((int)_tileSelected.X == 2 && ((int)_tileSelected.Y == 3 || (int)_tileSelected.Y == 2))
                sortie = 'V';
            else if ((int)_tileSelected.X == 3 && ((int)_tileSelected.Y == 3 || (int)_tileSelected.Y == 2))
                sortie = 'W';
            else if ((int)_tileSelected.X == 4 && ((int)_tileSelected.Y == 3 || (int)_tileSelected.Y == 2))
                sortie = 'X';

            else
                sortie = 'i';


            return sortie;
        }
    }
}
