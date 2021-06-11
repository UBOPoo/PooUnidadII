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

    public virtual  void InitializeTurn()
    {
        Debug.Log(" i Have begun my turn " + gameObject.name + " with speed "+ characterData.Speed);
        

    }

    public virtual void Attack()
    {

    }

    public virtual void ApplyDamage(float DamageReceived)
    {

    }
    public virtual void FinishTurn()
    {
        GameManager.Instance.ChangeNextTurn();
    }
}
