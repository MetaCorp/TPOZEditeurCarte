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
    class MoteurJeu
    {
        MoteurSysteme _moteurSysteme;
        MoteurPhysique _moteurPhysique;

        enum StatusJeu
        {
            PageAccueil,
            EnCours,
            enPause
        }

        StatusJeu _statusJeu;

        Carte _carte1;
        public Carte Carte1 { get { return _carte1; } set { _carte1 = value; } }

        Carte _carte2;
        public Carte Carte2 { get { return _carte2; } set { _carte2 = value; } }

        ElementDecor _elementDecor;
        public ElementDecor ElementDecor { get { return _elementDecor; } set { _elementDecor = value; } }

        Vector2 _camera;
        public Vector2 Camera { get { return _camera; } set { _camera = value; } }

        InterfaceUtilisateur _interfaceUtilisateur;

        public MoteurJeu()
        {
            _statusJeu = StatusJeu.PageAccueil;

            _interfaceUtilisateur = new InterfaceUtilisateur();
        }

        public void Initialize(MoteurSysteme _moteurSysteme, MoteurPhysique _moteurPhysique)
        {
            this._moteurSysteme = _moteurSysteme;
            this._moteurPhysique = _moteurPhysique;

            _camera = new Vector2(8 * 36, -36);

            _carte1 = new Carte(_moteurSysteme.CarteTableau1, _moteurSysteme.CarteTableauWidth, _moteurSysteme.CarteTableauHeight, _camera, 64, 64, 32, 16);
            _carte2 = new Carte(_moteurSysteme.CarteTableau2,_moteurSysteme.CarteTableauWidth, _moteurSysteme.CarteTableauHeight, _camera, 64, 64, 32, 16);
            _elementDecor = new ElementDecor(_moteurSysteme.ElementDecorTableau);
        }

        public void Update(GameTime _gameTime)
        {
            _carte1.Update(_moteurSysteme.EvenementUtilisateur.MouseState, _camera, _interfaceUtilisateur.CurrentItem, _gameTime);
            _interfaceUtilisateur.Update(_moteurSysteme.EvenementUtilisateur.MouseState);
        }

        public void UpdateCamera(Vector2 _positionTile)
        {
            Vector2 _position = new Vector2(_camera.X + 32 * (_positionTile.X - _positionTile.Y) + 32, _camera.Y + 16 * (_positionTile.X + _positionTile.Y) + 48);
            int _vitesse = 400;
            //_camera = -_position;// - Vector2.One) *10;

            if (_position.X < 300)
                _camera.X += _vitesse / (_position.X + 100);// / (_position.X-213);
            else if (_position.X > 500)
                _camera.X -= _vitesse / ((-_position.X + 800) + 100);

            if (_position.Y < 180)
                _camera.Y += _vitesse / (_position.Y + 100);
            else if (_position.Y > 300)
                _camera.Y -= _vitesse
                    / ((-_position.Y + 480) + 100);


        }


    }
}
