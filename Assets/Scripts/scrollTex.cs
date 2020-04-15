using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollTex : MonoBehaviour
{
    [Range (0, 10)]
    public float scrollSpeed = 0.5f;

    public float scrollSpeedMultiplier = 1f;
    private Vector2 defaultOffsets;
    //private float defaultXoffset;
    private Renderer _renderer;


    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        defaultOffsets = _renderer.material.GetTextureOffset("_MainTex");
        //defaultXoffset = offsets.x;
    }

    // Update is called once per frame
    void Update()
    {
        float vOffset = Time.time * scrollSpeed*scrollSpeedMultiplier/50;
        _renderer.material.SetTextureOffset("_MainTex", new Vector2(defaultOffsets.x, defaultOffsets.y-vOffset));
    }
}
