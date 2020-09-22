using System.Collections;
using UnityEngine;

public class TargetFrameRate : MonoBehaviour
{
    public int target = 144;
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 144;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != Application.targetFrameRate ) {
            Application.targetFrameRate = target;
        }
    }
}
