using UnityEngine;

namespace Code
{
    public class CharacterSpawner : MonoBehaviour
    {
        public Character Character;
        public int CountCharacter;

        private void Start()
        {
            for (int i = 0; i < CountCharacter; i++)
            {
                Character instantiate = Instantiate(Character, new Vector3(i, i, 0), Quaternion.identity);
                instantiate.name = $"Character {i}";
                instantiate.SetColor(Random.ColorHSV());
            }

            Character.SetActive(false);
        }
    }
}
