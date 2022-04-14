using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] EnemyReference ;

    private GameObject spawnedEnemy ;
    [SerializeField]
    private Transform leftPos , rightPos ;

    private int randomIndex;
    private int randomSide ;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy()) ; 
    }

    IEnumerator SpawnEnemy(){
    while(true){
        yield return new WaitForSeconds(Random.Range(1, 5));

        randomIndex = Random.Range(0 , EnemyReference.Length);
        randomSide = Random.Range(0 , 2) ;

        spawnedEnemy = Instantiate(EnemyReference[randomIndex]);

        //left_side
        if(randomSide == 0){
            spawnedEnemy.transform.position = leftPos.position ;
            spawnedEnemy.GetComponent<Enemy>().speed = Random.Range(4,10);
        }else{
            //right_side
            spawnedEnemy.transform.position = rightPos.position ;
            spawnedEnemy.GetComponent<Enemy>().speed = - Random.Range(4 , 10 );
            spawnedEnemy.transform.localScale = new Vector3(-6f , 5f , 5f);
        }
     }
    }
} //class














