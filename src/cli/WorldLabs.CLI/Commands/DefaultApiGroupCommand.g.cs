#nullable enable

using System.CommandLine;

namespace WorldLabs.CLI.Commands;

internal static class DefaultApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(DeleteWorldMarbleV1WorldsWorldIdDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(GenerateWorldMarbleV1WorldsGeneratePostCommandApiCommand.Create());
                         command.Subcommands.Add(GetCreditsMarbleV1CreditsGetCommandApiCommand.Create());
                         command.Subcommands.Add(GetMediaAssetMarbleV1MediaAssetsMediaAssetIdGetCommandApiCommand.Create());
                         command.Subcommands.Add(GetOperationMarbleV1OperationsOperationIdGetCommandApiCommand.Create());
                         command.Subcommands.Add(GetWorldMarbleV1WorldsWorldIdGetCommandApiCommand.Create());
                         command.Subcommands.Add(HealthzHealthzGetCommandApiCommand.Create());
                         command.Subcommands.Add(ListWorldsMarbleV1WorldsListPostCommandApiCommand.Create());
                         command.Subcommands.Add(PanoDepthToRgbMarbleV1PanoDepthToRgbPostCommandApiCommand.Create());
                         command.Subcommands.Add(PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostCommandApiCommand.Create());
        return command;
    }
}