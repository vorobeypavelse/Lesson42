using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Les44MovePlayer : MonoBehaviour
{
    //перемещение по осям
    private int speed = 20;
    public float horizontal;
    public float vertical;
    //добавление поворота вместо передвижения
    private int rotationSpeed = 80;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        //передвижения 1 часть
        //transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal);
        //добавление поворота вместо передвижения 2 часть
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontal);

    }
}
