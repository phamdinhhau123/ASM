using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg_infynityas : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.111f;
    public float offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        offset += Time.deltaTime * speed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offset, 0);
    }
}
