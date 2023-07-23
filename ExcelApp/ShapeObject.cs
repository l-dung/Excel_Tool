
using Microsoft.Office.Core;

namespace ExcelApp
{
    internal class ShapeObject
    {
        MsoAutoShapeType autoShapeType;
        float top;
        float left;
        float width;
        float height;
        public ShapeObject(MsoAutoShapeType autoShapeType, float top, float left, float height, float width)
        {
            AutoShapeType = autoShapeType;
            Top = top;
            Left = left;
            Width = width;
            Height = height;
        }

        public MsoAutoShapeType AutoShapeType { get => autoShapeType; set => autoShapeType = value; }
        public float Top { get => top; set => top = value; }
        public float Left { get => left; set => left = value; }
        public float Height { get => height; set => height = value; }
        public float Width { get => width; set => width = value; }
    }
}
