using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Code
{
    public class Character : MonoBehaviour
    {
        public MeshRenderer Renderer;

        public void SetColor(Color color)
        {
            Renderer.material.color = color;
        }

        public void SetActive(bool isActive)
        {
            gameObject.SetActive(isActive);
        }
    }
}