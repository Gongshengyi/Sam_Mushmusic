using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soilchange : MonoBehaviour
{
    public float timer;

    public float timergrowth;

    public MeshRenderer soil1;
    public MeshRenderer grass;


    bool particletrigger;

    void Start()
    {

    }
    void Update()
    {

        if (particletrigger)
        {
            timergrowth += Time.deltaTime;
            timergrowth = Mathf.Clamp(timergrowth, 0f, 3f);
            if (timergrowth >= 2f)
            {
                grass.material.SetFloat("_Width", (timergrowth - 2) * 0.02f);
            }
        }
    }
        

    void OnParticleCollision(GameObject other)
    {
        timer += Time.deltaTime * (1f / 3);
        timer = Mathf.Clamp(timer, 0f, 1f);
        

        particletrigger = true;

        
        Debug.Log("hit");
    }
}
