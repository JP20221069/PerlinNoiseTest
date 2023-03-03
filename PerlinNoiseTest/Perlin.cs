using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PerlinNoiseTest
{
    class Perlin
    {
        public static void create()
        {

        }

        public static float[] noise2D(int width, int height, float[] seed, int octaves, float bias)
        {
            float[] ret = new float[width*height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    float noise = 0.0f;
                    float scale_accumulator = 0.0f;
                    float scale = 1.0f;
                    for (int o = 0; o < octaves; o++)
                    {
                        int pitch = width >> o;
                        int samplex1 = (x / pitch) * pitch;
                        int sampley1 = (y / pitch) * pitch;
                        int samplex2 = (samplex1 + pitch) % width;
                        int sampley2 = (sampley1 + pitch) % width;

                        float blend_x = (float)(x - samplex1) / (float)pitch;
                        float blend_y = (float)(y - sampley2) / (float)pitch;
                        float sample_t = (1.0f - blend_x) * seed[sampley1 * width + samplex1] + blend_x * seed[sampley1 * width + samplex2];
                        float sample_b = (1.0f - blend_x) * seed[samplex2 * width + samplex1] + blend_x * seed[sampley2 * width + samplex2];
                        scale_accumulator += scale;
                        noise += (blend_y * (sample_b - sample_t) + sample_t) * scale;
                        scale = scale / bias;
                    }
                    ret[y * width + x] = noise / scale_accumulator;
                }
              
            }
            return ret;
            
           
        }


    }
}
