using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameLibrary.Graphics
{
    public class AnimatedSprite : Sprite
    {
        private int _currentFrame;
        private TimeSpan _elapsed;
        private Animation _animation;

        public Animation Animation
        {
            get => _animation;
            set
            {
                _animation = value;
               Region = _animation.Frames[0];
               
            }
        }

        public AnimatedSprite() { }

        public AnimatedSprite(Animation animation)
        {
            Animation = animation;
        }

        public void Update(GameTime gameTime)
        {
            _elapsed += gameTime.ElapsedGameTime;

            if (_elapsed >= Animation.Delay)
            {
                _elapsed = TimeSpan.Zero;
                _currentFrame++;
                if (_currentFrame >= Animation.Frames.Count)
                {
                    _currentFrame = 0;
                }
                Region = Animation.Frames[_currentFrame];
            }
        }
    }
}
