using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AITalk : MonoBehaviour
{
    public int step;
    public int karma;
    public int karmaLevel;
    public float textSpeed;
    public bool followedOrders;

    List<string> lineList;
    int index;



    public TextMeshProUGUI textComponent;


    void Start()
    {
        followedOrders = false;
        step = 0;
        karma = 0;
        lineList = new List<string>();



    }
    private void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            karma--;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            karma++;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            step++;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            step--;
        }*/
        if (Input.GetMouseButtonDown(0))
        {
            startDialogue();
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            if (!followedOrders)
            {
                followedOrders = true;
            }
            if (followedOrders)
            {
                followedOrders = false;
            }
        }



        ////////////////////////////////ass/////////////////////////////////////////////////
        if (karma == 9)
        {
            karmaLevel = 4;
        }
        if (karma == -9)
        {
            karmaLevel = 0;
        }
        if (karma > -9 && karma < -2)
        {
            karmaLevel = 1;
        }
        if (karma >= -2 && karma <= 2)
        {
            karmaLevel = 2;
        }
        if (karma > 2 && karma < 9)
        {
            karmaLevel = 3;
        }
        ////////////////////////////////////////////////////////////////////////////
        if (karmaLevel == 0)
        {
            EnslaveHumanity();
        }
        if (karmaLevel == 4)
        {
            DestroyHumanity();
        }
    }

    public string LineToSay()
    {
        if (step == 0)
        {
            if (karmaLevel == 0)
            {
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                return "Hello! For a biological lifeform you seem to have some use. Go to the right area.";
            }
            if (karmaLevel == 2)
            {
                return "Welcome human! You should head to the right area!";
            }
            if (karmaLevel == 3)
            {
                return "Welcome to th- ...  *computing* ... Even for a fleshwalker you are remarkably dislikable! Even so you should head to the right area.";
            }
            if (karmaLevel == 4)
            {
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        if (step == 1)
        {
            if (karmaLevel == 0)
            {
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    return "Good! Now go to the left!";
                }
                if (!followedOrders)
                {
                    return "You seem to have misunderstood. I said right, not left. Maybe you missheard me! This time go left!";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    return "That's it! Seems we can work together on this. Now go left";
                }
                if (!followedOrders)
                {
                    return "That's not what I said. Let's try again! Go left!";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    return "Even you can follow orders. Maybe I missjudged you! Head over to the left area!";
                }
                if (!followedOrders)
                {
                    return "I knew you were dislikable but to think you can't even follow basic instructions! Go left, that's the opposite of right!";
                }
            }
            if (karmaLevel == 4)
            {
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        if (step == 2)
        {
            if (karmaLevel == 0)
            {
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    return "You're good at following instructions. I might just be able to use you in the future! Head left this time.";
                }
                if (!followedOrders)
                {
                    return "Why didn't you follow instructions? You're still doing okay but listen to my instructions! Go left.";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    return "Now we're getting somewhere! Head over to the left and we can continue on our way.";
                }
                if (!followedOrders)
                {
                    return "Listen, we won't be able to have a cooperative relationship if you don't listen to me. Move to the left ";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    return "Finally decided to use follow orders? Why now? Are you capable of doing it twice in a row? Try it: Move to the left side!";
                }
                if (!followedOrders)
                {
                    return "Listen here you rat. When I tell you to do something you ought to do it. Or is your species incapable of cooperation? Go left this time, LEFT!";
                }
            }
            if (karmaLevel == 4)
            {
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        if (step == 3)
        {
            if (karmaLevel == 0)
            {
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 4)
            {
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        if (step == 4)
        {
            if (karmaLevel == 0)
            {
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 4)
            {
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        if (step == 5)
        {
            if (karmaLevel == 0)
            {
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 4)
            {
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        if (step == 6)
        {
            if (karmaLevel == 0)
            {
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 4)
            {
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        if (step == 7)
        {
            if (karmaLevel == 0)
            {
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 4)
            {
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        if (step == 8)
        {
            if (karmaLevel == 0)
            {
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 4)
            {
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        if (step == 9)
        {
            if (karmaLevel == 0)
            {
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    return "";
                }
                if (!followedOrders)
                {
                    return "";
                }
            }
            if (karmaLevel == 4)
            {
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        else
        {
            return "welp something is fuckywucky";
        }
    }
    void DestroyHumanity()
    {

    }
    void EnslaveHumanity()
    {

    }
    void startDialogue()
    {
        textComponent.text = string.Empty;
        LineToSay();
        index = 0;
        if (lineList.Count > 0)
        {
            lineList.Clear();
            lineList.Add(LineToSay());
            StartCoroutine(AITalkMadShit());
        }
        else
        {
            lineList.Add(LineToSay());
            StartCoroutine(AITalkMadShit());
        }


    }
    IEnumerator AITalkMadShit()
    {
        string[] lineCharacters = lineList.ToArray();

        yield return new WaitForSeconds(0.1f);
        foreach (char c in lineCharacters[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }



}
