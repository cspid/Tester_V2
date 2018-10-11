// To use this example, attach this script to an empty GameObject.
// Create two buttons (Create>UI>Button). Next, click your
// empty GameObject in the Hierarchy and click and drag each of your
// Buttons from the Hierarchy to the Your First Button and "Your Second Button"
// fields in the Inspector.
// Click each Button in Play Mode to output the message to the console.

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonListenerCharSelect : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
   
    public void Williams()
    {
        //Output this to console when the Button is clicked
        SceneManager.LoadScene("Choose Scene - Williams");
    }
    public void Stein()
    {
        //Output this to console when the Button is clicked
        SceneManager.LoadScene("Choose Scene - Stein");
    }
    public void Syd()
    {
        //Output this to console when the Button is clicked
        SceneManager.LoadScene("Choose Scene - Syd");
    }
    public void Bard()
    {
        //Output this to console when the Button is clicked
        SceneManager.LoadScene("Choose Scene - Bard");
    }
    public void OctDemo()
    {
        //Output this to console when the Button is clicked
        SceneManager.LoadScene("Choose Scene - OctDemo");
    }
}
