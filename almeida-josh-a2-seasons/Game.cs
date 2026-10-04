// Include the namespaces (code libraries) you need below.
using System;
using System.Data;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        int season = 0;
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Tree Seasons");
            Window.SetSize(400,400);
            Draw.SetLineSize(2);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            
            //spring
            if (season == 0)
            {
                Window.ClearBackground(144,238,144); //light green

                //tree trunk
                Draw.SetFillColor(150,75,0);
                Draw.Rectangle(180,220,40,130);

                //tree leaves
                Draw.SetFillColor(255,182,193);
                Draw.Circle(200,150,75);

                //ground
                Draw.SetFillColor(34,139,34);
                Draw.Rectangle(0, 340, 400, 340);
            }

            //summer
            else if (season == 1)
            {
                Window.ClearBackground(135, 206, 235); //Sky Blue

                //tree trunk
                Draw.SetFillColor(150,75,0);
                Draw.Rectangle(180,220,40,130);

                //tree leaves
                Draw.SetFillColor(0,100,0);
                Draw.Circle(200,150,75);
                
                //ground
                Draw.SetFillColor(34,139,34);
                Draw.Rectangle(0,340,400,340);

                //sun
                Draw.SetFillColor(255,255,0);
                Draw.Circle(40,40,40);

                //apples
                Draw.SetFillColor(255,0,0);
                Draw.Circle(170,200,10);
                Draw.Circle(230, 200, 10);
                Draw.Circle(200, 160, 10);
                Draw.Circle(170, 120, 10);
                Draw.Circle(230, 120, 10);
            }
            
            //fall
            else if (season == 2)
            {
                Window.ClearBackground(255,213,128); //light orange

                //tree trunk
                Draw.SetFillColor(150,75,0);
                Draw.Rectangle(180,220,40,130);

                //tree leaves
                Draw.SetFillColor(253,170,72); 
                Draw.Circle(200,150,75);

                //ground
                Draw.SetFillColor(228, 220, 138);
                Draw.Rectangle(0,340,400,340);


                //pumpkin body
                Draw.SetFillColor(255, 165, 0);
                Draw.Circle(300, 350, 30);
                Draw.SetFillColor(0);

                //eyes
                Draw.Triangle(290, 340, 295, 350, 285, 350);
                Draw.Triangle(310, 340, 305, 350, 315, 350);

                //mouth
                Draw.SetFillColor(0, 0, 0);
                Draw.Rectangle(290, 360, 20, 5);


            }

            //winter
            else if (season == 3)
            {
                Window.ClearBackground(173,216,230); //light blue

                //tree trunk
                Draw.SetFillColor(150,75,0);
                Draw.Rectangle(180,220,40,130);

                //tree leaves
                Draw.SetFillColor(255, 255, 255);
                Draw.Circle(200, 150, 75);
                Draw.Line(200, 0, 160, 0);

                //ground
                Draw.SetFillColor(240);
                Draw.Rectangle(0,340,400,340);

                //snowflakes
                Draw.SetFillColor(255,255,255);
                Draw.Circle(50,180,5);
                Draw.Circle(100,240,5);
                Draw.Circle(50, 290, 5);
                Draw.Circle(120, 300, 5);
                Draw.Circle(360, 140, 5);
                Draw.Circle(280, 200, 5);
                Draw.Circle(340, 250, 5);
                Draw.Circle(280, 300, 5);
                Draw.Circle(40, 40, 5);
                Draw.Circle(140,80, 5);
                Draw.Circle(100, 120, 5);
                Draw.Circle(260,60,5);
                Draw.Circle(320,80 , 5);
                Draw.Circle(380, 40, 5);

            }

            //change seasons
            if (Input.IsKeyboardKeyPressed(KeyboardKey.Space))
            {
                season++;
                if (season > 3)
                {
                    season = 0; 
                }
                


            }

        }
    }
}
