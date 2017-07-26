using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class StarDisplay : MonoBehaviour {

    private Text text;
    private int Stars = 100;
    public enum Status{SUCCESS,FAILURE };


    private void Awake()
    {
        text = transform.GetComponent<Text>();
    }
    private void Start()
    {
        UpdateDisplay();
    }
    public void AddStars(int stars)
    {
        Stars += stars;
        UpdateDisplay();
    }

    public Status UseStars(int amount)
    {
        if (Stars >= amount)
        {
            Stars -= amount;
            UpdateDisplay();
            return Status.SUCCESS;
        }
        else
        {
            return Status.FAILURE;
        }
    }

    public void UpdateDisplay()
    {
        text.text = "Star Count: " + Stars;
    }

}
