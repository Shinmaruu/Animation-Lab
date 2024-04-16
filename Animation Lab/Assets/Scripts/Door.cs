using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Fields

    // References
    [SerializeField] Animator animator;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ToggleOpenDoor()
    {
        if (animator.GetBool("DoorToggle"))
        {
            animator.SetBool("DoorToggle", false);
        }
        else
        {
            animator.SetBool("DoorToggle", true);
        }
    }
}