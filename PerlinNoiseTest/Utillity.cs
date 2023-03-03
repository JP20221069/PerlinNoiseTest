using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace PerlinNoiseTest
{
    class Utillity
    {
        public static Color BlendPixel(Color a , Color b)
        {
            Color ret = Color.Black;
            int rA = a.R;
            int rB = b.R;
            int gA = a.G;
            int gB = b.G;
            int bA = a.B;
            int bB = b.B;
            int aA = a.A;
            int aB = b.A;
            int aOut = aA + (aB * (255 - aA) / 255);
            int rOut = (rA * aA + rB * aB * (255 - aA) / 255)/aOut ;
            int gOut = (gA * aA + gB * aB * (255 - aA) / 255) / aOut;
            int bOut = (bA * aA + bB * aB * (255 - aA) / 255)/aOut ;
            ret = Color.FromArgb(aOut, rOut, gOut, bOut);
            return ret;
        }

        public static Color colorize(float f)
        {
            Color ret = Color.Black;
            float c = 255 * (f + 1) / 2;
            if (c > 255) c = 255;
            if (c < 0) c = 0;
            ret = Color.FromArgb(255, (int)c, (int)c, (int)c);
            return ret;
        }
    }
}
