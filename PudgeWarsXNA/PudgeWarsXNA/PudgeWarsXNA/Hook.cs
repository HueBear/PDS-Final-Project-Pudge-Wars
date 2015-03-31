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
    public class Hook
    {
        Rectangle bounds;
        Texture3D texture;

        int hookDamage;
        int hookRadius;
        int hookRange;
        int hookSpeed;

        int hookDamageLevel;
        int hookRadiusLevel;
        int hookRangeLevel;
        int hookSpeedLevel;

        int CD;
        int maxCD;

        Boolean hooking;
        Boolean pulling;

        public Hook()
        {
            hookDamageLevel = 0;
            hookRadiusLevel = 0;
            hookRangeLevel = 0;
            hookSpeedLevel = 0;

            hookDamage = 250 + (35 * hookDamageLevel);
            hookRadius = 100 + (15 * hookRadiusLevel);
            hookRange = 1500 + (175 * hookRangeLevel);
            hookSpeed = 800 + (70 * hookSpeedLevel);
            CD = 0;
            maxCD = 3;

            hooking = false;
            pulling = false;
            
            // TODO: Construct any child components here
        }


    }
}
