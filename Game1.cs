using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Drawing;

namespace BtsSmashBrawl
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

public struct Scene
{
    public Texturedata[] texture;
    public ContentManager contentmanager;
    public SpriteBatch spritebatch;
    public bool isLoad;


    public void LoadTextureList(ContentManager contentmanager_, SpriteBatch spritebatch_, string[] textureListe)
    {
        contentmanager = contentmanager_;
        spritebatch = spritebatch_;
        texture = new Texturedata[textureListe.Length];
        for (int i = 0; i < textureListe.Length; i++)
        {
            texture[i].texture = contentmanager.Load<Texture2D>(textureListe[i]);
            texture[i].position = new Vector2(0, 0);
            texture[i].size = new Vector2(texture[i].texture.Width, texture[i].texture.Height);

        }
        isLoad = true;
    }

}

public struct Texturedata
{
    public Texture2D texture;
    public Vector2 size;
    public Vector2 position;
}

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Drawing;

namespace BtsSmashBrawl
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

public struct Scene
{
    public Texturedata[] texture;
    public ContentManager contentmanager;
    public SpriteBatch spritebatch;
    public bool isLoad;


    public void LoadTextureList(ContentManager contentmanager_, SpriteBatch spritebatch_, string[] textureListe)
    {
        contentmanager= contentmanager_;
        spritebatch = spritebatch_;
        texture = new Texturedata[textureListe.Length];
        for(int i =0; i < textureListe.Length; i++) {
            texture[i].texture = contentmanager.Load<Texture2D>(textureListe[i]);
            texture[i].position = new Vector2(0, 0);
            texture[i].size = new Vector2(texture[i].texture.Width, texture[i].texture.Height);

        }
        isLoad = true;
    }

}

public struct Texturedata
{
    public Texture2D texture;
    public Vector2 size;
    public Vector2 position;
}

