using UnityEngine;

public class ScriptActivator : MonoBehaviour
{
    public Transform targetObject;  // 要检测的物体
    public MonoBehaviour scriptToControl;  // 要激活/关闭的脚本

    void Update()
    {
        if (Mathf.Approximately(targetObject.localPosition.z, 0.018f))
        {
            // 如果 targetObject 的 localPosition.z 等于 0.018f，激活脚本
            if (!scriptToControl.enabled)
            {
                scriptToControl.enabled = true;
            }
        }
        else
        {
            // 如果 targetObject 的 localPosition.z 不等于 0.018f，关闭脚本
            if (scriptToControl.enabled)
            {
                scriptToControl.enabled = false;
            }
        }
    }
}
