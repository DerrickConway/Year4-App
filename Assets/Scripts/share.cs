using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class share : MonoBehaviour {

    string AppID = "192893404955705";

    string Link = "https://google.com";

    string Caption = "Check out my Score: ";

    string Description = "Enjoy the Game Of Maze Runner";
	public void shareCountOnFacebook()
    {
        Application.OpenURL("https://www.facebook.com/dialog/feed?" + "app_id=" + AppID + "&link=" + Link + "&caption=" + Caption + "&description=" + Description);
    }
}
