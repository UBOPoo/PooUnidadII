using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{

     
    private void Awake()
    {
        characterData.Speed = Random.Range(7f, 15f);
        
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
