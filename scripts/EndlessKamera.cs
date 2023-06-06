using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
public Transform target;

    public Transform B1;

    public Transform B2;

    private float size;


    private Vector3 cameraTargetPos = new Vector3();

    private Vector3 B1TargetPos = new Vector3();

    private Vector3 B2TargetPos = new Vector3();



    // Start is called before the first frame update

    void Start()

    {

        size = B1.GetComponent<BoxCollider2D>().size.y;

        size = B2.GetComponent<BoxCollider2D>().size.y;

    }


    // Update is called once per frame

    void LateUpdate()

    {

        

        Vector3 targetPos = SetPos(cameraTargetPos,target.position.x,target.position.y,transform.position.z);

        

        transform.position = Vector3.Lerp(transform.position,targetPos,0.2f);


        if (transform.position.y >= B2.position.y)

        {

        B1.position = SetPos(B1TargetPos ,B1.position.x,B2.position.y + size,B1.position.z);

        SwitchingBG();

        }

        if (transform.position.y <= B1.position.y)

        {

        B1.position = SetPos(B2TargetPos,B1.position.x,B2.position.y - size,B1.position.z);

        SwitchingBG();

        }




    }



        private void SwitchingBG()

        {

        Transform temp = B1;

        B1 = B2;

        B2 = temp;

        }


        private Vector3 SetPos(Vector3 pos,float x,float y , float z)

            {

            pos.x = x;

            pos.y = y;

            pos.z = z;

            return pos;

        }
}
