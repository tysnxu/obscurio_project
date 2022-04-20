using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot16_boyHangingIK : MonoBehaviour
{
    Animator boyAnimator;
    // Start is called before the first frame update
    public GameObject boyArmIKTarget;
    public float boyArmIKWeight = 1.0f;

    void Start()
    {
        boyAnimator = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex) {
        boyAnimator.SetIKPosition(AvatarIKGoal.LeftHand, boyArmIKTarget.transform.position);
        boyAnimator.SetIKPositionWeight(AvatarIKGoal.LeftHand, boyArmIKWeight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
