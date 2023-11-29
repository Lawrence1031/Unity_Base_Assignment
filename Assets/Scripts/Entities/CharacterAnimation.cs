using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        FlipX();
    }

    void FlipX()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        bool IsFlip = mousePosition.x < transform.position.x;

        animator.SetBool("flipX", IsFlip);

    }

    //void PressedKey()
    //{
    //    if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) ||
    //        Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
    //        animator.SetBool("IsPressed", true);
    //}    
}
