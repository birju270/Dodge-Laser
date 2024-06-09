using UnityEngine;
using UnityEngine.UI;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f;
    public Button jumpButton;
    private Rigidbody rb;
    private Animator animator;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        jumpButton.onClick.AddListener(Jump);
    }

    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);

        // Reset jump animation when grounded
        if (isGrounded)
        {
            animator.SetBool("isJumping", false);
        }
    }

    void Jump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            animator.SetBool("isJumping", true);
            isGrounded = false;
        }
    }
}
