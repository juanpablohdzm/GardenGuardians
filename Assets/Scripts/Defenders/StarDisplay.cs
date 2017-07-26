using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class StarDisplay : MonoBehaviour {

    private Text text;
    private int Stars = 0;


    private void Start()
    {
        text = transform.GetComponent<Text>();
    }
    public void AddStars(int stars)
    {
        Stars += stars;
        UpdateDisplay();
    }

    public void UseStars(int amount)
    {
        Stars -= amount;
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        text.text = "Star Count: " + Stars;
    }

}
