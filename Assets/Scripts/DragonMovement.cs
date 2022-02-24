using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonMovement : MonoBehaviour
{

    [SerializeField]
    private float jumpForce = 3f;

    private int score = 0;

    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        DragonJump();

        if (transform.position.y < -5.75f)
        {
            Debug.Log("GAME OVER!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    void DragonJump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Debug.LogError("GAME OVER!");
            Debug.Log(score);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Score"))
        {
            score++;
        }
    }

}
