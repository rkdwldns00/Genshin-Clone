using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Animator animator;
    public GameObject cam;
    bool attackBuffer;
    float timer;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        animator.SetBool("isWalk", Input.GetAxis("Vertical") != 0f || Input.GetAxis("Horizontal") != 0f);
        animator.SetBool("isRun", Input.GetKey(KeyCode.LeftShift));
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("useAttack");
            attackBuffer = true;
        }
        if (attackBuffer && animator.GetNextAnimatorStateInfo(0).length != 0)
        {
            attackBuffer = false;
            timer = animator.GetNextAnimatorStateInfo(0).length;
        }
        if ((Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) && timer <= 0) {
            transform.rotation = transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, (Mathf.Atan2(-Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * Mathf.Rad2Deg) + 90f, 0), transform.rotation, 1-Time.deltaTime * 5);
        }
        cam.transform.position = transform.position;
    }
}
