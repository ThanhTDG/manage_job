using System.Drawing;

namespace BUS.Define
{

    public static class MyColor
    {
        public static Color ColorLevel(int mucDo)
        {
            //return Color.FromArgb(255 - mucDo * 51, 50, 0 + mucDo * 51);
            Color r = Color.Black;
            switch (mucDo)
            {
                case 0:
                    r = Color.Red;
                    break;
                case 1:
                    r = Color.Brown;
                    break;
                case 2:
                    r = Color.Purple;
                    break;
                case 3:
                    r = Color.DarkGreen;
                    break;
                case 4:
                    r = Color.Black;
                    break;
                case 5:
                    r = Color.Gray;
                    break;
            }
            return r;
        }

        //public static Color Color
    }
}
