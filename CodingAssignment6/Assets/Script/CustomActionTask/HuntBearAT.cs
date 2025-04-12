using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions 
{

	public class HuntBearAT : ActionTask
	{
		//gae objects for player and hunter posistions
		public BBParameter <GameObject> player;
		public BBParameter <GameObject> hunter;
		protected override string OnInit() 
		{
			return null;
		}

		protected override void OnExecute() 
		{
			
		}

		protected override void OnUpdate() 
		{
			//resets the player and hunter postion back to where they started at the begining of the game
			player.value.transform.position = new Vector3(-0.3002234f, 1.22f, -23.92f);
			hunter.value.transform.position = new Vector3(20.14f, 0.44f, 4.61f);

        }


		protected override void OnStop() 
		{
			
		}


		protected override void OnPause() 
		{
			
		}
	}
}