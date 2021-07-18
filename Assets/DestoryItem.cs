using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryItem : MonoBehaviour
{
    //mainCamera
    private GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        this.mainCamera = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(0, this.transform.position.y, this.mainCamera.transform.position.z);
    }

    void OnTriggerEnter(Collider other)
    {
        //衝突した場合
        if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag" || other.gameObject.tag == "CoinTag")
        {
            Destroy(other.gameObject);
        }
    }
}
