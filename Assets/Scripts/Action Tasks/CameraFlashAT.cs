using NodeCanvas.Framework;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class CameraFlashAT : ActionTask 
	{

		public BBParameter<GameObject> flashSprite;

		public SpriteRenderer spriteRenderer;

		private Color currentColor = Color.white;

		protected override void OnExecute() 
		{
			spriteRenderer = flashSprite.value.GetComponent<SpriteRenderer>();
			spriteRenderer.color = new Color(255, 255, 255, 255);
			currentColor = Color.white;
		}

		protected override void OnUpdate() 
		{
			currentColor = new Color(255, 255, 255, currentColor.a - 0.001f);
			spriteRenderer.color = currentColor;

			if (currentColor.a <= 0.01f)
			{
				EndAction(true);
			}
		}
	}
}