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
    class SpriteIU
    {
        Texture2D _textureTileSet;

        public SpriteIU()
        {

        }

        public void LoadContent(ContentManager content, String _asset1)
        {
            _textureTileSet = content.Load<Texture2D>(_asset1);

        }
        
        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(_textureTileSet, new Vector2(0, 300), Color.White);

        }

    }
}
