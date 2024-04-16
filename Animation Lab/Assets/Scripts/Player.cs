using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    [SerializeField] GameObject ps;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * 5 * Time.deltaTime;
            Debug.Log("moving forward");
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * 5 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * 5 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * 5 * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("flip", true);
            StartCoroutine(ShootConfetti());
        }
        else
        {
            animator.SetBool("flip", false);
            
        }
    }

    IEnumerator ShootConfetti() { 
        ps.SetActive(true);
        yield return new WaitForSecondsRealtime(2f);
        ps.SetActive(false);
    }
}
