using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public FCharacterData characterData;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float GetSpeed()
    {
        return characterData.Speed;
    }
}
