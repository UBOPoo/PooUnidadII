using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{

     
    private void Awake()
    {
        
        characterData = new FCharacterData(Random.Range(75, 12f), Random.Range(7f, 15f), Random.Range(8f, 12f));

    }
    public override void Attack()
    {
        
    }
    public override void InitializeTurn()
    {
        base.InitializeTurn();
        DoEnemyBehaviour();
    }

    public void DoEnemyBehaviour()
    {
        FinishTurn();
    }



}
