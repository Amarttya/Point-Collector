using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class GameOver : MonoBehaviour
{
    public static GameOver gammeover ;
    public Text text ;
    // Start is called before the first frame update
   void Start()
    {
        if(gammeover == null){
            gammeover = this ;
        }else{
        //text.text = "" ;
        }
        
    }

    // Update is called once per frame
   public void Update()
    {
       
    }
}
