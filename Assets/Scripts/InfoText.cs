using UnityEngine;
using UnityEngine.UI;

public class InfoText : MonoBehaviour
{
	public int _id;
	Text _infoText;

	private void Start()
	{
		_infoText = GetComponent<Text>();
	}
	private void Update()
	{
		SetInfo(_id);
	}  
	public void SetInfo(int id)
	{
		if (id == 1)
		{
			_infoText.text = "X";
		}
		else
		{
			_infoText.text = "O";
		}
	}
	public string GetInfo()
	{
		return _infoText.text;
	}
}
