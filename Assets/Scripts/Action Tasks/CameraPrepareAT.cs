using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class CameraPrepareAT : ActionTask {

		public BBParameter<GameObject> cameraSprite;

		public SpriteRenderer spriteRenderer;
		private float colorTime;

		protected override void OnExecute()
		{
            spriteRenderer = cameraSprite.value.GetComponent<SpriteRenderer>();
			colorTime = 0f;
            spriteRenderer.color = Color.red;
        }

		protected override void OnUpdate()
		{
			colorTime = colorTime + 1 * Time.deltaTime;
			if (colorTime > 2f)
			{
                spriteRenderer.color = Color.white;
                EndAction(true);
            }
		}
	}
}