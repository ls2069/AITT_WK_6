using UnityEngine;
using System;
using System.Collections;
using Valve.VR;

public class ChestHingeVibrate : MonoBehaviour
{
    HingeJoint ChestHinge;
/*    private float duration;*/
    private float frequency;
/*    private float strength;*/
    public SteamVR_Behaviour_Pose controller = null;
    // Start is called before the first frame update
    void Start()
    {
        ChestHinge = GetComponent<HingeJoint>();
        frequency = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controller != null)
        {
            SteamVR_Actions.default_Haptic[controller.inputSource].Execute(0, 0.01f, frequency, 1.0f);
        }
        frequency = Mathf.Abs(ChestHinge.velocity);
    
    }

/*    void OnTriggerStay(Collider other)
    {
        SteamVR_Behaviour_Pose controller = other.GetComponent<SteamVR_Behaviour_Pose>();
        if (ChestHinge.velocity > 0.0f)
        {
            SteamVR_Actions.default_Haptic[controller.inputSource].Execute(0, 0.01f, frequency, 1.0f);
            Debug.Log(ChestHinge.velocity);
        }
    }*/
}
