using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    public Collider ballCollider;
    float currentPosX;
    float currentPosY;
    float currentPosZ;
    float speedX = (float)0.01;
    float speedZ = 0.01f;
    private bool isGameOver = false;
    // Start is called fbefore the first frame update
    void Start()
    {
        currentPosX = transform.position.x;
        currentPosY = transform.position.y;
        currentPosZ = transform.position.z;


    }

    void OnCollisionEnter(Collision collision)
    {
        // testing
        // Debug.Log("collided with top wall no other action");
        Debug.Log(collision.collider.gameObject.name);

        // check if wall hit was the side one or the top wall or bottom
        string ColliderHit = collision.collider.gameObject.name;
        Debug.Log(ColliderHit);
        if (ColliderHit == "Cube (right)" || ColliderHit == "Cube (left)")
        {
            Debug.Log("inside right collision");
            speedX = speedX * -1;
        }
        // if top border hit, keep ball in the field
        else if (ColliderHit == "Cube (top)")
        {
            Debug.Log("inside top collision");

            speedZ = speedZ * -1;
        }
        // if bottom border hit end game
        else if (ColliderHit == "Cube (cameraAngle)")
        {
            Debug.Log("inside bottom collision");
            isGameOver = true;
        }
        else
        {
            speedX = speedX * -1;
            speedZ = speedZ * -1;
        }

        Debug.Log("no if statement executed");

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            // only works for editor
            UnityEditor.EditorApplication.isPlaying = false;
            // Application.Quit();
        }
        // currentPosX += (float)0.001;
        currentPosZ += speedZ;
        currentPosX += speedX;
        // currentPosZ += speed;
        transform.localPosition = new Vector3(currentPosX, currentPosY, currentPosZ);


    }

}
