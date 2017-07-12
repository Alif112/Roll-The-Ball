// this is working on the Ball. To control ball, to control line renderer.
// to the the preVelocity 



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDragging : MonoBehaviour {
    public float maxStrech = 3.0f;


    public LineRenderer catapultLineFront;
    public LineRenderer catapultLineBack;
    public bool clickedOn;

    private SpringJoint2D spring;

    private Ray rayToMouse;
    private Ray letfCatapultToProjectile;
    private float maxStrechSqr;

    private Transform catapult;
    private float circleRadius;
    private Vector2 preVelocity;

    void Awake()
    {
        spring = GetComponent<SpringJoint2D>();
        catapult = spring.connectedBody.transform;

    }

    void Start () {
        LineRendererSetup();
        rayToMouse = new Ray(catapult.position, Vector3.zero);
        letfCatapultToProjectile = new Ray(catapultLineFront.transform.position, Vector3.zero);


        maxStrechSqr = maxStrech * maxStrech;
        CircleCollider2D circle = GetComponent<Collider2D>() as CircleCollider2D;
        
        circleRadius = circle.radius;
		
	}
	
	
	void Update () {
        if (clickedOn)
        {
            Dragging();
        }
        if (spring != null)
        {
            if (!GetComponent<Rigidbody2D>().isKinematic && preVelocity.sqrMagnitude > GetComponent<Rigidbody2D>().velocity.sqrMagnitude) {
                Destroy(spring);
                GetComponent<Rigidbody2D>().velocity = preVelocity;
               // Debug.Log(preVelocity);

            }
            if (!clickedOn)
            {
                preVelocity = GetComponent<Rigidbody2D>().velocity;
                //Debug.Log(preVelocity);
            }
           

            LineRendererUpdate();
        }
        else {
            catapultLineFront.enabled = false;
            catapultLineBack.enabled = false;
        }
		
	}

    void LineRendererSetup() {
        catapultLineFront.SetPosition(0, catapultLineFront.transform.position);
        catapultLineBack.SetPosition(0, catapultLineBack.transform.position);
        catapultLineFront.sortingLayerName="foreground";
        catapultLineBack.sortingLayerName = "foreground";

        catapultLineFront.sortingOrder = 3;
        catapultLineBack.sortingOrder = 1;
    }
    void OnMouseDown()
    {
        spring.enabled = false;
        clickedOn = true;
    }
    void OnMouseUp()
    {
        spring.enabled = true;
        GetComponent<Rigidbody2D>().isKinematic = false;
        clickedOn = false;
    }
    void Dragging() {
        Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 catapultToMouse = mouseWorldPoint - catapult.position;

        if (catapultToMouse.sqrMagnitude > maxStrechSqr) {
            rayToMouse.direction = catapultToMouse;
            mouseWorldPoint = rayToMouse.GetPoint(maxStrech);
            Debug.Log("Drag Done");
        }

        mouseWorldPoint.z = 0.0f;
        transform.position = mouseWorldPoint;
    }
    void LineRendererUpdate() {
        Vector2 catapultToProjectile = transform.position - catapultLineFront.transform.position;
        letfCatapultToProjectile.direction = catapultToProjectile;

        Vector3 holdPoint = letfCatapultToProjectile.GetPoint(catapultToProjectile.magnitude + circleRadius);

        catapultLineFront.SetPosition(1, holdPoint);
        catapultLineBack.SetPosition(1, holdPoint);



    }


}
