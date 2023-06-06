using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, healthTextMeshPro, staminaTextMeshPro;
    public string storyText = "Erwin, you, have awoken on a strange land. You're recollection of how you ended up here in this situation is fuzzy. You seem to be on the shore of a beach.  There is debris everywhere in the sand. As you observe your surroundigs, a broken sail reminds you of someone. Your partner Eru... Where is he? You notice there are a few places to look, some rock formations, somwhere in the tree line or perhaps floating somewhere in the water... Where do you go?";
    public int health_value = 10;
    public int stamina_value = 10;
    public GameObject Main_Menu, Levels, Level_1_Choices, Level_2_Choices;

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
    public void Begin()
    {
        Main_Menu.SetActive(false);
        Levels.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }


    // Level 1 Commands
    public void Rocks()
    {
        storyText = "You check the rocks. Luckily, there is no sign of him there. The rocks and waves would've turn him to shreds. You cut your hand on a rock too. You got a little tired from searching.";
        health_value -= 1;
        stamina_value-= 1;
    }

    public void Trees()
    {
        storyText = "You check the trees. There is no sign of him there but you got tired from climbing trees.";
        stamina_value -= 1;
    }

    public void Water()
    {
        storyText = "You check the water, using your stamina as you swam. You see something pink floating. It's Eru! You quickly get him to shore but he's not responsive.";
        stamina_value -= 1;
        
        Level_1_Choices.SetActive(false);
        Level_2_Choices.SetActive(true);
    }
}


