using System.IO;
using UnityEngine;

namespace DailyAdofai {
    public static class Assets {
        public static Texture2D Thumbnail;

        public static void Load(string path) {
            Thumbnail = new Texture2D(2, 2);
            using var reader = new BinaryReader(new FileStream(Path.Combine(path, "thumbnail.png"), FileMode.Open));
            Thumbnail.LoadImage(reader.ReadBytes((int)reader.BaseStream.Length));
        }
    }
}