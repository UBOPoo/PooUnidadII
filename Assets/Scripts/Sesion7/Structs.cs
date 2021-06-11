using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
 public struct FCharacterData
{
    public float Speed;
    public float hp;
    public float maxHp;
    public float damage;

   public FCharacterData(float NewHP,float NewSpeed,float NewDamage)
    {
        Speed = NewSpeed;
        damage = NewDamage;
     hp =  maxHp = NewHP;
    }

}