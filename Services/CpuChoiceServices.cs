namespace LazarB_Challenge_RockPaperScissorLizardSpock_Endpoint.Services
{
    public class CpuChoiceServices
    {
        string[] CpuOptions = {"Rock", "Paper", "Scissors", "Lizard", "Spock"};

        Random pick = new();

        public string CpuGo(){
            int randomPick = pick.Next(CpuOptions.Length);
            return CpuOptions[randomPick];
        } 
    }
}