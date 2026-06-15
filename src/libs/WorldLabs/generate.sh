#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://docs.worldlabs.ai/api/reference/openapi.yaml
autosdk generate openapi.yaml \
  --namespace WorldLabs \
  --clientClassName WorldLabsClient \
  --targetFramework net10.0 \
  --security-scheme ApiKey:Header:WLT-Api-Key \
  --output Generated \
  --exclude-deprecated-operations

rm -rf ../../cli/WorldLabs.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/WorldLabs.CLI \
  --sdk-project ../../libs/WorldLabs/WorldLabs.csproj \
  --targetFramework net10.0 \
  --namespace WorldLabs \
  --clientClassName WorldLabsClient \
  --package-id WorldLabs.CLI \
  --tool-command-name world-labs \
  --user-secrets-id WorldLabs.CLI \
  --api-key-env-var WORLDLABS_API_KEY \
  --base-url-env-var WORLDLABS_BASE_URL \
  --cli-credential-file \
  --cli-keep-api-group \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:WLT-Api-Key
