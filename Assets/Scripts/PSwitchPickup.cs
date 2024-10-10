using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EPSwitchState : byte
{
    Unknown,
    Active,
    Pressed
}
public class PSwitchPickup : Pickup
{
    private Animator animator;

    private EPSwitchState state = EPSwitchState.Unknown;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
        pickupType = EPickupType.PSwitch;
        
        SetState(EPSwitchState.Active);
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    public void SetState(EPSwitchState newState)
    {
        if (state == newState)
        {
            return;
        }
        
        state = newState;

        if (state == EPSwitchState.Active)
        {
            animator.Play("PSwitch_Active");
        }
        else if (state == EPSwitchState.Pressed)
        {
            animator.Play("PSwitch_Pressed");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!(collision.gameObject.CompareTag("Mario") && state == EPSwitchState.Active))
        {
            return;
        }


        Mario mario = collision.gameObject.GetComponent<Mario>();
        if (collision.contacts.Length > 0)
        {
            Vector2 normal = collision.contacts[0].normal;
            if (normal.y <= -0.7f)
            {
                SetState(EPSwitchState.Pressed);
                this.GetComponent<CapsuleCollider2D>().enabled = false;
            }
        }
    
    }
}
