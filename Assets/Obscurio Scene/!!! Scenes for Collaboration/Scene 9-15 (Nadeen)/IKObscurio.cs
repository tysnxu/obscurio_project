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
        anim.SetIKHintPosition(AvatarIKHint.Head, hint.transform.position);
        anim.SetIKHintPositionWeight(AvatarIKHint.Head, IK_hint_weight);
        anim.SetIKPosition(AvatarIKGoal.Head, target.transform.position);
        anim.SetIKPositionWeight(AvatarIKGoal.Head, IK_weight);
    }

    // Update is called once per frame
    void Update()
    {

    }
}