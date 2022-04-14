using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateBoyEye : MonoBehaviour
{
    private Renderer boyEyeRenderer;

    public int frameSpeed = 1;
    public bool playAnimation = false; 
    private float timer = 0;
    private float frameNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        boyEyeRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playAnimation) {
            timer += Time.deltaTime;

            if (timer > 0.05) 
            {
                timer = 0;
                frameTick();
            }
        }
    }

    void frameTick() 
    {        
        frameNumber += 1;
        float offset = frameNumber * (frameSpeed * 0.05f);
        Vector2 newOffset = new Vector2(offset, 0);
        boyEyeRenderer.material.SetTextureOffset("_MainTex", newOffset);
    }
}
