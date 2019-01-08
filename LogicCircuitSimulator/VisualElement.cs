using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LogicCircuitSimulator
{
    public class VisualElement
    {
        public VisualElement(GraphicElements.Elements _element)
        {
            Element = _element;

            try
            {
                ElementImage = GraphicElements.GetImage(_element);
            }

            catch (System.ComponentModel.InvalidEnumArgumentException)
            {
                ElementImage = SystemIcons.Error.ToBitmap();
            }
        }

        public void SetImage(Bitmap _newImage, int _inPinsCount = 0)
        {
            if (_newImage != null)
                ElementImage = _newImage;
        }

        public GraphicElements.Elements Element { get; private set; }
        public Bitmap ElementImage { get; private set; }
    }
}
