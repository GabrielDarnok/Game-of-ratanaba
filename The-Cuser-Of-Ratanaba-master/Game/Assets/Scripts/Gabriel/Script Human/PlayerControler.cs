using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public Animator PlayerController;
    float Input_x = 0;
    float Input_y = 0;
    public float spped = 2.5f;
    bool isWalking = false;

    // Start is called before the first frame update
    void Start()
    {
        isWalking = false;
    }

    // Update is called once per frame
    void Update()
    {
        Input_x = Input.GetAxisRaw("Horizontal");
        Input_y = Input.GetAxisRaw("Vertical");
        isWalking = (Input_x != 0 || Input_y != 0);

        if (isWalking)
        {
            var move = new Vector3(Input_x, Input_y, 0).normalized;
            transform.position += move * spped * Time.deltaTime;
            PlayerController.SetFloat("Input_X", Input_x);
            PlayerController.SetFloat("Input_Y", Input_y);
        }
        PlayerController.SetBool("IsWalking", isWalking);

        if (Input.GetButtonDown("Fire1"))
            PlayerController.SetTrigger("Attack");
    }
}
