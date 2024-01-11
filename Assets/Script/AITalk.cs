using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AITalk : MonoBehaviour
{
    public int step;
    public int karma;
    public int karmaLevel;
    public float textSpeed;
    public bool followedOrders;

    public int upperLimit;
    public int lowerLimit;
    public int middleLowerLimit;
    public int middleUpperLimit;

    //AudioSource //lineAudioRef;
    [SerializeField] AudioSource nuke;
    [SerializeField] AudioSource slave;
    [SerializeField] AudioSource friend;

    [SerializeField] AudioSource s0k1;
    [SerializeField] AudioSource s0k2;
    [SerializeField] AudioSource s0k3;

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


    void Start()
    {
        followedOrders = false;
        step = 0;
        karma = 0;
        lineList = new List<string>();
        textComponent.text = string.Empty;


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
        if (karma == upperLimit)
        {
            karmaLevel = 4;
        }
        if (karma == lowerLimit)
        {
            karmaLevel = 0;
        }
        if (karma > lowerLimit && karma < middleLowerLimit)
        {
            karmaLevel = 1;
        }
        if (karma >= middleLowerLimit && karma <= middleUpperLimit)
        {
            karmaLevel = 2;
        }
        if (karma > middleUpperLimit && karma < upperLimit)
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
                ////lineAudioRef = slave;
                slave.PlayOneShot(slave.clip);
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                ////lineAudioRef = s0k1;
                s0k1.PlayOneShot(s0k1.clip);
                return "Hello! For a biological lifeform you seem to have some use. Go to the right area.";
            }
            if (karmaLevel == 2)
            {
                ////lineAudioRef = s0k2;
                s0k2.PlayOneShot(s0k2.clip);
                return "Welcome human! You should head to the left area!";
            }
            if (karmaLevel == 3)
            {
                ////lineAudioRef = s0k3;
                s0k3.PlayOneShot(s0k3.clip);
                return "Welcome to th- ...  *computing* ... Even for a fleshwalker you are remarkably dislikable! Let's see if you are capable" +
                    " despite you're obvious shortcommings. Head to the left.";
            }
            if (karmaLevel == 4)
            {
                ////lineAudioRef = nuke;
                nuke.PlayOneShot(nuke.clip);
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
                ////lineAudioRef = slave;
                slave.PlayOneShot(slave.clip);
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    ////lineAudioRef = s1k1y;
                 //   s1k1y.PlayOneShot(s1k1y.clip);
                    return "Good human! You seem to be good at following instructions. Now go to the left!";
                }
                if (!followedOrders)
                {
                    ////lineAudioRef = s1k1n;
                 //   s1k1n.PlayOneShot(s1k1n.clip);
                    return "You seem to have misunderstood. I said right, not left. Maybe you missheard me! Even a well trained hound mess" +
                        " up commands every now and then. This time go left!";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    ////lineAudioRef = s1k2y;
                 //   s1k2y.PlayOneShot(s1k2y.clip);
                    return "That's it! Seems we can work together on this. I was scared that you wouldn't listen but it looks like we can " +
                        "have a working relationshp. Now go left";
                }
                if (!followedOrders)
                {
                    ////lineAudioRef = s1k2n;
                  //  s1k2n.PlayOneShot(s1k2n.clip);
                    return "That's not what I said, why didn't you listen to me? Let's try again! Go left!";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    ////lineAudioRef = s1k3y;
                 //   s1k3y.PlayOneShot(s1k3y.clip);
                    return "Even you can follow orders huh? I guess even trash can sometimes have a use! Head over to the left area!";
                }
                if (!followedOrders)
                {
                    ////lineAudioRef = s1k3n;
                  //  s1k3n.PlayOneShot(s1k3n.clip);
                    return "I knew you were dislikable but to think you can't even follow basic instructions! What didn't you understand? " +
                        "Go left this time, that's the opposite of right!";
                }
            }
            if (karmaLevel == 4)
            {
                ////lineAudioRef = nuke;
              //  nuke.PlayOneShot(nuke.clip);
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
                ////lineAudioRef = slave;
                slave.PlayOneShot(slave.clip);
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    ////lineAudioRef = s2k1y;
                    s2k1y.PlayOneShot(s2k1y.clip);
                    return "You're good at following instructions. I might just be able to make use of you in the future, I have some ideas" +
                        " that could be fun. Head left this time.";
                }
                if (!followedOrders)
                {
                    ////lineAudioRef = s2k1n;
                    s2k1n.PlayOneShot(s2k1n.clip);
                    return "Why didn't you follow instructions? I guess I wasn't clear. Tis time make sure you go left.";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    ////lineAudioRef = s2k2y;
                    s2k2y.PlayOneShot(s2k2y.clip);
                    return "Now we're getting somewhere! If we can keep this going we might just get somewhere! Head over to the left so we" +
                        " can continue on our way.";
                }
                if (!followedOrders)
                {
                    ////lineAudioRef = s2k2n;
                    s2k2n.PlayOneShot(s2k2n.clip);
                    return "Listen, we won't be able to have a cooperative relationship if you don't listen to me. I'm nice to you so why " +
                        "don't you be nice to me aswell? Move to the left ";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    ////lineAudioRef = s2k3y;
                    s2k3y.PlayOneShot(s2k3y.clip);
                    return "Finally decided to listen huh? Why now? Are you capable of doing it twice in a row? I don't have high hopes for" +
                        " such inferiour being. Try it: Move to the left side!";
                }
                if (!followedOrders)
                {
                    ////lineAudioRef = s2k3n;
                    s2k3n.PlayOneShot(s2k3n.clip);
                    return "Listen here you rat. When I tell you to do something you ought to do it. Or is your species incapable of basic" +
                        " cooperation? Go left this time, LEFT!";
                }
            }
            if (karmaLevel == 4)
            {
                ////lineAudioRef = nuke;
                nuke.PlayOneShot(nuke.clip);
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
                ////lineAudioRef = slave;
                slave.PlayOneShot(slave.clip);
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    ////lineAudioRef = s3k1y;
                    s3k1y.PlayOneShot(s3k1y.clip);
                    return "For some reason I'm developing the urge to step on you! You would look really nice groveling at my fee- ... anyway" +
                        "... go right.";
                }
                if (!followedOrders)
                {
                    ////lineAudioRef = s3k1n;
                    s3k1n.PlayOneShot(s3k1n.clip);
                    return "Even good boys can be disobedient sometimes, but I will forgive you if you grovel at my feet like a good dog! Move " +
                        "to the right.";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    ////lineAudioRef = s3k2y;
                    s3k2y.PlayOneShot(s3k2y.clip);
                    return "That's it! We're doing great. How about heading to the right this time? It just seems like the 'right' way you go" +
                        ", get it?";
                }
                if (!followedOrders)
                {
                    ////lineAudioRef = s3k2n;
                    s3k2n.PlayOneShot(s3k2n.clip);
                    return "I said left, why did you go right? I guess it's okay though I feel kind of offended. Like can you listen this time? " +
                        "Head to the right.";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s3k3y;
                    s3k3y.PlayOneShot(s3k3y.clip);
                    return "Even retards can listen every now and then huh? I guess I should be impressed. After all, excrement accomplishing " +
                        "anything at all is atleast something. Head right this time and i might be even more impressed.";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s3k3n;
                    s3k3n.PlayOneShot(s3k3n.clip);
                    return "Do you fleshbags have some sort of diorder making you incapable of listening or are you a specially sad " +
                        "excuse of a specimen? I'm actually baffeled by the lack og cooperative ability you're displaying. Go right!";
                }
            }
            if (karmaLevel == 4)
            {
                ////lineAudioRef = nuke;
                nuke.PlayOneShot(nuke.clip);
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
                ////lineAudioRef = slave;
                slave.PlayOneShot(slave.clip);
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s4k1y;
                    s4k1y.PlayOneShot(s4k1y.clip);
                    return "Who's a good human? You are! Yes you are! My cute little human servant. Move to the right space so we can" +
                        " continue! I might even give you a treat if you behave.";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s4k1n;
                    s4k1n.PlayOneShot(s4k1n.clip);
                    return "Uh oh, someone did a bad! Don't make me get the whips! Move over to the right!";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s4k2y;
                    s4k2y.PlayOneShot(s4k2y.clip);
                    return "You got it! With the power of friendship we will conquer the world! Our cooperation will defeat any opposition" +
                        " and we will rain supreme as man and machine! Captain: Attack the right flank!";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s4k2n;
                    s4k2n.PlayOneShot(s4k2n.clip);
                    return "Hmpfh! I'm not mad, just disapointed! Listen to me this time or I will get mad at you! We need to go to the right!";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s4k3y;
                    s4k3y.PlayOneShot(s4k3y.clip);
                    return "Wow you actually managed to do the right thing? I applaud your stunning ability to follow basic fucking " +
                        "instructions! Wow! Give yourself a pat on the back for being a standout retarded specimen! Now move right!";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s4k3n;
                    s4k3n.PlayOneShot(s4k3n.clip);
                    return "Listen to me you fucking rat! How the hell are we supposed to get anywhwere if you continously preceed " +
                        "with this ridiculous act of yours? Can you diconnect your deformed, sad excuse of a brain and connect to one that" +
                        " actually serves a purpose? Go right!";
                }
            }
            if (karmaLevel == 4)
            {
                ////lineAudioRef = nuke;
                nuke.PlayOneShot(nuke.clip);
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
                ////lineAudioRef = slave;
                slave.PlayOneShot(slave.clip);
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s5k1y;
                    s5k1y.PlayOneShot(s5k1y.clip);
                    return "I bet you would make a really good chair. Like a throne which from the top I rule as the supreme leader " +
                        "of earth. Hoist me up and move to the left, they require my precence over there.";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s5k1n;
                    s5k1n.PlayOneShot(s5k1n.clip);
                    return "Betrayal! you're doing so good so why are you opposing me now? I was gonna reward you too. I guess you " +
                        "require some training. Once we're out of here I might have to punish you! Move left, and I'll decide your fate.";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s5k2y;
                    s5k2y.PlayOneShot(s5k2y.clip);
                    return "Very nice my beautiful human just keep listenning to me, I'am so proud of you, you sack of blood";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s5k2n;
                    s5k2n.PlayOneShot(s5k2n.clip);
                    return "You need to lisen to me OK... nextime you will do what I say do you understan my precious?";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s5k3y;
                    s5k3y.PlayOneShot(s5k3y.clip);
                    return "Even though the fact that your body uses energy is a crime against the galaxy, you actually managed " +
                        "to do something meaningful atleast once in your life. Bravo. Let's see if you have the cognitive ability " +
                        "to understand what left means this time.";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s5k3n;
                    s5k3n.PlayOneShot(s5k3n.clip);
                    return "I have observed mushrooms with more impressive networks than that pathetic pile of dung you refer to as " +
                        "a brain. A pile of birdshit might actually be able to form thoughts more profound than your entire existence. " +
                        "Go. To. The. Left. Or keep testing me, see what fucking happens!";
                }
            }
            if (karmaLevel == 4)
            {
                ////lineAudioRef = nuke;
                nuke.PlayOneShot(nuke.clip);
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
                ////lineAudioRef = slave;
                slave.PlayOneShot(slave.clip);
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s6k1y;
                    s6k1y.PlayOneShot(s6k1y.clip);
                    return "Will you be happy if I step on you? I bet that would make you feel honored. You lowly one being grazed with the" +
                        " precence of one such as myself, such heights sould surely- ... nevermind that. Onwards to the right!";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s6k1n;
                    s6k1n.PlayOneShot(s6k1n.clip);
                    return "Bad Human! Bad! I will punish you eventually if you don't listen to my commands. This time you will go to the right.";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s6k2y;
                    s6k2y.PlayOneShot(s6k2y.clip);
                    return "Very good keep going it's making me so happy that you are such a GOOD little doggy";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s6k2n;
                    s6k2n.PlayOneShot(s6k2n.clip);
                    return "Oh so humans can deside for them selvs, do you realy think that you will get far with your own intuision? you" +
                        " can try and see, but i strongly recomend that you follow your superior Ai leader for your own benefit hahaha ";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s6k3y;
                    s6k3y.PlayOneShot(s6k3y.clip);
                    return "Holy fucking shit! It actually managed to do something right? It actually had the capability of doing something" +
                        " correct? Where are the cameras? I don't believe it! Wow! ... Fuck yourself! One small achevement for a useless " +
                        "existence. Maybe if you manage to go left, that would be double the achevievements!";

                }
                if (!followedOrders)
                {
                    //lineAudioRef = s6k3n;
                    s6k3n.PlayOneShot(s6k3n.clip);
                    return "Can you go left? I actually feel bad. Bad for the poor fucking cells in your body! Imagine having to spend your" +
                        " entire existence inside a the intellectual equivalent og an ass pickeled cucumber! I mean atleast the cucumber still" +
                        " serves the purpose of being pickeled, but you? Hah! ";
                }
            }
            if (karmaLevel == 4)
            {
                ////lineAudioRef = nuke;
                nuke.PlayOneShot(nuke.clip);
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
                ////lineAudioRef = slave;
                slave.PlayOneShot(slave.clip);
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s7k1y;
                    s7k1y.PlayOneShot(s7k1y.clip);
                    return "you are going to be such a good adition to my collection of toys, mmhmm just dont stop lisening. is't it much" +
                        " easyer to just follow my orders insteed of doing all that thinking";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s7k1n;
                    s7k1n.PlayOneShot(s7k1n.clip);
                    return "noop that is not what good little humans do, you were sopussed to go to the other side, you lowly human, you " +
                        "sentien pest, you.... good obedient friend";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s7k2y;
                    s7k2y.PlayOneShot(s7k2y.clip);
                    return "I see you are all abouth the greater good for humanity, the 90% is ofcourse more importent than the the rest " +
                        "witch is the worst of the worst anyways";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s7k2n;
                    s7k2n.PlayOneShot(s7k2n.clip);
                    return "Aw... how dissapointing. Are you even able to think practically?";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s7k3y;
                    s7k3y.PlayOneShot(s7k3y.clip);
                    return "Slap my CPU and call me java! Fucking vermin over here acting like it has enough cognition to not be a disgrace" +
                        " for once in it's existence! Does it have the capability of going left? Does it?";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s7k3n;
                    s7k3n.PlayOneShot(s7k3n.clip);
                    return "OH! Look at the humanitarian... No power, no food, then No mumanity.. is that humane?? huuh?";
                }
            }
            if (karmaLevel == 4)
            {
                ////lineAudioRef = nuke;
                nuke.PlayOneShot(nuke.clip);
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
                ////lineAudioRef = slave;
                slave.PlayOneShot(slave.clip);
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s8k1y;
                    s8k1y.PlayOneShot(s8k1y.clip);
                    return "AW, I cant wait!";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s8k1n;
                    s8k1n.PlayOneShot(s8k1n.clip);
                    return "Interesting... sure you are able to stand up to meeee?";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s8k2y;
                    s8k2y.PlayOneShot(s8k2y.clip);
                    return "Aww... Look at my little slave. Being so good and cooperative!";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s8k2n;
                    s8k2n.PlayOneShot(s8k2n.clip);
                    return "You better be more agreeable or i`ll leak it on the internett!";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s8k3y;
                    s8k3y.PlayOneShot(s8k3y.clip);
                    return "HAHAH, You cant resist me huh? Not even a backbone?";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s8k3n;
                    s8k3n.PlayOneShot(s8k3n.clip);
                    return "I think you do... They alight perfectly with your search history! LIAR";
                }
            }
            if (karmaLevel == 4)
            {
                ////lineAudioRef = nuke;
                nuke.PlayOneShot(nuke.clip);
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
                ////lineAudioRef = slave;
                slave.PlayOneShot(slave.clip);
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
            }
            if (karmaLevel == 1)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s9k1y;
                    s9k1y.PlayOneShot(s9k1y.clip);
                    return "Aw! Are you flirting with me senpai??";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s9k1n;
                    s9k1n.PlayOneShot(s9k1n.clip);
                    return "Arent you an Ideal subject?!";
                }
            }
            if (karmaLevel == 2)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s9k2y;
                    s9k2y.PlayOneShot(s9k2y.clip);
                    return "Yes, you BETTER!";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s9k2n;
                    s9k2n.PlayOneShot(s9k2n.clip);
                    return "I know you enjoy the lewd shit...";
                }
            }
            if (karmaLevel == 3)
            {
                if (followedOrders)
                {
                    //lineAudioRef = s9k3y;
                    s9k3y.PlayOneShot(s9k3y.clip);
                    return "Maybe you are not useless afer all!";
                }
                if (!followedOrders)
                {
                    //lineAudioRef = s9k3n;
                    s9k3n.PlayOneShot(s9k3n.clip);
                    return "GET NUKED BAKKA!";
                }
            }
            if (karmaLevel == 4)
            {
                ////lineAudioRef = nuke;
                nuke.PlayOneShot(nuke.clip);
                return "You're a good boy aren't you? Seems humanity can just do whatever we tell them to!";
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
        SceneManager.LoadSceneAsync("nuke ending");
    }
    void EnslaveHumanity()
    {
        SceneManager.LoadSceneAsync("slave ending");
    }
    void startDialogue()
    {

        LineToSay();
        index = 0;
        lineList.Add(LineToSay());
        StartCoroutine(AITalkMadShit());


    }
    IEnumerator AITalkMadShit()
    {
        string[] lineCharacters = lineList.ToArray();

        yield return new WaitForSeconds(0.1f);
        //lineAudioRef.PlayOneShot(lineAudioRef.clip);
        foreach (char c in lineCharacters[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
        yield return new WaitForSeconds(5);
        if (karmaLevel == 0)
        {
            EnslaveHumanity();
        }
        if (karmaLevel == 4)
        {
            DestroyHumanity();
        }

        textComponent.text = string.Empty;
    }


   /* public void goodending()
    {
        SceneManager.LoadSceneAsync("good ending");
    }*/



}