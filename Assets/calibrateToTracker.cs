using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calibrateToTracker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _environment;
    [SerializeField] private GameObject _tracker;
    private Vector3 trackerInitPos;
    private float posX;
    private float posY;
    private float posZ;
    private Vector3 origin;
    void Start()
    {
        StartCoroutine(Waiter());
    }

    // Update is called once per frame
    void Update()
    {
        // posX = .27f;
        // posZ = 4.42f;
        // trackerInitPos = _tracker.transform.position;
        // Debug.Log(trackerInitPos);
        // Debug.Log(trackerInitPos[0]);
        // posX = trackerInitPos[0];
        // posZ = trackerInitPos[2];
        // origin = new Vector3(posX, 0f, posZ);
        // _environment.transform.position = (origin); 
    }

    IEnumerator Waiter()
    {
        Debug.Log(Time.time);
        yield return new WaitForSeconds(5);
        posX = .27f;
        posZ = 4.42f;
        trackerInitPos = _tracker.transform.position;
        Debug.Log(trackerInitPos);
        Debug.Log(trackerInitPos[0]);
        posX = trackerInitPos[0];
        posZ = trackerInitPos[2];
        origin = new Vector3(posX, 0f, posZ);
        _environment.transform.position = (origin); 
        Debug.Log(Time.time);
    }
}
