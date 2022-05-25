using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator mAnimator;
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
            if(Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("Pressed A");
                mAnimator.SetTrigger("Go1");
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
            Debug.Log("Pressed S");
            mAnimator.SetTrigger("Go2");
            }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Pressed D");
            mAnimator.SetTrigger("Go3");
        }
    }
        
    
}
