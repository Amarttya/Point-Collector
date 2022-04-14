using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance ;
    public Text text ;
    int score ;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null){
            instance = this ;
        }
        
    }

    // Update is called once per frame
    public void ChangeScore(int CoinValue){
        score += CoinValue ;
        text.text = "Score: " + score;
    }
        
    
}
