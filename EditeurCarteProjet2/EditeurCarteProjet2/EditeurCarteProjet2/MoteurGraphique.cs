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
{// 1 - e ^ - x
    class MoteurGraphique
    {
        MoteurJeu _moteurJeu;

        SpriteCarte _spriteCarte1;
        public SpriteCarte SpriteCarte1 { get { return _spriteCarte1; } set { _spriteCarte1 = value; } }

        SpriteCarte _spriteCarte2;

        SpriteDecor _spriteDecor;

        SpriteIU _spriteIU;

        Vector2 _camera;

        public MoteurGraphique()
        {
        }

        public void Initialize(MoteurJeu _moteurJeu, Vector2 _camera)
        {

            this._camera = _camera;

            _spriteCarte1 = new SpriteCarte(_moteurJeu.Carte1, 1, _camera);
            _spriteCarte2 = new SpriteCarte(_moteurJeu.Carte2, 2, _camera);
            _spriteIU = new SpriteIU();
            _spriteDecor = new SpriteDecor(_moteurJeu.ElementDecor, _camera);
            this._moteurJeu = _moteurJeu;

        }



        public void LoadContent(ContentManager _content)
        {
            _spriteCarte1.LoadContent(_content, "TileSetIso", "hilight");
            _spriteCarte2.LoadContent(_content, "TileSetIso", "hilight");
            _spriteIU.LoadContent(_content, "TileSetIso");
            _spriteDecor.LoadContent(_content, "TileSetIso");
        }

        public void Update(Vector2 _camera, GameTime _gameTime)
        {
           _spriteCarte1.Update(_camera);
           _spriteCarte2.Update(_camera);
           _spriteDecor.Update(_camera);
        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteCarte1.Draw(_spriteBatch);
            _spriteCarte2.Draw(_spriteBatch);
            _spriteIU.Draw(_spriteBatch);
            //_spriteDecor.Draw(_spriteBatch);
        }


    }
}
