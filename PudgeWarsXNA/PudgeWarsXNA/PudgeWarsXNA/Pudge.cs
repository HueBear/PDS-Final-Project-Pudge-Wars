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
        Texture3D texture;

        int playerNumber;

        int str;
        int currentHealth;
        int maxHealth;
        double speed;
        double exp;
        int respawnTime;
        int maxRespawnTime;

        Boolean hooked;
        Boolean healing;
        Boolean invuln;
        Boolean stunned;
        Boolean seek;
        
        int level;

        int gold;
        int AP;

        Hook pudgeHook;

        //TODO: Add an item object so we can add an inventory(wouldn't that be a list?

        //Hook level values for the hook object

        public Pudge(int inPlayerNumber)
        {
            playerNumber = inPlayerNumber;
            str = 10;
            currentHealth = 1500;
            maxHealth = 1500;
            speed = 350;
            exp = 0;
            respawnTime = 0;
            maxRespawnTime = 5;

            hooked = false;
            healing = false;
            invuln = false;
            stunned = false;

            level = 1;
            gold = 25;
            AP = 0;

            Hook pudgeHook = new Hook();
        }
        
        public void UpdatePudge()
        {

        }

        public void makeMove(GameTime gameTime, int inX, int inY, double inSpeed)
        {
            //move X values
            if(Math.Abs(bounds.X - inX) < inSpeed)
            {
                bounds.X = inX;
            }
            else if(bounds.X < inX)
            {
                bounds.X += (int)inSpeed;
            }
            else if(bounds.X > inX)
            {
                bounds.X -= (int)inSpeed;
            }

            //move Y values
            if(Math.Abs(bounds.Y - inY) < inSpeed)
            {
                bounds.Y = inY;
            }
            else if(bounds.Y < inY)
            {
                bounds.Y += (int)inSpeed;
            }
            else if(bounds.Y > inY)
            {
                bounds.Y -= (int)inSpeed;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
        }

        public int getPlayerNumber()
        {
            return playerNumber;
        }
        public int getCurrentHealth()
        {
            return currentHealth;
        }
        public int getMaxHealth()
        {
            return maxHealth;
        }
        public double getSpeed()
        {
            return speed;
        }
        public int getStr()
        {
            return str;
        }
        public double getExp()
        {
            return exp;
        }
        public int getRespawnTime()
        {
            return respawnTime;
        }
        public int getLevel()
        {
            return level;
        }
        public int getGold()
        {
            return gold;
        }
        public int getAP()
        {
            return AP;
        }
        public Boolean getHooked()
        {
            return hooked;
        }
        public Boolean getHealing()
        {
            return healing;
        }
        public Boolean getInvuln()
        {
            return invuln;
        }
        public Boolean getStunned()
        {
            return stunned;
        }

        public void setHealth(int inDamage)
        {
            currentHealth = currentHealth - inDamage;
        }
        public void setMaxHealth()
        {
            maxHealth = 1000 + (50 * getStr());
        }
        public void setSpeed(int inSpeed)
        {
            speed = speed + inSpeed;
        }
        public void setExp(double inExp)
        {
            exp = exp + inExp;
        }
        public void setRespawnTime(int inRespawnTime)
        {
            respawnTime = inRespawnTime;
        }
        public void setLevel(int inLevel)
        {
            level = inLevel;
        }
        public void setGold(int inGold)
        {
            gold = inGold;
        }
        public void setAP(int inAP)
        {
            AP = inAP;
        }
        public void setHooked(Boolean inHooked)
        {
            hooked = inHooked;
        }
        public void setHealing(Boolean inHealing)
        {
            healing = inHealing;
        }
        public void setInvuln(Boolean inInvuln)
        {
            invuln = inInvuln;
        }
        public void setStunned(Boolean inStunned)
        {
            stunned = inStunned;
        }
    }
}
