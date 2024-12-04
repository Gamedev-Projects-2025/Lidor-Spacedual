using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
[RequireComponent(typeof(TextMeshPro))]
public class NumberField : MonoBehaviour {
    [SerializeField][Tooltip("Name of scene to move to when triggering the given tag")] string sceneName;
    [SerializeField] int hitPoints = 3;
    private int number;

    public int GetNumber() { 
        return this.number;
    }

    public void SetNumber(int newNumber) {
        this.number = newNumber;
        GetComponent<TextMeshPro>().text = newNumber.ToString();
        if (this.number >= hitPoints)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void AddNumber(int toAdd) {
        SetNumber(this.number + toAdd);
        
    }
}
