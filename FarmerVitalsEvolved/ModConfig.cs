
namespace FarmerVitalsReWrite
{
	internal class ModConfig
	{
		public bool enableMod = true;
		public bool enableDebug = true;

		public bool enableBaseVitals = true;
		public int baseMaxHealth = 50; // 100
		public int baseMaxStamina = 135; // 270

		public bool enableStardropVitals = true;
		public int stardropHealthGain = 5; // 0
		public int stardropStaminaGain = 40; // 34

		public bool enableSnakeMilkVitals = true;
		public int snakeMilkHealthGain = 30; //25
		public int snakeMilkStaminaGain = 30; //0

		public bool enableCombatProfessionVitals = true;
		public int fighterHealthGain = 15; //15
		public int defenderHealthGain = 40; //25

		public bool enableFarmingVitals = true;
		public float farmingHealthGain = 1.0f;
		public float farmingStaminaGain = 5.0f;

		public bool enableMiningVitals = true;
		public float miningHealthGain = 2.0f;
		public float miningStaminaGain = 5.0f;

		public bool enableForagingVitals = true;
		public float foragingHealthGain = 1.0f;
		public float foragingStaminaGain = 4.0f;

		public bool enableFishingVitals = true;
		public float fishingHealthGain = 1.0f;
		public float fishingStaminaGain = 3.0f;

		public bool enableCombatVitals = true;
		public bool overrideVanillaCombatHealth = true;
		public float combatHealthGain = 5.0f;
		public float combatStaminaGain = 2.0f;

		public bool enableSleepVitals = true;
		public int sleepHealthGain = 20;
		public int sleepStaminaGain = 75;
		public int exhaustedStaminaLoss = 50; //Exhaustion, max Late to bed, and pass out penalty if enableSleepVitals is true
		public bool enableExhaustedHealth = true; //Applies the same logic to Health
        public int exhaustedHealthLoss = 20;
    }
}
