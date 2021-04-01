using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBrick : MonoBehaviour
{
    public UIManager ui;
    public Transform powerupspeedobj;
    public Transform powerupsizeobj;
    public Transform sizeshrink;
    public int whichpowerup;
    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.FindWithTag("ui").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter2D(Collision2D over)
    {
        whichpowerup = Random.Range(1, 6);
        if(whichpowerup == 1)
        {
            Instantiate(powerupsizeobj, transform.position, powerupsizeobj.rotation);
        }
        if (whichpowerup == 2)
        {
            Instantiate(powerupspeedobj, transform.position, powerupspeedobj.rotation);
        }
        if (whichpowerup == 3)
        {
            Instantiate(sizeshrink, transform.position, sizeshrink.rotation);
        }
        ui.IncrementScore();
        ui.updatenumberofbricks();
        Destroy(gameObject, 0.05f);
    }
}
