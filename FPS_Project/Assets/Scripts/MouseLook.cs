using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// camera look
public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f; //������
    public Transform playerBody;//���λ��
    public float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        //Debug.Log("MouseX:" + mouseX);
        //Debug.Log("MouseY:" + mouseY);  ���mouseX��mouseY��ֵ
        xRotation -= mouseY;//��������ת��ֵ�����ۼ�
        Mathf.Clamp(xRotation, -80f, 80f);
        playerBody.Rotate(Vector3.up * mouseX); //��Һ�����ת
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
