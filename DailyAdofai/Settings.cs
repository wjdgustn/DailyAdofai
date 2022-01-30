using UnityModManagerNet;

namespace DailyAdofai {
    public class Settings : UnityModManager.ModSettings, IDrawable {
        [Draw] public bool THERE_IS_NO_SETTINGS_HERE_WA_SANS_THIS_SETTING_NAME_IS_THE_LONGEST_I_HAVE_EVER_MADE_SO_SANS_HAHA = false;
        
        public void OnChange() { }

        public override void Save(UnityModManager.ModEntry modEntry) {
            Save(this, modEntry);
        }
    }
}