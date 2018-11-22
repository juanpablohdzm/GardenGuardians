using UnityEngine;

public class DefendersSpawner : MonoBehaviour {

    public static GameObject DefenderParent;
    private StarDisplay starDisplay;

	// Use this for initialization
	void Start () {
        DefenderParent = GameObject.Find("Defenders");
        if (!DefenderParent)
            DefenderParent = new GameObject("Defenders");
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
        if (!starDisplay) print("Not star display");
        
	}
	
	// Update is called once per frame
	void Update () {
      
	}

    private void OnMouseDown()
    {
        if (starDisplay.UseStars(MyButton.SelectDefender.GetComponent<Defenders>().StarCost) == StarDisplay.Status.SUCCESS)
        {


            GameObject DefenderClone = Instantiate(MyButton.SelectDefender, SnapToGrid(CalculateWorldPointOfMouseClick()), Quaternion.identity) as GameObject;

            DefenderClone.transform.parent = DefenderParent.transform;
            starDisplay.UpdateDisplay();
        }
        else
        {
            print("Not stars");
        }
     
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
