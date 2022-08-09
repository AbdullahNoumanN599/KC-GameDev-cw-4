using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    int score = 0;
    int increment = 1;
    public Text text1;
    public Text text2;
    string WoksWrath = "MINUS 20 SOCIAL CREDIT FOR YOUUUU!";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void increase()
    {
        score += increment;
        text1.text = "social credit score= " + score.ToString();
    }

    public void store()
    {
        if (score >= 5)
        {
            increment++;
            score -= 5;
            text1.text = score.ToString();
            text2.text = "";
        }
        else
        {
            text2.text = WoksWrath;
            score -= 20;
        }
    }
}
