using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public const int gridRows = 3;
    public const int gridCols = 4;
    public const float offsetX = 3.5f;
    public const float offsetY = 3.5f;
	
	public int primeInt = 0;
	public GameObject dialogueBox;
    public Text dialogueText;
	public bool allowSpace = false;
	public string ReturnLevel = "Level3Scene4";

    [SerializeField] private MainCard originalCard;
    [SerializeField] private Sprite[] images;

    private void Start()
    {
		allowSpace = false;
		dialogueBox.SetActive(false);
		dialogueText.gameObject.SetActive(false);
		
        Vector3 startPos = originalCard.transform.position;

        int[] numbers = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
        numbers = ShuffleArray(numbers);

        for (int i = 0; i < gridCols; i++)
        {
            for (int j = 0; j < gridRows; j++)
            {
                MainCard card;
                if (i == 0 && j == 0)
                {
                    card = originalCard;
                }
                else
                {
                    card = Instantiate(originalCard) as MainCard;
                }

                int index = j * gridCols + i;
                int id = numbers[index];
                card.ChangeSprite(id, images[id]);

                float posX = (offsetX * i) + startPos.x;
                float posY = (offsetY * j) + startPos.y;
                card.transform.position = new Vector3(posX, posY, startPos.z);
            }

        }
    }
	
	void Update()
	{
		if (Input.GetButtonDown("Enter")){
			SendBackToRoom();
        }
		
		if (Input.GetButtonDown("Talk") && allowSpace){
			NPCDialogue();
		}
		if (_score == 6){
			_score = 7;
			StartCoroutine(DialogueDelay());
		}
	}
	
    private int[] ShuffleArray(int[] numbers)
    {
        int[] newArray = numbers.Clone() as int[];
        for (int i = 0; i < newArray.Length; i++)
        {
            int tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }
    //-------------------------------------------------------------------------------

    private MainCard _firstRevealed;
    private MainCard _secondRevealed;

    private int _score = 0;
    [SerializeField] private TextMesh scoreLabel;

    public bool canReveal
    {
        get { return _secondRevealed == null; }
    }

    public void CardRevealed(MainCard card)
    {
        if (_firstRevealed == null)
        {
            _firstRevealed = card;
        }
        else
        {
            _secondRevealed = card;
            StartCoroutine(CheckMatch());
        }
    }

    private IEnumerator CheckMatch()
    {
        if(_firstRevealed.id == _secondRevealed.id)
        {
            _score++;
            scoreLabel.text = "Score: " + _score;

        }
        else
        {
            yield return new WaitForSeconds(0.5f);

            _firstRevealed.Unreveal();
            _secondRevealed.Unreveal();
        }

        _firstRevealed = null;
        _secondRevealed = null;
    }
	
	public void NPCDialogue(){
		primeInt += 1;
		
		if (primeInt == 1){
			dialogueText.text = "There's a piece of paper at the bottom of the bottle.";
		}
		if (primeInt == 2){
			dialogueText.text = "It's a note.";
		}
		if (primeInt == 3){
			dialogueText.text = "DOOR CODE: F3X7F8";
		}
		if (primeInt == 4){
			allowSpace = false;
			dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			SendBackToRoom();
		}
	}
	
    public IEnumerator DialogueDelay()
    {
        yield return new WaitForSeconds(0.3F);
		allowSpace = true;
		dialogueBox.SetActive(true);
		dialogueText.gameObject.SetActive(true);
		NPCDialogue();
    }
	
	public void SendBackToRoom(){
		SceneManager.LoadScene (ReturnLevel);
	}
}

