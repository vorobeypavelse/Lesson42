using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Les45MovePlayer : MonoBehaviour
{
    //перемещение по ос€м
    private int speed = 20;
    public float horizontal;
    public float vertical;
    //добавление поворота вместо передвижени€
    private int rotationSpeed = 80;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        //передвижени€ 1 часть
        //transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal);
        //добавление поворота вместо передвижени€ 2 часть
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontal);

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");

        //уничтожает любой объек к которому дотронулись
        //Destroy(collision.gameObject);

        if ( collision.gameObject.CompareTag("Coins"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Height"))
        {
            Destroy(collision.gameObject);
        }

    }
}
