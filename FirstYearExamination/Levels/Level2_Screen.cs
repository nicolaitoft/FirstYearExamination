﻿using FirstYearExamination.Screens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstYearExamination.Levels
{
    class Level2_Screen : GameScreen
    {
        private Texture2D background;
        private string path = "Sprites/Map/Map_2";


        public Level2_Screen(GameWorld gameWorld) : base(gameWorld)
        {
           

        }

        public override void LoadContent()
        {
            //Set mouse cursor to visible.
            ScreenManager.IsMouseVisible = true;

            base.LoadContent();
            background = gameScreenContent.Load<Texture2D>(path);
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);


        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(background, Vector2.Zero, Color.White);

            base.Draw(spriteBatch, gameTime);

        }
    }
}
