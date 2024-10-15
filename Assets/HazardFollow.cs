using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardFollow : MonoBehaviour
{
    public GameObject Player;
    
    public float Speed;
    
    public bool CanMove;
  
    void Start()
    {   
        CanMove = false;
    }    
        
    void FixedUpdate()
    {      
        if (Player != null && CanMove)
        {
           transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, Speed);
        }
    }
}
