using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{

    [SerializeField]
    private float speed = 0.05f;

    // public DragonMovement player;

    private Vector3 tempPos;

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveBlock();
    }

    void MoveBlock()
    {
        tempPos = transform.position;
        tempPos.x -= speed;
        transform.position = tempPos;
        if (transform.position.x < -10f)
        {
            Debug.Log("Destroyed!");
            // player.score++;
            Destroy(this.gameObject);
        }
    }

}
