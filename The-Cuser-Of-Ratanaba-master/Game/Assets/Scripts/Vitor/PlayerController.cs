using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator playerAnimation;
    float input_x = 0;
    float input_y = 0;
    public float speed = 2.5f;
    bool isWalking = false;
    bool foguin = false;
    // Start is called before the first frame update
    void Start()
    {
        isWalking = false;
    }

    // Update is called once per frame
    void Update()
    {
        input_x = Input.GetAxisRaw("Horizontal");
        input_y = Input.GetAxisRaw("Vertical");
        isWalking = (input_x != 0 || input_y != 0);
        if (isWalking)
        {
            var move = new Vector3(input_x, input_y, 0);
            transform.position += move * speed * Time.deltaTime;
            playerAnimation.SetFloat("input_x", input_x);
            playerAnimation.SetFloat("input_y", input_y);
        }
        playerAnimation.SetBool("isWalking", isWalking);


        if (Input.GetButtonDown("Fire1"))
        { 
            foguin = true;
            
        }
        if (Input.GetButtonUp("Fire1"))
        {
            foguin = false;

        }
        if (foguin)
        {
            playerAnimation.Play("attack");
        }

    }
}
