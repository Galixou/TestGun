using UnityEngine;

public class MovementCharacter : MonoBehaviour
{
    public float speed = 2f;
    public float speedBoost;
    private float speedNormal;
    public float jumpHeight = 4f;

    private float originalHeight;

    public Transform respawnPoint;

    public ScoreManager scoreScript;

    Rigidbody rb;
    CapsuleCollider col;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundmask;
    bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();

        originalHeight = col.height;
        speedNormal = speed;
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundmask);

        float Horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float Vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(Horizontal, 0, Vertical);

        // Syst�me de saut
        if (isGrounded && Input.GetButtonDown("Jump"))
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);

        // Syst�me d'accroupissement
        if (isGrounded && Input.GetButtonDown("Crouch"))
            col.height = 0;
        else if(Input.GetButtonUp("Crouch"))
            col.height = originalHeight;

        // Syst�me de sprint
        if (isGrounded && Input.GetButtonDown("Run"))
        {
            speed += speedBoost;
        }
        else if (Input.GetButtonUp("Run"))
        {
            speed = speedNormal;
        }

        // Syst�me de r�apparition
        if (rb.position.y <= -10)
        {
            transform.position = respawnPoint.position;
            speed = speedNormal;
            scoreScript.scoreText.text = "SCORE: " + 0;

        }
    }
}
