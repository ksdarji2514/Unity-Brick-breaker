using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ballcontroller : MonoBehaviour
{
    public Vector2 currentvel;
    public Vector2 ballvel;
    public Transform ballchecker;
    
    // Start is called before the first frame update
    void Start()
    {
        ballvel = new Vector2(3, -3);
        GetComponent<Rigidbody2D>().velocity = ballvel;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < ballchecker.transform.position.y)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        currentvel = GetComponent<Rigidbody2D>().velocity;
        if(currentvel.y > 6)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(currentvel.x, 6);
        }
        if (currentvel.y < -6)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(currentvel.x, -6);
        }
        if (currentvel.x > 6)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(6,currentvel.y);
        }
        if (currentvel.x < -6)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-6, currentvel.y);
        }

    }
    void OnCollisionEnter2D(Collision2D over)
    {
        if(over.gameObject.name == "leftborder")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2((currentvel.x * -1), (currentvel.y));
        }
        if (over.gameObject.name == "rightborder")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2((currentvel.x * -1), (currentvel.y));
        }

    }
}
