using UnityEngine;

namespace Code
{
    public class ConditionDeath : MonoBehaviour
    {
        public int hp;
        public MeshRenderer Renderer;
        public bool Enemy;

        public void Start()
        {
            CharacterPlayer();
            OrientationPlayer();
        }

        private void CharacterPlayer()
        {
            bool isDeath;
            if (hp > 0)
            {
                for (int i = hp; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        isDeath = true;
                    }
                    else
                    {
                        isDeath = false;
                    }
                    Debug.LogError(isDeath);
                }
            }
            else
            {
                Debug.LogError("Ты специально?");
            }
        }

        private void OrientationPlayer()
        {
            if (Enemy == true)
            {
                Renderer.material.color = Color.red;
            }
            else
            {
                Renderer.material.color = Color.blue;
            }
        }
    }
}