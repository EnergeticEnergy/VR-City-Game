using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpBetweenPoints : MonoBehaviour
{
    public GameObject objectToMove;

    public Vector3[] positions;

    public float moveSpeed = 1f;

    float dist;

    int pointNum = 0;

    public bool moveRandomlyThroughArray = false;

    // Start is called before the first frame update
    void Start()
    {
        objectToMove.transform.position = positions[pointNum];
        pointNum ++;
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(objectToMove.transform.position, positions[pointNum]);
        if (dist > 1f)
        {
            Move();
        }
        else
        {
            if (moveRandomlyThroughArray)
            {
                if (pointNum + 1 == positions.Length)
                {
                    pointNum = 0;
                }
                else
                {
                    pointNum++;
                }
            }
            else
            {
                pointNum = Random.Range(0, positions.Length);
            }
        }
    }

    // Moves attached object
    public void Move()
    {
        objectToMove.transform.LookAt(positions[pointNum]);
        objectToMove.transform.position += objectToMove.transform.forward * moveSpeed * Time.deltaTime;
    }
}
