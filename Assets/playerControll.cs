using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControll : MonoBehaviour
{
    public float moveSpeed = 2f;
    Rigidbody2D bd;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        bd = gameObject.GetComponent<Rigidbody2D>();
        bd.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            bd.velocity = Vector2.up * moveSpeed;
            animator.SetBool("isWalkF", true);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            bd.velocity = Vector2.down * moveSpeed;
            animator.SetBool("isWalkD", true);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            bd.velocity = Vector2.right * moveSpeed;
            animator.SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            bd.velocity = Vector2.left * moveSpeed;
            animator.SetBool("isWalk", true);
        }
        else
        {
            bd.velocity = Vector2.zero;
        }

        if (!Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("isWalkF", false);
        }
        if (!Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("not walkD");
            animator.SetBool("isWalkD", false);
        }
        if (!Input.GetKey(KeyCode.RightArrow)&&!Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("isWalk", false);
        }
    }
}
