using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    private GameObject[] coin ;

    private int randomIndex;
    private int randomSide;
    private GameObject spawnedCoin ;

    public Transform firstpos, secondpos , thirdpos , fourthpos ;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnedCoin());
    }

    // Update is called once per frame
    IEnumerator SpawnedCoin()
    {while(true){
        yield return new WaitForSeconds(Random.Range(3, 5));

        randomIndex = Random.Range(0, coin.Length);
        randomSide = Random.Range(0,4);
        spawnedCoin = Instantiate(coin[randomIndex]);

        if(randomSide == 0){
            spawnedCoin.transform.position = firstpos.position ;
        }else if(randomIndex == 2){
            spawnedCoin.transform.position = thirdpos.position ;
        }else if(randomSide == 1){
            spawnedCoin.transform.position = fourthpos.position;
        }else{
            spawnedCoin.transform.position = secondpos.position ;
        }
    }
    
        
    }

}
