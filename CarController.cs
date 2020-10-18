using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public static float speed;
    Vector2 startPos;
    public static Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        speed=0;
        rb2d = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            this.startPos=Input.mousePosition;
        }else if(Input.GetMouseButtonUp(0)){
            Vector2 endPos=Input.mousePosition;
            float swipeLength=endPos.x-this.startPos.x;
            speed=swipeLength/500.00f;
            GetComponent<AudioSource>().Play();
        }
        transform.Translate(speed,0,0);
        speed*=0.98f;
    }
    //Rigidbodyうまく行かない...
    public void LeftButton(){
        rb2d = GetComponent<Rigidbody2D> ();
        Vector2 force = new Vector2(-3,0);
        rb2d.AddForce (force);
        GetComponent<AudioSource>().Play();
    }
    public void RightButton(){
        speed=1;
        GetComponent<AudioSource>().Play();
    }
    
}
