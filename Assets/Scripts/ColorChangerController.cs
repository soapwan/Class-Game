using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerController : MonoBehaviour
{
    //This is about as simple a script as you can imagine
    //It makes it so that if you hit the space bar, the attached sprite changes colors
    
    //This is the SpriteRenderer component in charge of drawing this object's sprite
    public SpriteRenderer Girly;

    //This is the color we want the object to turn
    public Color TargetColor = Color.green;
    
    //Any code inside of Update's {} brackets runs once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    //Here we update the SpriteRenderer's color to be whatever TargetColor is set to be
                    Girly.color = Color.yellow;
                }
        //This if statement can be read "If I hit space, change the sprite's color"
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Here we update the SpriteRenderer's color to be whatever TargetColor is set to be
            Girly.color = Color.green;
        }
    }   
}
