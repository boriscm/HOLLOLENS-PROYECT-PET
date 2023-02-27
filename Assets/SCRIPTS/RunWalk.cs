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

        float minDist = 0.52f;
        Vector3 v1 = aTarget.position;
        v1.y = 0;
        Vector3 v2 = transform.position;
        v2.y = 0;
        float distance = Vector3.Distance(v1, v2);

        bool walk = anim.GetBool("Walk");
        bool run = anim.GetBool("Run 0");
        bool none = anim.GetBool("None");

        if (distance> 2.5f)
        {
            anim.SetBool("Run 0", true);
            anim.SetBool("Walk", false);
            anim.SetBool("None", false);
        }
        else if ( 2.5f >= distance && distance > minDist)
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
