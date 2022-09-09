using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// camera look
public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f; //灵敏度
    public Transform playerBody;//玩家位置
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
        //Debug.Log("MouseY:" + mouseY);  输出mouseX，mouseY的值
        xRotation -= mouseY;//将上下旋转的值进行累加
        Mathf.Clamp(xRotation, -80f, 80f);
        playerBody.Rotate(Vector3.up * mouseX); //玩家横向旋转
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
