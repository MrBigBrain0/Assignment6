using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions 
{

	public class BitAT : ActionTask 
	{
		//black board varribles that are for the player, the hunger value ofthe wolf and a timer for inbetween bitting
        public BBParameter<GameObject> player;
		public BBParameter<float> Hunger;
		public BBParameter<float> timer;

		//calls the scrit of player controller and ther values
		PlayerController controller;

        protected override string OnInit() 
		{
			//controller = GetComponent<PlayerController>();
			return null;
		}


		protected override void OnExecute() 
		{
			//this was part of me trying to fix the wolf bitting issue it did not work
			//controller.gotBit();	
		}


		protected override void OnUpdate() 
		{
			//debug line to see if on update is working
			Debug.Log("HI");

			//when the wolf gets hungy enough it will increase the timer value
            if (Hunger.value <= 10)
            {
                Debug.Log("ehfsgqfffbbbbbbbbb");
                timer.value += 1 * Time.deltaTime;

            }
			
			//this means that the wolf will walk away after 5 seconds
            if (timer.value >= 5)
			{
                Hunger.value = 20;
                EndAction(true);
			}


        }

		//Called when the task is disabled.
		protected override void OnStop() 
		{

        }

		//Called when the task is paused.
		protected override void OnPause() 
		{
            
        }
	}
}