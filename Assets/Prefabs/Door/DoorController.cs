using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator animator;
    private Transform player;
    private const float maxDistance = 7;

    // Start is called before the first frame update
    void Start() {
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // toggle open/close on click
    void OnMouseDown() {
        float d = Vector3.Distance(transform.position, player.position);
        if (d < maxDistance)
            animator.SetBool("open", !animator.GetBool("open"));
    }
}
