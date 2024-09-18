using UnityEngine;

public class ScriptActivator : MonoBehaviour
{
    public Transform targetObject;  // Ҫ��������
    public MonoBehaviour scriptToControl;  // Ҫ����/�رյĽű�

    void Update()
    {
        if (Mathf.Approximately(targetObject.localPosition.z, 0.018f))
        {
            // ��� targetObject �� localPosition.z ���� 0.018f������ű�
            if (!scriptToControl.enabled)
            {
                scriptToControl.enabled = true;
            }
        }
        else
        {
            // ��� targetObject �� localPosition.z ������ 0.018f���رսű�
            if (scriptToControl.enabled)
            {
                scriptToControl.enabled = false;
            }
        }
    }
}
