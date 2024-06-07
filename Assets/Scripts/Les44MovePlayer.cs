using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Les44MovePlayer : MonoBehaviour
{
    //����������� �� ����
    private int speed = 20;
    public float horizontal;
    public float vertical;
    //���������� �������� ������ ������������
    private int rotationSpeed = 80;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        //������������ 1 �����
        //transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal);
        //���������� �������� ������ ������������ 2 �����
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontal);

    }
}
