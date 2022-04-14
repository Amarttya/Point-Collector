using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float speed = 10f ;
    public float jumpForce = 10f;
    private float movement ;
    private BoxCollider2D boxcollider ;
    private Rigidbody2D rigidbody ;
    private Animator anim ;
    private SpriteRenderer sr ;
    private string Run_Animation = "Run" ;
    private string Jump_Animation = "jump" ;
    private string Ground_Tag = "Ground";
    private string Enemy_Tag = "Enemy" ;
   // private string Coin_Tag = "Coin";
    private bool isGrounded ;
    private bool getKeyDown ;
    //public Text text ;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
        AnimatePlayer();
        playerJump();
    
    }

    void FixedUpdate(){
        
    }
    public void playerMovement ()
    {
      movement = Input.GetAxisRaw("Horizontal");
      transform.position += new Vector3(movement , 0f , 0f) * speed * Time.deltaTime ;
      
    }

    void AnimatePlayer(){
        
        if(movement<0){
            //going to the left side because (-1 , 0 ,1 )
            anim.SetBool(Run_Animation , true);
            sr.flipX = true ;
        }else if(movement>0){
            //going to the right side 
            anim.SetBool(Run_Animation , true);
            sr.flipX = false ;
        }else{
            //idle
            anim.SetBool(Run_Animation , false);
        }
    }

    void playerJump(){
          if(Input.GetKeyDown(KeyCode.Space))
                {
                    getKeyDown = true ;
                    Debug.Log("space key is pressed down!");
                }
                if (getKeyDown == true)
                { 
                    anim.SetBool(Jump_Animation , true);
                    rigidbody.AddForce(new Vector2(0f , jumpForce), ForceMode2D.Impulse);
                    getKeyDown = false ;
                }
                   // anim.SetBool(Jump_Animation , false);
        }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag(Ground_Tag)){
            anim.SetBool(Jump_Animation , false);
        }
        if(collision.gameObject.CompareTag(Enemy_Tag)){
            Destroy(gameObject);
            GameOver.gammeover.text.text = "Game Over" ;
        }
    }
    







}//class
