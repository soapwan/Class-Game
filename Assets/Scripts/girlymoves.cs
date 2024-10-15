using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girlymoves : MonoBehaviour
{
    // Start is called before the first frame update

    public SpriteRenderer Girly;
    public Color TargetColor = Color.blue;
    void Start()
    {
        Girly.transform.position = new Vector3(0, 0, 0);
        
        Girly.color = TargetColor;
    }

    // Update is called once per frame
    void Update()
    {
        Girly.transform.position += new Vector3(0.1f, 0, 0);
    }
}
