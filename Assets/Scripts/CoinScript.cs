using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.EditorTools;
using UnityEditor.SceneManagement;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    //The player calls this function on the coin whenever they bump into it
    //You can change its contents if you want something different to happen on collection
    //For example, what if the coin teleported to a new location instead of being destroyed?

    //public GameObject Prefab;
    
    
    public void GetBumped()
    {
        //the coin goes somewhere random.
        Instantiate(gameObject, new Vector3(Random.Range(-8.5f, 8.5f), Random.Range(-4.5f, 4.5f), 0), Quaternion.identity);
        
        //how to make it so it doesnt spawn on top of other objects..? maybe use tags
        
        //This destroys the coin
        Destroy(gameObject);
        
        
        
    }
}
