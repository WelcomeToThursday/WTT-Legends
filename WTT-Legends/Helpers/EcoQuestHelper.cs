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
        

        
        //rifles 
        private const string HOWA_TYPE_64 = "67f757e26cf3bc1bfc968982";
        
        public void ModifyQuests()
        {
            var quests = templateTable.Quests;
            

            // District Patrol (64e7b9bffd30422ed03dad38)
            questHelper.AddWeaponsToKillCondition(quests, "64e7b9bffd30422ed03dad38", [
                HOWA_TYPE_64
            ]);
            
        }
    }
}
