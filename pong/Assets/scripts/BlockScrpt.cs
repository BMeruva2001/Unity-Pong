using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BlockScrpt : MonoBehaviour
{
    public float blockSpeed;
    public float minY;
    public float maxY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "rightBlock")
        {
            float moveY = Input.GetAxisRaw("rightBlock") * blockSpeed * Time.deltaTime;
            transform.position = new Vector2(transform.position.x, math.clamp(transform.position.y + moveY,minY,maxY));
        }
        else if (gameObject.name == "leftBlock")
        {
            float moveY = Input.GetAxisRaw("leftBlock") * blockSpeed * Time.deltaTime;
            transform.position = new Vector2(transform.position.x , math.clamp(transform.position.y + moveY, minY, maxY));
        }
    }
}
