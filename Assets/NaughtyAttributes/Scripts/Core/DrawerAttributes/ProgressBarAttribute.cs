using System;

namespace NaughtyAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class ProgressBarAttribute : DrawerAttribute
    {
        public string Name { get; private set; }
        public float MaxValue { get; private set; }
        public ProgressBarColor Color { get; private set; }

        public string maxValueVar { get; private set; }

        public ProgressBarAttribute(string name = "", float maxValue = 100, ProgressBarColor color = ProgressBarColor.Blue)
        {
            Name = name;
            MaxValue = maxValue;
            Color = color;
            this.maxValueVar = "";
        }

        public ProgressBarAttribute(string name = "", string maxValueVar = "", ProgressBarColor color = ProgressBarColor.Blue)
        {
            Name = name;
            MaxValue = 0;
            Color = color;
            this.maxValueVar = maxValueVar;
        }
    }

    public enum ProgressBarColor
    {
        Red,
        Pink,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet,
        White
    }
}