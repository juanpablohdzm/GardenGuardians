using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    private Button[] buttonArray;
    private Text CostText;
    public GameObject DefenderPrefab;



    public static GameObject SelectDefender;
    // Use this for initialization
    void Start()
    {
        buttonArray = GameObject.FindObjectsOfType<Button>();
        CostText = GetComponentInChildren<Text>();
        if (!CostText)
            Debug.LogWarning(name + " has no cost text");
        CostText.text = DefenderPrefab.GetComponent<Defenders>().StarCost.ToString();
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnMouseDown()
    {
        for (int i = 0; i < buttonArray.Length; i++)
        {
            if (buttonArray[i].gameObject == GetComponent<Button>().gameObject)
            {
               
                GetComponent<SpriteRenderer>().color = Color.white;
                SelectDefender = DefenderPrefab;
            }
            else
            {
                
                buttonArray[i].GetComponent<SpriteRenderer>().color = Color.black;
            }
           

        }
        
    }
   
}
