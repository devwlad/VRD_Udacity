using UnityEngine;
using System.Collections;

/// <summary>
/// The TriggerAnimation class activates a transition whenever the Cardboard button is pressed (or the screen touched).
/// </summary>
public class TriggerAnimation : MonoBehaviour
{
	[Tooltip ("The Animator component on this gameobject")]
	public Animator animator;
	[Tooltip ("The name of the Animator trigger parameter")]
	public string triggerName;
	public bool click = false;

	void Update ()
	{
		// If the player pressed the cardboard button (or touched the screen), set the trigger parameter to active (until it has been used in a transition)
		if (Input.GetMouseButtonDown (0)) {
			animator.SetTrigger (triggerName);
			click = !click;

			if(click == true){
				animator.speed = 1;
			}
			else{
				animator.speed = 0;
			}
		}
	}
}
