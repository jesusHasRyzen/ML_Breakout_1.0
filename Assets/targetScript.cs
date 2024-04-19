using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetScript : MonoBehaviour
{


    public Transform parent;
    public GameObject targetBluePrint;
    // storing original target position
    float currentPosX;
    float currentPosY;
    float currentPosZ;

    //size of the targets
    float scaleX = 1;
    // float scaleY = .5f;
    // float scaleZ = .5f;

    bool isFieldFull = false;
    // Start is called before the first frame update
    void Start()
    {
        //get blueprint of the target cube
        targetBluePrint = parent.gameObject;
        // get the original x,y,z positions, to make duplicates.
        currentPosX = transform.position.x;
        currentPosY = transform.position.y;
        currentPosZ = transform.position.z;


        // generate random numbers to create targets of varying sizes
        // while (!isFieldFull)
        // {
        // scaleX = Random.Range(-3f, 3f);
        // currentPosX = currentPosX + scaleX;
        // var tempPos = new Vector3(currentPosX, currentPosY, currentPosZ);
        // Instantiate(targetBluePrint, tempPos, parent.rotation, parent);
        // isFieldFull = true;
        // }
    }
    void OnCollisionEnter(Collision collision)
    {
        // testing
        Debug.Log("collided with target action = disappear");
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
