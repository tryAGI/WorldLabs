#nullable enable

using System.CommandLine;

namespace WorldLabs.CLI.Commands;

internal static class CreditsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"credits", @"credits endpoint commands.");
                         command.Subcommands.Add(CreditsGetCreditsMarbleV1CreditsGetCommandApiCommand.Create());
        return command;
    }
}