using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontroller : MonoBehaviour
{
    public float speed = 1.00f; 
    private Rigidbody2D r2d; 
    private Animator animator;
    private Vector3 charPosmkbl;
    private SpriteRenderer spriteRendererMkbl;
    [SerializeField] private GameObject _cameramkbl;
    private int sayi;


     void Start() 
    {
        spriteRendererMkbl = GetComponent<SpriteRenderer>();
        r2d = GetComponent<Rigidbody2D>(); 
        animator = GetComponent<Animator>(); 
        charPosmkbl = transform.position;
        sayi = 1;
  
    }

    private void FixedUpdate()
    {
        
        sayi = 2;
    }

    private void Update() 
    {
        

        charPosmkbl = new Vector3(x:charPosmkbl.x + (Input.GetAxis("Horizontal") * speed * Time.deltaTime), charPosmkbl.y);
        transform.position = charPosmkbl;
        
        if (Input.GetAxis("Horizontal") == 0.00f)
        {
            animator.SetFloat(name: "speed", value: 0.00f);
        }

        else
        {
            animator.SetFloat(name: "speed", value: 1.00f);
        }

        if (Input.GetAxis("Horizontal") > 0.01f)
        {
            spriteRendererMkbl.flipX = false;
        }else if(Input.GetAxis("Horizontal") < -0.01f)
        {
            spriteRendererMkbl.flipX = true ;
        }
    }

    private void LateUpdate()
    {
       
        sayi = 4;
    }
}