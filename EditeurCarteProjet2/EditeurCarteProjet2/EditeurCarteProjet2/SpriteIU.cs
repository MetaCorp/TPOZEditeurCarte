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
            _spriteBatch.Draw(_textureTileSet, new Rectangle(0, 300 + 32, 7 * 64, 32), new Rectangle(0, 32, 7 * 64, 32), Color.White);
            _spriteBatch.Draw(_textureTileSet, new Rectangle(7 * 64, 300 + 32, 5 * 64, 32), new Rectangle(0, 64 + 32, 5 * 64, 32), Color.White);

            _spriteBatch.Draw(_textureTileSet, new Rectangle(0, 300 + 32 * 2, 3 * 64, 32), new Rectangle(64 * 5, 64 + 32, 3 * 64, 32), Color.White);
            _spriteBatch.Draw(_textureTileSet, new Rectangle(3 * 64, 300 + 32 * 2, 4 * 64, 32), new Rectangle(64 * 0, 64 * 2 + 32, 4 * 64, 32), Color.White);

            _spriteBatch.Draw(_textureTileSet, new Rectangle(0, 300 + 32 * 3, 9 * 64, 64), new Rectangle(64 * 0, 64 * 3, 9 * 64, 64), Color.White);
            _spriteBatch.Draw(_textureTileSet, new Rectangle(9 * 64, 300 + 32 * 3, 3 * 64, 64), new Rectangle(64 * 0, 64 * 4, 3 * 64, 64), Color.White);
        }

    }
}
