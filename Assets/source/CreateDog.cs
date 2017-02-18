using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDog : MonoBehaviour {

	public GameObject obj;
    private GameObject i_obj = null;
    private SpriteRenderer spRenderer = null;

    // Use this for initialization
    void Start () {
		Debug.Log ("start");
    }
	
	// Update is called once per frame
	void Update () {
		if (i_obj != null) {
            var color = spRenderer.color;
            color.a -= 0.01f;
            spRenderer.color = color;
            if (spRenderer.color.a <= 0.0f){
                Destroy(i_obj);
                i_obj = null;
                spRenderer = null;
            }
        }
	}

	public void Create () {
        //GameObject instance = (GameObject)Instantiate(obj);
        //instance.transform.position = gameObject.transform.position;
        if (i_obj != null){
            Destroy(i_obj);
            i_obj = null;
            spRenderer = null;
        }
        i_obj = Instantiate(obj,new Vector3(0,0,0),Quaternion.identity);
        spRenderer = i_obj.GetComponent<SpriteRenderer>();
    }
}
