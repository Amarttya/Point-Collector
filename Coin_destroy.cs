using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_destroy : MonoBehaviour
{
    public int coinValue = 1 ;
    void OnCollisionEnter2D(Collision2D collision){
    if(collision.gameObject.CompareTag("Player")){
        Destroy(gameObject);
        ScoreManager.instance.ChangeScore(coinValue);
    }
}
}
