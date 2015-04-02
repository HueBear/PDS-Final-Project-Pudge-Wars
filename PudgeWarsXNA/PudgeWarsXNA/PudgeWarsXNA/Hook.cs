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

            hookDamage = 250;
            hookRadius = 100;
            hookRange = 1500;
            hookSpeed = 800;
            CD = 0;
            maxCD = 3;

            hooking = false;
            pulling = false;
            
            // TODO: Construct any child components here
        }
        public int getDamage()
        {
            return hookDamage;
        }
        public int getRadius()
        {
            return hookRadius;
        }
        public int getRange()
        {
            return hookRange;
        }
        public int getSpeed()
        {
            return hookSpeed;
        }
        public int getCD()
        {
            return CD;
        }
        public int getMaxCD()
        {
            return maxCD;
        }
        public Boolean getHooking()
        {
            return hooking;
        }
        public Boolean getPulling()
        {
            return pulling;
        }

        public void setDamage(int inLevel)
        {
            hookDamage = 250 + (35 * inLevel);
        }
        public void setRadius(int inLevel)
        {
            hookRadius = 100 + (15 * inLevel);
        }
        public void setRange(int inLevel)
        {
            hookRange = 1500 + (175 * inLevel);
        }
        public void setSpeed(int inLevel)
        {
            hookSpeed = 800 + (70 * inLevel);
        }
        public void setCD(int inCD)
        {
            CD = inCD;
        }
        public void setHooking(Boolean inBool)
        {
            hooking = inBool;
        }
        public void setPulling(Boolean inBool)
        {
            pulling = inBool;
        }
    }
}
