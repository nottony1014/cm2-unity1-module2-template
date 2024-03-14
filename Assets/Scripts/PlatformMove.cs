using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public Transform endPosition;
    private Transform startPosition;
    public float speed = 2;
    bool movingBack = false;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position ==endPosition.position)
            movingBack = true;
        if (transform.position == startPosition.position)
            movingBack = false;
        if (!movingBack)
            Vector3.MoveTowards(transform.position, endPosition.position, speed);
        else
            Vector3.MoveTowards(transform.position, startPosition.position, speed);
    }
}
