using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKObscurio : MonoBehaviour
{
    Animator anim;
    public GameObject target;
    public float IK_weight = 1.0f;
    public GameObject hint;
    public float IK_hint_weight = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        anim.SetIKPosition(AvatarIKGoal.RightHand, target.transform.position);
        anim.SetIKPositionWeight(AvatarIKGoal.RightHand, IK_weight);
    }

    // Update is called once per frame
    void Update()
    {

    }
}