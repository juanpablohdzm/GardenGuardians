using UnityEngine;
using UnityEngine.UI;

public class MyButton : MonoBehaviour
{
    private Button button;
    private Text CostText;
    private Image image;
    public GameObject DefenderPrefab;



    public static GameObject SelectDefender;
    private static GameObject selected;
    // Use this for initialization
    void Start()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClickButton);
        CostText = GetComponentInChildren<Text>();
        if (!CostText)
            Debug.LogWarning(name + " has no cost text");
        CostText.text = DefenderPrefab.GetComponent<Defenders>().StarCost.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Time.frameCount %3==0)
            if (selected != this.gameObject)
            {
               image.color = Color.black;
            }

    }
    private void OnClickButton()
    {


        selected = this.gameObject;
        SelectDefender = DefenderPrefab;
        image.color = Color.white;
        
    }
        
}
   

