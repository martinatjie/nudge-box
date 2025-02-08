using NudgeBox.Api.Models;

namespace NudgeBox.Api.Services
{
    public interface IPromptService
    {
        Prompt GetPrompt(int promptId);
        Prompt CreatePrompt(Prompt prompt);
        Prompt UpdatePrompt(Prompt prompt);
        Prompt DeletePrompt(int promptId);
    }

    public class PromptService : IPromptService
    {
        public Prompt CreatePrompt(Prompt prompt)
        {
            throw new NotImplementedException();
        }

        public Prompt DeletePrompt(int promptId)
        {
            throw new NotImplementedException();
        }

        public Prompt GetPrompt(int promptId)
        {
            throw new NotImplementedException();
        }

        public Prompt UpdatePrompt(Prompt prompt)
        {
            throw new NotImplementedException();
        }
    }

}
