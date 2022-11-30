using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isWalk", Input.GetAxis("Vertical") != 0f);
        animator.SetBool("isRun", Input.GetKey(KeyCode.LeftShift));
    }
}
