using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private CharacterController characterController;
    public float speed = 10f;
    public Vector3 moveDirction;


    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }


    private void Update()
    {
        Move();
    }

    public void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Debug.Log("h:" + h);
        Debug.Log("v:" + v);

        moveDirction = (transform.right * h + transform.forward * v).normalized;

        characterController.Move(moveDirction * speed * Time.deltaTime);

    }

}
