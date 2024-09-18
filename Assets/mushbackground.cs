using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushbackground : MonoBehaviour
{
    public float Timer;
    private MeshRenderer MushRenderer;
    private AudioSource backgroundsound;
    // Start is called before the first frame update
    void Start()
    {
        MushRenderer = this.GetComponent<MeshRenderer>();
        backgroundsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime * 0.5f;

        if (backgroundsound.isPlaying)
        {
            MushRenderer.material.SetTextureOffset("_BaseMap",new Vector2(Timer, 0));
        }

    }
}
