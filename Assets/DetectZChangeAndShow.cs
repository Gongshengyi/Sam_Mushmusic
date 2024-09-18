using System.Collections;
using UnityEngine;

public class DetectZChangeAndShow : MonoBehaviour
{
    public GameObject objectA; 
    public GameObject mush;
    public GameObject objectwater;

    private float initialZ; 
    private bool hasZChanged = false; 

    void Start()
    {
        
        if (objectA != null)
        {
            initialZ = objectA.transform.position.z;
        }

        if (mush != null)
        {
            mush.SetActive(false);
            mush.transform.localScale = Vector3.one * 0.01f; 
        }

        if (objectwater != null)
        {
            objectwater.SetActive(false);
        }

    }

    void Update()
    {

        if (objectA != null && !hasZChanged)
        {
            if (objectA.transform.position.z != initialZ)
            {
                hasZChanged = true;

                StartCoroutine(ShowAndScaleObjectB());
            }
        }
    }

    private IEnumerator ShowAndScaleObjectB()
    {

        yield return new WaitForSeconds(2f);


        if (mush != null)
        {
            mush.SetActive(true);
            objectwater.SetActive(true);

            Vector3 originalScale = mush.transform.localScale;
            Vector3 targetScale = originalScale * 3f;
            float scaleTime = 2f;
            float elapsedTime = 0f;

            while (elapsedTime < scaleTime)
            {
                mush.transform.localScale = Vector3.Lerp(originalScale, targetScale, elapsedTime / scaleTime);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            mush.transform.localScale = targetScale;
        }

        if (objectA != null)
        {
            objectA.SetActive(false);
        }

    }
}
