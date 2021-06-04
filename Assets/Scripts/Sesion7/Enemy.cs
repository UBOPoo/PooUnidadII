using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{

     
    private void Awake()
    {
        characterData.Speed = Random.Range(7f, 15f);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
   


}
