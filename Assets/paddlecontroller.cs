using System.Collections;
using UnityEngine;

public class paddlecontroller : MonoBehaviour
{
    public KeyCode moveL;
    public KeyCode moveR;
    public int xvel = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey (moveL))
        {
            GetComponent < Rigidbody2D>().velocity = new Vector2(-5-xvel, 0);
        }
        if (Input.GetKey(moveR))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(5+xvel, 0);
        }
        if ((!Input.GetKey(moveL)) && (!Input.GetKey(moveR)))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name=="slide_expand(Clone)")
        {
            GetComponent<Transform>().localScale = new Vector2(2, 1f);
        }
        if (other.gameObject.name == "powerupspeed(Clone)")
        {
            xvel = 6; 
        }
        if (other.gameObject.name == "slide_shrink(Clone)")
        {
            GetComponent<Transform>().localScale = new Vector2(1f,1f);
        }


    }
}
