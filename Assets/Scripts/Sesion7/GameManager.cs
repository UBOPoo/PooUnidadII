using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EGameState {  Battle, Overworld}
public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }
    //*Game state**//
    public EGameState gameState;

    //Combat
    public GameObject EnemyPrefab;

    public List<GameObject> turnList = new List<GameObject>();
    public int currentTurn=0;
    public int round = 0;

    private void Awake()
    {
        instance = this;
    }
     

    public void GenerateCombat()
    {
        int NumberEnemies = Random.Range(1, 4);
        for (int i = 0; i < NumberEnemies; i++)
        {
           GameObject gameObjectEnemy= Instantiate(EnemyPrefab, Vector3.zero, Quaternion.identity);
            turnList.Add(gameObjectEnemy);

        }

        SortList();
    }
    public void SortList()
    {

        /*
       for (int i = 0; i < turnList.Count; i++)
       {
           Debug.Log(turnList[i].GetComponent<Character>().GetSpeed() );
       }*/

        for (int i = 0; i < turnList.Count; i++)
        {
            for (int j = 0; j < turnList.Count-1; j++)
            {
                if(turnList[j].GetComponent<Character>().GetSpeed()< turnList[j+1].GetComponent<Character>().GetSpeed())
                {
                    GameObject tmpGameObj = turnList[j + 1];
                    turnList[j + 1] = turnList[j];
                    turnList[j] = tmpGameObj;
                }
            }
        }

        
    } 

    void Start()
    {
        GenerateCombat();

        SetCharacterTurn();
    }

    void SetCharacterTurn()
    {
        turnList[currentTurn].GetComponent<Character>().InitializeTurn();
    }
    public void ChangeNextTurn()
    {
        currentTurn++;

        if (currentTurn >= turnList.Count)
        {
            currentTurn = 0;
            round++;
        }
           

        SetCharacterTurn();
    }
     
}
