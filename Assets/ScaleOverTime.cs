using UnityEngine;

public class ScaleOverTime : MonoBehaviour
{
    public Transform objectA; 
    public Transform objectB; 
    public float duration = 3f; 

    private Vector3 initialScale; 
    private Vector3 doubleScale; 
    private Vector3 targetScale; 
    private float elapsedTime = 0f; 
    private bool isScaling = false; 


    void Update()
    {
            
        if (objectA.localPosition.z == 0.018f)
        {
            StopScaling(); 
        }
            
        else if (objectA.localPosition.z != 0.018f)
        {
                
            if (objectA.localPosition.z == 0f)
            {
                targetScale = doubleScale;
                StartScaling();
            }
            else
            {
                targetScale = initialScale * 1.5f; 
                StartScaling();
            }
        }
    

        if (isScaling)
        {
            elapsedTime += Time.deltaTime;

            float t = elapsedTime / duration;

            objectB.localScale = Vector3.Lerp(objectB.localScale, targetScale, t);

            if (elapsedTime >= duration)
            {
                objectB.localScale = targetScale;
                isScaling = false;
            }
        }
    }

    void StartScaling()
    {
        elapsedTime = 0f;
        isScaling = true;
    }

    void StopScaling()
    {
        isScaling = false;
    }
}
