using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;

    MeshRenderer myMesh; Rigidbody myRigid;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMesh = GetComponent<MeshRenderer>();
        myRigid = GetComponent<Rigidbody>();

        myMesh.enabled = false;
        myRigid.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            myMesh.enabled = true;
            myRigid.useGravity = true;
        }

    }
}
