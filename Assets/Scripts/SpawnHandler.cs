using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHandler : MonoBehaviour
{
    public GameObject block;
    public GameObject scoreTrigger;

    private readonly float SCORE_TRIGGER_X_POS = 8.3f;
    private readonly float BLOCK_X_POS = 7.7f;
    private readonly float BLOCK_Z_ROTATION = 90f;

    void Start()
    {
        Instantiate(block, new Vector3(-2.2f, 5.5f, 0f), Quaternion.Euler(0f, 0f, 90f));
        Instantiate(scoreTrigger, new Vector3(-1.6f, -0.5f, 0f), Quaternion.identity);
        Instantiate(block, new Vector3(-2.2f, -5.5f, 0f), Quaternion.Euler(0f, 0f, 90f));

        Instantiate(block, new Vector3(2.85f, 5.5f, 0f), Quaternion.Euler(0f, 0f, 90f));
        Instantiate(scoreTrigger, new Vector3(3.45f, -0.5f, 0f), Quaternion.identity);
        Instantiate(block, new Vector3(2.85f, -5.5f, 0f), Quaternion.Euler(0f, 0f, 90f));

        Instantiate(block, new Vector3(7.7f, 5.5f, 0f), Quaternion.Euler(0f, 0f, 90f));
        Instantiate(scoreTrigger, new Vector3(8.3f, -0.5f, 0f), Quaternion.identity);
        Instantiate(block, new Vector3(7.7f, -5.5f, 0f), Quaternion.Euler(0f, 0f, 90f));

        StartCoroutine(SpawnBlocks());
    }

    IEnumerator SpawnBlocks()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            float upBorder = Random.Range(3f, 8f);
            float triggerPos = upBorder - 6f;
            float downBorder = upBorder - 11f;
            Instantiate(block, new Vector3(BLOCK_X_POS, upBorder, 0f), Quaternion.Euler(0f, 0f, BLOCK_Z_ROTATION));
            Instantiate(scoreTrigger, new Vector3(SCORE_TRIGGER_X_POS, triggerPos, 0f), Quaternion.identity);
            Instantiate(block, new Vector3(BLOCK_X_POS, downBorder, 0f), Quaternion.Euler(0f, 0f, BLOCK_Z_ROTATION));
        }
    }
 
}
