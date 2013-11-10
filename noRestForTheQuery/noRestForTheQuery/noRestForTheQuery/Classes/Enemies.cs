﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace noRestForTheQuery {

    class Professor : GameObject {
        int /*markerAmt,*/ markerSpeed, attackPower;
        public List<Marker> markers = new List<Marker>();
        public Professor(int attackPower, Vector2 position, Vector2 origin, Vector2 velocity, float speed) :
            base(position, origin, velocity, speed) {
            // Values Already Assigned To: 
            //      GameObject - bool isAlive, Vector2 position, Vector2 origin, Vector2 velocity, float speed
            //      DamagableObject - int currentHealth, int fullHealth, int attackPower;
            // Empty Values To Be Assigned: Color[] colorArr, float rotation, float rotSpeed
                isAlive = false;
                //markerAmt = 10;
                markerSpeed = 10;
                this.attackPower = attackPower;
        }

        // Update the Position And/Or Velocity
        public void update() {
            if (isAlive && position.X > FinalGame.WINDOW_WIDTH - 100) { position.X -= speed; }
        }

        public void reset() {
            isAlive = false;
            markers.Clear();
            //markerAmt = 10;
            position = new Vector2(FinalGame.WINDOW_WIDTH, (FinalGame.WINDOW_HEIGHT - FinalGame.professorSprite.Height) / 2);
        }
        public void shoot( double studentPosX, double studentPosY) {
            //if (markerAmt > 0) {
                markers.Add(new Marker(attackPower, new Vector2(position.X + FinalGame.professorSprite.Width / 2, position.Y + FinalGame.professorSprite.Height / 2),
                    new Vector2(FinalGame.markerSprite.Width / 2, FinalGame.markerSprite.Height / 2), Vector2.Zero, markerSpeed, (float)(Math.Atan2(studentPosY, studentPosX))));
            //    markerAmt--;
            //}
        }
    }

    class Homework : DamagableObject {
        public Homework(Vector2 position, Vector2 origin, Vector2 velocity) :
            base(position, origin, velocity, 0) {
            // Values Already Assigned To: 
            //      GameObject - bool isAlive, Vector2 position, Vector2 origin, Vector2 velocity, float speed
            //      DamagableObject - int currentHealth, int fullHealth, int attackPower;
            // Empty Values To Be Assigned: Color[] colorArr, float rotation, float rotSpeed

            fullHealth = 50 * FinalGame.gameLevel;
            currentHealth = fullHealth;
            attackPower = 10 * FinalGame.gameLevel;

            // Assign Values to Local Members
            speed = (float)(FinalGame.rand.Next(2, 3) + FinalGame.rand.NextDouble());

        }
        // Update the Position And/Or Velocity
        public void update() {
            position.X -= speed;
        }
    }
    class Midterm : DamagableObject {
        public Midterm(Vector2 position, Vector2 origin, Vector2 velocity, float speed) :
            base(position, origin, velocity, speed) {
            // Values Already Assigned To: 
            //      GameObject - bool isAlive, Vector2 position, Vector2 origin, Vector2 velocity, float speed
            //      DamagableObject - int currentHealth, int fullHealth, int attackPower;
            // Empty Values To Be Assigned: Color[] colorArr, float rotation, float rotSpeed

            fullHealth = 100 * FinalGame.gameLevel;
            currentHealth = fullHealth;
            attackPower = 25 * FinalGame.gameLevel;

            // Assign Values to Local Members

        }
        // Update the Position And/Or Velocity
        public void update() {

        }

    }
    class Final : DamagableObject {
        public Final(Vector2 position, Vector2 origin, Vector2 velocity, float speed) :
            base(position, origin, velocity, speed) {
            // Values Already Assigned To: 
            //      GameObject - bool isAlive, Vector2 position, Vector2 origin, Vector2 velocity, float speed
            //      DamagableObject - int currentHealth, int fullHealth, int attackPower;
            // Empty Values To Be Assigned: Color[] colorArr, float rotation, float rotSpeed

            fullHealth = 200 * FinalGame.gameLevel;
            currentHealth = fullHealth;
            attackPower = 50 * FinalGame.gameLevel;

            // Assign Values to Local Members

        }

        // Update the Position And/Or Velocity
        public void update() {

        }
    }
}