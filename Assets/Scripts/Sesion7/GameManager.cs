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
        //
        for (int i = 0; i < turnList.Count; i++)
        {
            Debug.Log(turnList[i].GetComponent<Character>().GetSpeed() );
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        GenerateCombat();
    }

     
}
