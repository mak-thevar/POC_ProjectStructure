namespace POC_ProjectStructure.BLL
{

    public interface IDefectsService
    {
        Task<string> GetMessage();
    }

    public class DefectsService : IDefectsService
    {
        public Task<string> GetMessage()
        {
            return Task.FromResult("Defects controller works.");
        }
    }
}
