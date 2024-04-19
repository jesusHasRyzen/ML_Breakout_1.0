using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class paddleScript : MonoBehaviour
{

    private float moveSpeed, move;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

    }

    private void LateUpdate()
    {
        transform.Translate(0f, move, 0f);
    }
}
