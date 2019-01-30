using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start() {
        animator = GetComponent<Animator>();
    }

    // toggle open/close on click
    void OnMouseDown() {
        animator.SetBool("open", !animator.GetBool("open"));
    }
}
