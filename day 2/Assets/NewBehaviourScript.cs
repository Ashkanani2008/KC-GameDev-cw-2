using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string heroname = "Hussain";
    int heropower = 200;
    //
    string villainname = "shadow";
    int villainpower = 200;
    float playerspeed = 2.7f;

    // Start is called before the first frame update
    void Start()
    {
        if (heropower >= villainpower)
        {
            print("villain is powerful than heropower");
        }
        else if (heropower < villainpower)
        {
            print("heropwer stronger than villa");
        }

        else
        {
            print("heropower equal villainpower");
        }






        print(playerspeed);
        setspeed(2.5f);
        print(playerspeed);

    }





    // Update is called once per frame
    void Update()
    {

    }
    void setspeed(float speed)
    {
        playerspeed = speed;
    }
}
