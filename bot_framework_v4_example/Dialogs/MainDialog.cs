using System.Collections.Generic;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Dialogs.Choices;

namespace bot_framework_v4_example.Dialogs
{
    public class MainDialog : WaterfallDialog
    {
        public static string Id => "mainDialog";

        public static MainDialog Instance { get; } = new MainDialog(Id);

        public MainDialog(string dialogId, IEnumerable<WaterfallStep> steps = null) : base(dialogId, steps)
        {
            AddStep(async (stepContext, cancellationToken) =>
            {
                var text = stepContext.Context.Activity.Text;

                await stepContext.Context.SendActivityAsync($"You sent '{text}'!");

                return await stepContext.EndDialogAsync();
            });
        }
    }
}