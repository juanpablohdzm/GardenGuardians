using UnityEngine;

public class DefendersSpawner : MonoBehaviour {

    private static GameObject DefenderParent;
	// Use this for initialization
	void Start () {
        DefenderParent = GameObject.Find("Defenders");
        if (!DefenderParent)
            DefenderParent = new GameObject("Defenders");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        GameObject DefenderClone=Instantiate(Button.SelectDefender, SnapToGrid(CalculateWorldPointOfMouseClick()), Quaternion.identity);
        DefenderClone.transform.parent = DefenderParent.transform;
     
    }
    private Vector2 SnapToGrid(Vector2 WorldPosition)
    {
        int NewX=Mathf.RoundToInt(WorldPosition.x);
        int NewY=Mathf.RoundToInt(WorldPosition.y);
        return new Vector2(NewX, NewY);
    }

    private Vector2 CalculateWorldPointOfMouseClick()
    {   
        return Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y ));
        //Other way would be Camera.main.ViewToWorldPoint(new Vector3(Input.mousePosition.x/Screen.width, Input.mousePosition.y/Screen.height ))
    }
}
