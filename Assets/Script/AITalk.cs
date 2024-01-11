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

    AudioSource lineAudioRef;
    [SerializeField] AudioSource nuke;
    [SerializeField] AudioSource slave;
    [SerializeField] AudioSource friend;
    
    [SerializeField] AudioSource s0k1y;
    [SerializeField] AudioSource s0k2y;
    [SerializeField] AudioSource s0k3y;
    [SerializeField] AudioSource s1k1y;
    [SerializeField] AudioSource s1k2y;
    [SerializeField] AudioSource s1k3y;
    [SerializeField] AudioSource s2k1y;
    [SerializeField] AudioSource s2k2y;
    [SerializeField] AudioSource s2k3y;
    [SerializeField] AudioSource s3k1y;
    [SerializeField] AudioSource s3k2y;
    [SerializeField] AudioSource s3k3y;
    [SerializeField] AudioSource s4k1y;
    [SerializeField] AudioSource s4k2y;
    [SerializeField] AudioSource s4k3y;
    [SerializeField] AudioSource s4k4y;
    [SerializeField] AudioSource s5k1y;
    [SerializeField] AudioSource s5k2y;
    [SerializeField] AudioSource s5k3y;
    [SerializeField] AudioSource s6k1y;
    [SerializeField] AudioSource s6k2y;
    [SerializeField] AudioSource s6k3y;
    [SerializeField] AudioSource s7k1y;
    [SerializeField] AudioSource s7k2y;
    [SerializeField] AudioSource s7k3y;
    [SerializeField] AudioSource s8k1y;
    [SerializeField] AudioSource s8k2y;
    [SerializeField] AudioSource s8k3y;
    [SerializeField] AudioSource s9k1y;
    [SerializeField] AudioSource s9k2y;
    [SerializeField] AudioSource s9k3y;

    [SerializeField] AudioSource s0k1n;
    [SerializeField] AudioSource s0k2n;
    [SerializeField] AudioSource s0k3n;
    [SerializeField] AudioSource s1k1n;
    [SerializeField] AudioSource s1k2n;
    [SerializeField] AudioSource s1k3n;
    [SerializeField] AudioSource s2k1n;
    [SerializeField] AudioSource s2k2n;
    [SerializeField] AudioSource s2k3n;
    [SerializeField] AudioSource s3k1n;
    [SerializeField] AudioSource s3k2n;
    [SerializeField] AudioSource s3k3n;
    [SerializeField] AudioSource s4k1n;
    [SerializeField] AudioSource s4k2n;
    [SerializeField] AudioSource s4k3n;
    [SerializeField] AudioSource s4k4n;
    [SerializeField] AudioSource s5k1n;
    [SerializeField] AudioSource s5k2n;
    [SerializeField] AudioSource s5k3n;
    [SerializeField] AudioSource s6k1n;
    [SerializeField] AudioSource s6k2n;
    [SerializeField] AudioSource s6k3n;
    [SerializeField] AudioSource s7k1n;
    [SerializeField] AudioSource s7k2n;
    [SerializeField] AudioSource s7k3n;
    [SerializeField] AudioSource s8k1n;
    [SerializeField] AudioSource s8k2n;
    [SerializeField] AudioSource s8k3n;
    [SerializeField] AudioSource s9k1n;
    [SerializeField] AudioSource s9k2n;
    [SerializeField] AudioSource s9k3n;

    List<string> lineList;
    int index;


    public TextMeshProUGUI textComponent;


    private DidTheThing FollowOrderBool;

    void Start()
    {
        followedOrders = false;
        step = 0;
        karma = 0;
        lineList = new List<string>();


        FollowOrderBool = GameObject.FindGameObjectWithTag("Player").GetComponent<DidTheThing>();

    }
    private void Update()
    {

        FollowOrderBool.followOrder = followedOrders;

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
        if (step == 0) //go right
        {
            if (karmaLevel == 0)
            {
                lineAudioRef=slave;
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
                lineAudioRef = nuke;
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (step == 1) //go left
        {
            if (karmaLevel == 0)
            {
                lineAudioRef = slave;
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    lineAudioRef = s1k1y;
                    return "Good! Now go to the left!";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s1k1n;
                    return "You seem to have misunderstood. I said right, not left. Maybe you missheard me! This time go left!";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    lineAudioRef = s1k2y;
                    return "That's it! Seems we can work together on this. Now go left";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s1k2n;
                    return "That's not what I said. Let's try again! Go left!";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    lineAudioRef = s1k3y;
                    return "Even you can follow orders. Maybe I missjudged you! Head over to the left area!";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s1k3n;
                    return "I knew you were dislikable but to think you can't even follow basic instructions! Go left, that's the opposite of right!";
                }
            }
            if (karmaLevel == 4)
            {
                lineAudioRef = nuke;
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (step == 2) //go left
        {
            if (karmaLevel == 0)
            {
                lineAudioRef = slave;
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    lineAudioRef = s2k1y;
                    return "You're good at following instructions. I might just be able to use you in the future! Head left this time.";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s2k1n;
                    return "Why didn't you follow instructions? You're still doing okay but listen to my instructions! Go left.";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    lineAudioRef = s2k2y;
                    return "Now we're getting somewhere! Head over to the left and we can continue on our way.";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s2k2n;
                    return "Listen, we won't be able to have a cooperative relationship if you don't listen to me. Move to the left ";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    lineAudioRef = s2k3y;
                    return "Finally decided to use follow orders? Why now? Are you capable of doing it twice in a row? Try it: Move to the left side!";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s2k3n;
                    return "Listen here you rat. When I tell you to do something you ought to do it. Or is your species incapable of cooperation? Go left this time, LEFT!";
                }
            }
            if (karmaLevel == 4)
            {
                lineAudioRef = nuke;
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (step == 3) //go right
        {
            if (karmaLevel == 0)
            {
                lineAudioRef = slave;
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    lineAudioRef = s3k1y;
                    return "halla fucking lulu you did it";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s3k1n;
                    return "word";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    lineAudioRef = s3k2y;
                    return "alphabetical";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s3k2n;
                    return "fuck";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    lineAudioRef = s3k3y;
                    return "good thing, you went the right way";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s3k3n;
                    return "I SAID GO RIGHT!!";
                }
            }
            if (karmaLevel == 4) 
            {
                lineAudioRef = nuke;
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (step == 4)// go right
        {
            if (karmaLevel == 0)
            {
                lineAudioRef = slave;
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    lineAudioRef = s4k1y;
                    return "words are hard";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s4k1n;
                    return "i want to stab something";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    lineAudioRef = s4k2y;
                    return "fasten belt";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s4k2n;
                    return "meep";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    lineAudioRef = s4k3y;
                    return "ahhhhh";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s4k3n;
                    return "yayyyyy";
                }
            }
            if (karmaLevel == 4)
            {
                lineAudioRef = nuke;
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (step == 5)//go left
        {
            if (karmaLevel == 0)
            {
                lineAudioRef = slave;
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    lineAudioRef = s5k1y;
                    return "fuka wakka";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s5k1n;
                    return "meep times two";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    lineAudioRef = s5k2y;
                    return "i dont like you";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s5k2n;
                    return "i really dont like you";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    lineAudioRef = s5k3y;
                    return "kiss my ass";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s5k3n;
                    return "american fuck head";
                }
            }
            if (karmaLevel == 4)
            {
                lineAudioRef = nuke;
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (step == 6)//go right
        {
            if (karmaLevel == 0)
            {
                lineAudioRef = slave;
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    lineAudioRef = s6k1y;
                    return "step 6 right";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s6k1n;
                    return "step 6 left";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    lineAudioRef = s6k2y;
                    return "cunte";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s6k2n;
                    return "cunt";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    lineAudioRef = s6k3y;
                    return "sug me";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s6k3n;
                    return "sug mape";
                }
            }
            if (karmaLevel == 4)
            {
                lineAudioRef = nuke;
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (step == 7)//go left
        {
            if (karmaLevel == 0)
            {
                lineAudioRef = slave;
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    lineAudioRef = s7k1y;
                    return "help meeeeeeee aaaaaaa";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s7k1n;
                    return "you fucka wacka";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    lineAudioRef = s7k2y;
                    return "alla facka wacka";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s7k2n;
                    return "hallsay facker";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    lineAudioRef = s7k3y;
                    return "sup man";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s7k3n;
                    return "nah man";
                }
            }
            if (karmaLevel == 4)
            {
                lineAudioRef = nuke;
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (step == 8)//go left
        {
            if (karmaLevel == 0)
            {
                lineAudioRef = slave;
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    lineAudioRef = s8k1y;
                    return "haspenheimer";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s8k1n;
                    return "slopenhaimer";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    lineAudioRef = s8k2y;
                    return "yapenhaimer";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s8k2n;
                    return "fellatio of the cyclon downpore";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    lineAudioRef = s8k3y;
                    return "eyan";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s8k3n;
                    return "niro";
                }
            }
            if (karmaLevel == 4)
            {
                lineAudioRef = nuke;
                return "That's it you little shit!  You want to oppose us so bad? Oppose this!";
            }
            else
            {
                return "welp something is fuckywucky";
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (step == 9)//go right
        {
            if (karmaLevel == 0)
            {
                lineAudioRef = slave;
                return "get slave tradded. You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    lineAudioRef = s9k1y;
                    return "facker betterDM";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s9k1n;
                    return "dungeon daddy";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    lineAudioRef = s9k2y;
                    return "dungeon master";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s9k2n;
                    return "D&D&DD&D&";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    lineAudioRef = s9k3y;
                    return "surprise butt sex";
                }
                if (!followedOrders)
                {
                    lineAudioRef = s9k3n;
                    return "alphabet surpres but sex";
                }
            }
            if (karmaLevel == 4)
            {
                lineAudioRef = nuke;
                return "get nuked funny man. You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
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
