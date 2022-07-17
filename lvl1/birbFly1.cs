using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birbFly1 : MonoBehaviour
{
    public GameManager1 gameManager;
    public float velocity = 1f;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) || Input.GetKeyDown("space")){
            fly();
        }
    }

    void fly(){
        rb.velocity = Vector2.up * velocity;
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "obstacle"){
            gameManager.GameOver();
        }
    }
}
