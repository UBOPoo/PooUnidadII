using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{

    public bool isMyTurn;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    public override void InitializeTurn()
    {
        base.InitializeTurn();
        isMyTurn = true;

    }

    void Attack()
    {
        Debug.Log("Player attack in turn" + GameManager.Instance.round);
        FinishTurn();
    }
    public override void FinishTurn()
    {
        if (!isMyTurn) return;

         
        isMyTurn = false;
        GameManager.Instance.ChangeNextTurn();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
          
        }
    }


}
