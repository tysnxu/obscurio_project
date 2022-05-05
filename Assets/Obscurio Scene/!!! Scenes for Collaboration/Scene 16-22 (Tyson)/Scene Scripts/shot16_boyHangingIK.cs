using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot16_boyHangingIK : MonoBehaviour
{
    Animator boyAnimator;
    // Start is called before the first frame update
    public GameObject boyRightArmIKTarget;
    public float boyRightArmIKWeight = 1.0f;
    public GameObject boyLeftArmIKTarget;
    public float boyLeftArmIKWeight = 0.0f;

    void Start()
    {
        boyAnimator = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex) {
        boyAnimator.SetIKPosition(AvatarIKGoal.RightHand, boyRightArmIKTarget.transform.position);
        boyAnimator.SetIKPositionWeight(AvatarIKGoal.RightHand, boyRightArmIKWeight);
        boyAnimator.SetIKPosition(AvatarIKGoal.LeftHand, boyLeftArmIKTarget.transform.position);
        boyAnimator.SetIKPositionWeight(AvatarIKGoal.LeftHand, boyLeftArmIKWeight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
