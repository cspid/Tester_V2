// To use this example, attach this script to an empty GameObject.
// Create two buttons (Create>UI>Button). Next, click your
// empty GameObject in the Hierarchy and click and drag each of your
// Buttons from the Hierarchy to the Your First Button and "Your Second Button"
// fields in the Inspector.
// Click each Button in Play Mode to output the message to the console.

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonListenerOctDemoDaySelect : MonoBehaviour
{
  

    public void Day1()
    {
        //Output this to console when the Button is clicked
        SceneManager.LoadScene("OctDemo Day 1");
    }
    public void Day2()
    {
        //Output this to console when the Button is clicked
        SceneManager.LoadScene("OctDemo Day 2");
    }
    public void Day3()
    {
        //Output this to console when the Button is clicked
        SceneManager.LoadScene("OctDemo Day 3");
    }
}
