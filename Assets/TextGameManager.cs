using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, healthTextMeshPro, staminaTextMeshPro;
    public string storyText = "Erwin felt the gentle sway of his ship as slowly awoke from his sleep. He yawned, stretching his body and cracking his knuckles to get himself ready for the day. He looked into his mirror, fixing his blonde hair and admiring his own blue eyes. He applied a slime across his body meant to protect his skin from the sun all day. He put on his two piece purple and gold swimsuit and had straps fastening the top half to the bottom half. This was to avoid his shorts coming off if dove into the water. Erwin did some final checks around the ship, making sure it was secured to the dock before he grabbed his speargun and nets and headed into Meltem.";
    public int health_value = 10;
    public int stamina_value = 10;
    public GameObject Main_Menu, Levels, Level_1_Choices, Level_2_Choices, Level_3_Choices, Level_4_Choices, Level_5_Choices, Level_6_Choices, Level_7_Choices, Level_8_Choices, Level_9_Choices, Level_10_Choices, Level_11_Choices, Level_12_Choices, Level_13_Choices, Level_14_Choices, Level_15_Choices, Level_16_Choices, Endings, Ending_1, Ending_2, Ending_3, Ending_4;


    // Start is called before the first frame update
    void Start()
    {
        storyTextMeshPro.text = storyText;
        healthTextMeshPro.text = health_value.ToString();
        staminaTextMeshPro.text = stamina_value.ToString();

        Main_Menu.SetActive(true);
        Levels.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
        healthTextMeshPro.text = health_value.ToString();
        staminaTextMeshPro.text = stamina_value.ToString();
    }

    // Main Menu Commands
    public void Page1()
    {
        storyText = "Erwin felt the gentle sway of his ship as slowly awoke from his sleep. He yawned, stretching his body and cracking his knuckles to get himself ready for the day. He looked into his mirror, fixing his blonde hair and admiring his own blue eyes. He applied a slime across his body meant to protect his skin from the sun all day. He put on his two piece purple and gold swimsuit and had straps fastening the top half to the bottom half. This was to avoid his shorts coming off if dove into the water. Erwin did some final checks around the ship, making sure it was secured to the dock before he grabbed his speargun and nets and headed into Meltem.";
        Main_Menu.SetActive(false);
        Levels.SetActive(true);
        Level_1_Choices.SetActive(true);
        Level_2_Choices.SetActive(false);
        Level_3_Choices.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }


    // Level 1 Commands


    public void MainMenu()
    {
        Main_Menu.SetActive(true);
        Endings.SetActive(false);
        Levels.SetActive(false);
    }

    public void Page2()
    {
        storyText = "Erwin strolled towards the market, peeking at the stalls, looking at the different items. He wanted some of them but they seemed like a luxury. “Morning, Erwin.Where you headed today?” A lady greeted as Erwin approached. “Wherever Breeze takes me, Seraph. What’s the most in demand today? I want to see what I can do. I kinda want a new challenge.” “Already rearing for a new challenge, eh ? It’s only been a few weeks since you started.” She remarked, “As usual, the rarer and larger the catch, the higher the pay.I hear there’s a pod of sharkwhales in the west but might be too much to handle without a teams.” “If it was just one, maybe, but do you have something else? What about the trading routes, anything they want? I kinda miss mangoes but they’re too expensive right now.” Seraph pulled out two lists, 'You might be interested in one of these.'";

        Level_1_Choices.SetActive(false);
        Level_2_Choices.SetActive(true);
        Level_3_Choices.SetActive(false);
        Level_4_Choices.SetActive(false);
        Level_5_Choices.SetActive(false);
        Level_6_Choices.SetActive(false);
        Level_7_Choices.SetActive(false);
        Level_8_Choices.SetActive(false);
        Level_9_Choices.SetActive(false);
        Level_10_Choices.SetActive(false);
        Level_11_Choices.SetActive(false);
        Level_12_Choices.SetActive(false);
        Level_13_Choices.SetActive(false);
        Level_14_Choices.SetActive(false);
        Level_15_Choices.SetActive(false);
        Level_16_Choices.SetActive(false);
    }

    public void Page3()
    {
        storyText = "Erwin took the two lists and browsed through them. One of them was for Shipping job for goods to trade with the neraby archipelago villages. Another was for a Fishing job for specific species down South. Both jobs had low risk of sharkwhales. Which should Erwin pick?";

        Level_1_Choices.SetActive(false);
        Level_2_Choices.SetActive(false);
        Level_3_Choices.SetActive(true);
        Level_4_Choices.SetActive(false);
        Level_5_Choices.SetActive(false);
        Level_6_Choices.SetActive(false);
        Level_7_Choices.SetActive(false);
        Level_8_Choices.SetActive(false);
        Level_9_Choices.SetActive(false);
        Level_10_Choices.SetActive(false);
        Level_11_Choices.SetActive(false);
        Level_12_Choices.SetActive(false);
        Level_13_Choices.SetActive(false);
        Level_14_Choices.SetActive(false);
        Level_15_Choices.SetActive(false);
        Level_16_Choices.SetActive(false);
    }

    public void Page18()
    {
        storyText = "Erwin followed the directions provided, making sure to be careful to not damage the goods he was transporting. It didn't take him long to find the archipelago. He sailed in close to confirm that village on one of the islands was Mogotsi. As he was getting reading to dock his boat, Eru saw the numerous coconut trees that lined the shore, wondering if he could get some as he hadn't had fruit in a while. But he shook his head, he was there for work purposes. Once the job was done, he could get buy some, for now he had to focus on his task.";

        Level_1_Choices.SetActive(false);
        Level_2_Choices.SetActive(false);
        Level_3_Choices.SetActive(false);
        Level_4_Choices.SetActive(true);
        Level_5_Choices.SetActive(false);
        Level_6_Choices.SetActive(false);
        Level_7_Choices.SetActive(false);
        Level_8_Choices.SetActive(false);
        Level_9_Choices.SetActive(false);
        Level_10_Choices.SetActive(false);
        Level_11_Choices.SetActive(false);
        Level_12_Choices.SetActive(false);
        Level_13_Choices.SetActive(false);
        Level_14_Choices.SetActive(false);
        Level_15_Choices.SetActive(false);
        Level_16_Choices.SetActive(false);
    }

    public void Page19()
    {
        storyText = "It didn't take long for Erwin to find the buyer, a farmer named Eru. Eru happened to be waiting at the docks for Erwin.\r\n\r\n\"Oh you're here!\" Eru greeted.\r\n\r\n\"I've got a delivery for someone named Eru, is that you?\"\r\n\r\n\"Sure is. Lucky you caught me on time. I was about ready to sail out to look for Meltem to trade.\"\r\n\r\nErwin looked over at Eru's boat. It didn't seem to seaworthy and its coxswain looked rather inexperienced to sail and find Meltem.\r\n\r\n\"You weren't planning to go to Meltem, were you?\"\r\n\r\n\"I was, actually. But it would have been a terrible plan to be honest. I don't even know how to swim. But I need to trade my produce for money or I won't make it to next season, hence my desperation.\"\r\n\r\nEru and Erwin proceeded with the trade. ";

        Level_1_Choices.SetActive(false);
        Level_2_Choices.SetActive(false);
        Level_3_Choices.SetActive(false);
        Level_4_Choices.SetActive(false);
        Level_5_Choices.SetActive(true);
        Level_6_Choices.SetActive(false);
        Level_7_Choices.SetActive(false);
        Level_8_Choices.SetActive(false);
        Level_9_Choices.SetActive(false);
        Level_10_Choices.SetActive(false);
        Level_11_Choices.SetActive(false);
        Level_12_Choices.SetActive(false);
        Level_13_Choices.SetActive(false);
        Level_14_Choices.SetActive(false);
        Level_15_Choices.SetActive(false);
        Level_16_Choices.SetActive(false);
    }

    public void Page20()
    {
        storyText = "Eru noticed Erwin eyeing some of the coconuts. Eru bought two fresh coconuts that were pulled out of cool icy water. He cut them open and handed one of them to Erwin. \r\n\r\n\"Here, why not rest for a bit before going home.\"\r\n\r\n\"Thanks.\" Erwin took the coconut and happly sipped the cool and refereshing water.\r\n\r\n\"Will you be trading here often?\" Eru asked.\r\n\r\n\"I'm not sure. Maybe... I forgot how much I missed fruits. They're kinda pricery back at home. Also shouldn't I pay for this?\"\r\n\r\n\"It's on me, don't worry. Although the next time you come back for a job, come give me a visit, we could do this again.\"\r\n\r\n\"I'd like that.\" Erwin smiled.";

        Level_1_Choices.SetActive(false);
        Level_2_Choices.SetActive(false);
        Level_3_Choices.SetActive(false);
        Level_4_Choices.SetActive(false);
        Level_5_Choices.SetActive(false);
        Level_6_Choices.SetActive(true);
        Level_7_Choices.SetActive(false);
        Level_8_Choices.SetActive(false);
        Level_9_Choices.SetActive(false);
        Level_10_Choices.SetActive(false);
        Level_11_Choices.SetActive(false);
        Level_12_Choices.SetActive(false);
        Level_13_Choices.SetActive(false);
        Level_14_Choices.SetActive(false);
        Level_15_Choices.SetActive(false);
        Level_16_Choices.SetActive(false);
    }

    public void Ending1()
    {
        storyText = "Ending 1\r\n\r\nErwin goes home after he made a new friend.";

        Ending1.SetActive(true);

        Level_1_Choices.SetActive(false);
        Level_2_Choices.SetActive(false);
        Level_3_Choices.SetActive(false);
        Level_4_Choices.SetActive(false);
        Level_5_Choices.SetActive(false);
        Level_6_Choices.SetActive(false);
        Level_7_Choices.SetActive(false);
        Level_8_Choices.SetActive(false);
        Level_9_Choices.SetActive(false);
        Level_10_Choices.SetActive(false);
        Level_11_Choices.SetActive(false);
        Level_12_Choices.SetActive(false);
        Level_13_Choices.SetActive(false);
        Level_14_Choices.SetActive(false);
        Level_15_Choices.SetActive(false);
        Level_16_Choices.SetActive(false);

    }
}

