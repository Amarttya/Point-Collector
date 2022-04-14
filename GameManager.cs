using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance ;
    [SerializeField]
    private GameObject[] characters;

    private int _charIndex;
    public int charIndex{
        get{return _charIndex; }
        set{_charIndex = value ; }
    }

    private void Awake(){
        if(instance == null){
            instance = this ;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
    }

    void OnEnable(){
        SceneManager.sceneLoaded += OnLevelFinishedLoading ;
    }
    void OnDisable(){
        SceneManager.sceneLoaded -= OnLevelFinishedLoading ;
    }

    void OnLevelFinishedLoading(Scene scene , LoadSceneMode mode){
        if(scene.name == "Point collector"){
            Instantiate(characters[charIndex]);
        }
    }

  
}
