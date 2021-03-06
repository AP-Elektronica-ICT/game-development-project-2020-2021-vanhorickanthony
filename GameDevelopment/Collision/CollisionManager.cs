﻿using Microsoft.Xna.Framework;
using MonoGame.Extended.Tiled;

namespace GameDevelopment.Collision
{
    public class CollisionManager
    {
        TiledMapTile? collisionTile;

        public bool CheckCollision(Rectangle rect1, Rectangle rect2)
        {
            if (rect1.Intersects(rect2))
                return true;

            return false;
        }


        public bool CheckCollision(Rectangle origin, TiledMapTileLayer collisionLayer)
        {
            for (int x = origin.X; x < origin.X + origin.Width; x++)
            {
                for (int y = origin.Y; y < origin.Y + origin.Height; y++)
                {
                    if (collisionLayer.TryGetTile(
                        (ushort)(x / collisionLayer.TileWidth),
                        (ushort)(y / collisionLayer.TileHeight),
                        out collisionTile
                        )
                    )
                    {
                        if (collisionTile.Value.IsBlank)
                        {
                            continue;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return false;

        }
    }
}
