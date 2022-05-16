using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimetJoystic : MonoBehaviour
{
    public MSJoystickController moveJoystic;
    private Animator Animacao;
    private Rigidbody rb;
    private float moveH,moveV;
    public float SpeedMove = 5;
    public bool Atacando;
    
     //public int SpeedMove = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Animacao = GetComponent<Animator>();
    }
    void Update()
    {
        movePlayer();
        animationPlayer();
        //Ataque();
    }

    
    void movePlayer(){
        
        //moveH = Input.GetAxis("Horizontal");
        //moveV = Input.GetAxis("Vertical");
        moveH = moveJoystic.joystick.joystickX;
        moveV = moveJoystic.joystick.joystickY; 
        Vector3 dir = new Vector3(moveH,0, moveV);
        //rb.velocity = new Vector3(moveH*SpeedMove, rb.velocity.y, moveV*SpeedMove);
        rb.velocity = dir*SpeedMove;
        
        if(dir != Vector3.zero){
            transform.LookAt(transform.position + dir);
        }
        
    }   
    void animationPlayer(){
        Animacao.SetFloat("HorizontalMove",moveH);
        Animacao.SetFloat("VerticalMove",moveV);
    }
    /*public void Ataque(){
        if(Input.GetKeyDown(KeyCode.Space)){
        //Animacao.SetBool("Atacar", true);
        Debug.Log("A");
        }
        if(Input.GetKeyUp(KeyCode.Space)){
        //Animacao.SetBool("Atacar", false);
        Debug.Log("B");
        }
    }*/
}
