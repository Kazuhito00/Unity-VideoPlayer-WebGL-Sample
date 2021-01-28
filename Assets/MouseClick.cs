using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
	GameObject referenceObj;

    // Start is called before the first frame update
    void Start()
    {
		referenceObj = GameObject.Find("Plane");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            VideoLoader videoloader = referenceObj.GetComponent<VideoLoader>();
            videoloader.VideoPlayerControl();
        }
    }
}
