using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsManager : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
       animator = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    public void Idle1()
    {
        if (animator.GetBool("NeutralIdle") == false)
        {
            if (animator.GetBool("FightIdle") == true)
            {
                animator.SetBool("FightIdle", false);
            }

            animator.SetBool("NeutralIdle", true);
        }
    }

    public void Idle2()
    {
        if (animator.GetBool("FightIdle") == false)
        {
            if (animator.GetBool("NeutralIdle") == true)
            {
                animator.SetBool("NeutralIdle", false);
            }

            animator.SetBool("FightIdle", true);
        }
    }

    public void Punch()
    {
        animator.SetTrigger("Punch");
    }

    public void Kick()
    {
        animator.SetTrigger("Kick");
    }

    public void Backflip()
    {
        animator.SetTrigger("Backflip");
    }
}
