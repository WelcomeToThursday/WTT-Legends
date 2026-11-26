using SPTarkov.Common.Models.Logging;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.Models.Spt.Tables;
using WTTServerCommonLib.Helpers;


namespace WTTLegends.Helpers
{
    [Injectable]
    public class EcoQuestHelper(TemplateTable templateTable, ISptLogger<EcoQuestHelper> logger, QuestHelper questHelper)
    {

        // Define weapon IDs
        // ReSharper disable InconsistentNaming
        // ReSharper disable IdentifierTypo
        //snipers
        private const string L115A3= "6b070da47d0e825f4a7e71b7";

        
        //rifles 
        private const string HOWA_TYPE_64 = "67f757e26cf3bc1bfc968982";
        
        public void ModifyQuests()
        {
            var quests = templateTable.Quests;
            

            // District Patrol (64e7b9bffd30422ed03dad38)
            questHelper.AddWeaponsToKillCondition(quests, "64e7b9bffd30422ed03dad38", [
                HOWA_TYPE_64
            ]);
            
            // Connections Up North (6764174c86addd02bc033d68)
            questHelper.AddWeaponsToKillCondition(quests, "6764174c86addd02bc033d68", [
                L115A3
            ]);
            
            var tarkovShooterWeapons = new[]
            {
                L115A3
            };
            
            // Psycho Sniper (5c0be13186f7746f016734aa)
            questHelper.AddWeaponsToKillCondition(quests, "5c0be13186f7746f016734aa", [
                L115A3
            ]);

            // Shooter Born in Heaven (5c0bde0986f77479cf22c2f8)
            questHelper.AddWeaponsToKillCondition(quests, "5c0bde0986f77479cf22c2f8", [
                L115A3
            ]);

            // Tarkov Shooter Part 1-8 (WEAPONS)
            questHelper.AddWeaponsToKillCondition(quests, "5bc4776586f774512d07cf05", tarkovShooterWeapons); // Part 1
            questHelper.AddWeaponsToKillCondition(quests, "5bc479e586f7747f376c7da3", tarkovShooterWeapons); // Part 2
            questHelper.AddWeaponsToKillCondition(quests, "5bc47dbf86f7741ee74e93b9", tarkovShooterWeapons); // Part 3
            questHelper.AddWeaponsToKillCondition(quests, "5bc480a686f7741af0342e29", tarkovShooterWeapons); // Part 4
            questHelper.AddWeaponsToKillCondition(quests, "5bc4826c86f774106d22d88b", tarkovShooterWeapons); // Part 5
            questHelper.AddWeaponsToKillCondition(quests, "5bc4836986f7740c0152911c", tarkovShooterWeapons); // Part 6
            questHelper.AddWeaponsToKillCondition(quests, "5bc4856986f77454c317bea7", tarkovShooterWeapons); // Part 7
            questHelper.AddWeaponsToKillCondition(quests, "5bc4893c86f774626f5ebf3e", tarkovShooterWeapons); // Part 8

            
        }
    }
}
