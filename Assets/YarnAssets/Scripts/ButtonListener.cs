// To use this example, attach this script to an empty GameObject.
// Create two buttons (Create>UI>Button). Next, click your
// empty GameObject in the Hierarchy and click and drag each of your
// Buttons from the Hierarchy to the Your First Button and "Your Second Button"
// fields in the Inspector.
// Click each Button in Play Mode to output the message to the console.

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonListener : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button Button1, Button2, Button3;

    void Start()
    {
        Button btn1 = Button1.GetComponent<Button>();
        Button btn2 = Button2.GetComponent<Button>();
        Button btn3 = Button3.GetComponent<Button>();

        //Calls the TaskOnClick/TaskWithParameters method when you click the Button
        btn1.onClick.AddListener(TaskOnClick1);
        btn2.onClick.AddListener(TaskOnClick2);
        btn3.onClick.AddListener(TaskOnClick3);

    }

    void TaskOnClick1()
    {
        //Output this to console when the Button is clicked
        SceneManager.LoadScene("Syd Day 6");
    }
    void TaskOnClick2()
    {
        //Output this to console when the Button is clicked
        SceneManager.LoadScene("Syd Day 7");
    }
    void TaskOnClick3()
    {
        //Output this to console when the Button is clicked
        SceneManager.LoadScene("Stein Day 8");
    }
}
