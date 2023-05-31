using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 thirdViewOffset =  new Vector3(0,5,-7);
    public Vector3 firstViewOffset =  new Vector3(0,2,3);
    private bool thirdView = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        //If the user presses the ctrl key the view has to switch
        if(Input.GetKeyDown(KeyCode.LeftControl) == true)
            thirdView= !thirdView;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(thirdView)
            transform.position = player.transform.position + thirdViewOffset;
        else
            transform.position = player.transform.position + firstViewOffset;
    }
}
