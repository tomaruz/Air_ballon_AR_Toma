using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBalloon : MonoBehaviour
{
    public float lengthOfFrame = 3f; // this is duration one image is shown before advancing to the next
    public float timeSinceLastFrame; // this is used to count time since the frame last changed.
    public float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {

        timeSinceLastFrame += Time.deltaTime; // every frame add how long it took to render that frame to timeSinceLastFrame

        if (timeSinceLastFrame >= lengthOfFrame) // when larger than the pre-set lengthOfFrame then..
        {
            transform.position += (Vector3.up * speed) * Time.deltaTime;
        }
    }

    public void ReverseDirection()
    {
        speed = speed * -1f;
    }

}
