﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace noRestForTheQuery {

    class Missile : GameObject {
        protected int attackPower;

        public Missile(int attackPower, Vector2 position, Vector2 origin, Vector2 velocity, float speed) :
            base(position, origin, velocity, speed) {
            // Assign Values To: attackPower
            // Values Already Assigned To: 
            //      GameObject - bool isAlive, Vector2 position, Vector2 origin, Vector2 velocity, float speed
            // Empty Values To Be Assigned: Color[] colorArr, float rotation, float rotSpeed


            // Assign Values to Local Members
            this.attackPower = attackPower;
        }
    }
    class Pencil : Missile {

        public Pencil(int attackPower, Vector2 position, Vector2 origin, float speed, float rotation) :
            base(attackPower, position, origin, Vector2.Zero, speed) {
            // Values Already Assigned To: 
            //      GameObject - bool isAlive, Vector2 position, Vector2 origin, Vector2 velocity, float speed
            //      Missle - attackPower
            // Empty Values To Be Assigned: Color[] colorArr, float rotation, float rotSpeed

            this.rotation = rotation;
            velocity.X = (float)Math.Cos(rotation) * speed;
            velocity.Y = (float)Math.Sin(rotation) * speed;

            // Assign Values to Local Members
        }

        public void update() {
            position.X += velocity.X;
            position.Y += velocity.Y;
            velocity.Y += FinalGame.GRAVITY * .2F;
            rotation = (float)Math.Atan2(velocity.Y, velocity.X);
        }
    } 
    class Marker : Missile {
        public Marker(int attackPower, Vector2 position, Vector2 origin, Vector2 velocity, float speed, float rotation) :
            base(attackPower, position, origin, velocity, speed) {
            // Values Already Assigned To: 
            //      GameObject - bool isAlive, Vector2 position, Vector2 origin, Vector2 velocity, float speed
            //      Missle - attackPower
            // Empty Values To Be Assigned: Color[] colorArr, float rotation, float rotSpeed
            //this.rotation = rotation;
            //velocity.X = (float)Math.Cos(rotation) * speed;
            //velocity.Y = (float)Math.Sin(rotation) * speed;

            // Assign Values to Local Members

        }

        public void update( float x, float y ) {
            position.X -= speed;
            if (position.X + FinalGame.markerSprite.Width > x) {
                if (position.Y < y) { position.Y += 1.5F; }
                else { position.Y -= 1.5F; }
            }
        }
    }


    class Notebook : GameObject {
        public int numOfNotebook;

        public Notebook(Vector2 position, Vector2 origin, Vector2 velocity, float speed) :
            base(position, origin, velocity, speed) {
            // Values Already Assigned To: 
            //      GameObject - bool isAlive, Vector2 position, Vector2 origin, Vector2 velocity, float speed
            // Empty Values To Be Assigned: Color[] colorArr, float rotation, float rotSpeed
            this.rotation = (float)FinalGame.rand.NextDouble() * MathHelper.TwoPi;
            this.rotSpeed = 0.04F;
            // Assign Values to Local Members
            numOfNotebook = 3;
        }
        // Update the Position And/Or Velocity
        public void update(Vector2 studentOrigin) {
            position = studentOrigin;
            rotation += rotSpeed;
        }
        void isDamaged() {
            numOfNotebook--;
            if (numOfNotebook <= 0) { isAlive = false; }
        }
    }



    //class PopQuizzes : Missile {
    //    public Marker(int attackPower, Vector2 position, Vector2 origin, Vector2 velocity, float speed) :
    //        base(attackPower, position, origin, velocity, speed) {
    //        // Values Already Assigned To: 
    //        //      GameObject - bool isAlive, Vector2 position, Vector2 origin, Vector2 velocity, float speed
    //        //      Missle - attackPower
    //        // Empty Values To Be Assigned: Color[] colorArr, float rotation, float rotSpeed


    //        // Assign Values to Local Members

    //    }
    //    // Update the Position And/Or Velocity
    //    public void update() {

    //    }
    //}
}