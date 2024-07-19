using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{
    private bool isScale;
    private float scaleSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isScale)
        {
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
        }
    }

    public void ScaleCube(float speed)
    {
        isScale = true;
        scaleSpeed = speed;
    }

    public void Stop()
    {
        isScale = false;
    }
}
