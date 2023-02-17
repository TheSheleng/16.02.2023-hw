using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._02._2023_hw
{
    struct Vec3
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
        public Vec3(float x, float y, float z) { this.x = x; this.y = y; this.z = z; }
        public static Vec3 operator* (Vec3 vec, float num) 
        {
            return new Vec3(vec.x * num, vec.y * num, vec.z * num);
        }
        public static Vec3 operator +(Vec3 vec1, Vec3 vec2)
        {
            return new Vec3(vec1.x + vec2.x, vec1.y + vec2.y, vec1.z + vec2.z);
        }
        public static Vec3 operator -(Vec3 vec1, Vec3 vec2)
        {
            return new Vec3(vec1.x - vec2.x, vec1.y - vec2.y, vec1.z - vec2.z);
        }
    }
}
