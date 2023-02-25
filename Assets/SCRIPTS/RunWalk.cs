using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunWalk : MonoBehaviour
{
    public Transform origin;

    public Transform aTarget;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); 
    }


    IEnumerator waitFiveSeconds()
    {

        yield return new WaitForSeconds(3);
    }


 

    // Update is called once per frame
    void Update()
    {
        float minDist = 0.5f;
        float distance = Vector3.Distance(aTarget.position, transform.position);

        bool walk = anim.GetBool("Walk");
        bool run = anim.GetBool("Run 0");
        bool none = anim.GetBool("None");

        if (distance> 3f)
        {
            anim.SetBool("Run 0", true);
            anim.SetBool("Walk", false);
            anim.SetBool("None", false);
        }
        else if ( 3f >= distance && distance > minDist)
        {
            anim.SetBool("Run 0", false);
            anim.SetBool("Walk", true);
            anim.SetBool("None", false);
        }
        else
        {
            anim.SetBool("Run 0", false);
            anim.SetBool("Walk", false);
            anim.SetBool("None", true);
        }
        
    }
}
