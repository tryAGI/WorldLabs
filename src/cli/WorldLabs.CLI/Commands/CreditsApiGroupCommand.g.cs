#nullable enable

using System.CommandLine;

namespace WorldLabs.CLI.Commands;

internal static partial class CreditsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"credits", @"credits endpoint commands.");
                         command.Subcommands.Add(CreditsGetCreditsMarbleV1CreditsGetCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}