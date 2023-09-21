using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameData

{
    public static string[] descriptions = {
           //0
            "You wake up in a room. It’s bright and sunny, thanks to a skylight in the ceiling. " +
            "You look around the room and notice you’re not on a bed, or on any floor whatsoever, you’re actually just floating…now what? " +
            "Looking around the room you notice a few new things, " +
            "1: the peerless void beneath, " +
            "2: where you can rotate your body at free will, " +
            "3: and the door ahead. Also to note, where is anyone?" +
            " Is there anyone…even…there? Has it…been a while?" +
            "...what now...?" ,
            //1
            "You look up. " +
            "<i>OW.</i> " +
            "Your eyes hurt from looking at the light directly…your eyes eventually adjust to it. " +
            "It seems you can almost reach the light if you tried as hard as possible…should you? ",  
             //2
            "You reached for the light, arm outstretched as far as you could, the radiance feels warm, and you reach even harder. " +
            "You grasp it in your hand. You wake up, it’s a sunny day. " +
            "The light from your window hurts your eyes, " +
            "but you adjust to it…it’s a nice day out…you fall back on your bed," +
            " heart calm, ready to enjoy the day in itself once again.\r\n",

        };
    public static string[] endingdescriptions = {
            //0
            "You reach for the door, but then you remember you can rotate but…has do you have the ability to move around…? " +
            "You prime yourself! You get in a motion that resembles a jump! " +
            "Legs bend, calves ready to boost! In the attempt of a crouching position despite not having any flooring! " +
            "You explode all your energy off, legs stretch in a motion meant to boost! Graceful! Stylish! Fancy! " +
            "And…It…It was…anticlimactic. " +
            "Nothing happens, and sudden tiredness ensues…” I’ll check later…” you think to yourself…and the light fades. " +
            "Quickly. " +
            "Too quick in fact. " +
            "As it falls far and farther from reach, you feel tired, too tired. " +
            "You surrender yourself to a feeling and shut your eyes, and…fall-\r\n",
            //1
            "Your body loosened up, during a familiar dream, " +
            "a feeling oddly alien," +
            " despite there being too many times to count. " +
            "You look and gaze up to the light, blinding, but now, the bland room and depths below, " +
            "now seemingly seem brighter and pleasant than it once was before. " +
            "To inhale was the last thing that was thought...You wake up," +
            " the window was left open again," +
            " and it’s a sunny day, The sunlight from your window hurts your eyes, " +
            "but you adjust to it<i>\"…it’s a nice day out…\"</i>you look around, eyes dreary," +
            " limbs weak and notice mom has left for work already, you fall back on your bed," +
            " It seems calm, a feeling of a bliss laziness, with melty feeling. Headphones - equipped," +
            " music play. Then a thought \"remember breaks are always needed. Even if it seems unnecessary.\"",
           
          
            //2
            "A lazy hand reaches forward, then drops. " +
            "The light fades. " +
            "Quickly." +
            " Too quick in fact. " +
            "As it falls far and farther from reach, " +
            "you feel tired, too tired. " +
            "You surrender yourself to a feeling and shut your eyes, and…fall-\r\n"
    };
    public static string[,] endings/*button*/ = 
    {
        { "Leave.", "Return.", "Again." },
        { "Leave.", "Return.", "Again." },
        { "Leave.", "Return.", "Again." }


    };
  
    public static string[,] options =
        {
            //0  
            { "Reach for \"it.\"", "<b><i>JUMP!</i></b>","Nothing." },
            //1    
            {"Keep Reaching","...or...","Stop." },
            //2
           { "Leave.", "Return.", "Again." }
        };

}
