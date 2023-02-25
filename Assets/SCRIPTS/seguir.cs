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
    float speedRun = 0.71f;

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




        float minDist = 0.5f;
        float distance = Vector3.Distance(aTarget.position, transform.position);
        bool val = minDist > distance;

        

        if ( /*some case  */ beingHandled)

        {
            if(distance > 3f)
            {
                Vector3 targectPos = new Vector3(aTarget.transform.position.x,
                                           transform.position.y,
                                           aTarget.transform.position.z);
                transform.LookAt(targectPos);


                transform.Translate(0.0f, 0.0f, speedRun * Time.deltaTime);

            }

            else if (minDist < distance)
            {
                Vector3 targectPos = new Vector3(aTarget.transform.position.x,
                                           transform.position.y,
                                           aTarget.transform.position.z);
                transform.LookAt(targectPos);


                transform.Translate(0.0f, 0.0f, speed * Time.deltaTime);

            }
            

        }
    }


}
