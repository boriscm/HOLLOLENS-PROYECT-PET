using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguir : MonoBehaviour
{

    public Transform aTarget;

    public AnimationClip walk;

    public AnimationClip defaul;

    public AnimationClip run;

    private bool beingHandled = false;

    float speed = 0.35f;
    float speedRun = 1.79f;

    CharacterController controlador;

    Avatar avat;





    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("waitFiveSeconds");

    }

    IEnumerator waitFiveSeconds()
    {

        yield return new WaitForSeconds(4);

        beingHandled = true;
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
        bool val = minDist > distance;


        

        if ( /*some case  */ beingHandled)

        {
            if(distance > 0.3)
            {
                Vector3 targectPos = new Vector3(aTarget.transform.position.x,
                                           transform.position.y,
                                           aTarget.transform.position.z);
                transform.LookAt(targectPos);
            }

            if(distance > 2.5f)
            {

                transform.Translate(0.0f, 0.0f, speedRun * Time.deltaTime);

            }

            else if (minDist < distance)
            {

                transform.Translate(0.0f, 0.0f, speed * Time.deltaTime);

            }
            

        }
    }


}
