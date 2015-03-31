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
        double experience;
        int respawnTime;
        int maxRespawnTime;

        Boolean hooked;
        Boolean healing;
        Boolean invulnerable;
        
        int level;

        int gold;
        int aP;

        Hook pudgeHook;

        //TODO: Add an item object so we can add an inventory(wouldn't that be a list?

        //Hook level values for the hook object

        public Pudge(int inPlayerNumber)
        {
            playerNumber = inPlayerNumber;

            str = 10;
            currentHealth = 1500;
            maxHealth = 1500;
            //speed;
            experience = 0;
            respawnTime = 0;
            maxRespawnTime = 5;

            hooked = false;
            healing = false;
            invulnerable = false;

            level = 1;
            gold = 25;
            aP = 0;

            Hook pudgeHook = new Hook();
        }
    }
}
