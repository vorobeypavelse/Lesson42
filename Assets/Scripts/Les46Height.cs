using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Les46Height : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");

        //уничтожает любой объек к которому дотронулись
        //Destroy(collision.gameObject);

        if (collision.gameObject.CompareTag("Coins"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Height"))
        {
            //Destroy(collision.gameObject);
            transform.localScale = transform.localScale + new Vector3(0.3f,0.3f, 0.3f);
            Destroy(collision.gameObject);

        }

        if (collision.gameObject.CompareTag("obstacles"))
        {
            //Destroy(collision.gameObject);
            transform.localScale = transform.localScale - new Vector3(0.3f, 0.3f, 0.3f);
            Destroy(collision.gameObject);

        }

    }
}
