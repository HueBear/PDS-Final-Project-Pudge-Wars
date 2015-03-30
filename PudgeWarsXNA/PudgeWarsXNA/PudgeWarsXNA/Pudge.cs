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


namespace PudgeWarsXNA
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    class Pudge
    {
        //Pudge Objects
        Rectangle bounds;
        int str;
        int agi;
        int intelligence;
        int health;
        double speed;
        double experience;
        
        int level;
        int gold;

        //Do we need to make a player object or only a character???

        //TODO: Add an item object so we can add an inventory(wouldn't that be a list?

        //Hook level values for the hook object
        int hookDamage;
        int hookRadius;
        int hookRange;
        int hookSpeed;

        public Pudge(Rectangle PudgeBounds)
        {
            // TODO: Construct any child components here
        }

       
    }
}
