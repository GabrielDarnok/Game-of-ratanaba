using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoroControler : MonoBehaviour
{
    public Animator PlayerAnimator;
    float input_x = 0;
    float input_y = 0;
    public float spped = 2.5f;
    bool IsWalking = false;

    // Start is called before the first frame update
    void Start()
    {
        IsWalking = false;
    }

    // Update is called once per frame
    void Update()
    {
        input_x = Input.GetAxisRaw("Horizontal");
        input_y = Input.GetAxisRaw("Vertical");
        IsWalking = (input_x != 0 || input_y != 0);

        if (IsWalking)
        {
            var move = new Vector3(input_x, input_y, 0).normalized;
            transform.position += move * spped * Time.deltaTime;
            PlayerAnimator.SetFloat("input_x", input_x);
            PlayerAnimator.SetFloat("input_y", input_y);
        }
        PlayerAnimator.SetBool("IsWalking", IsWalking);
    }
}
