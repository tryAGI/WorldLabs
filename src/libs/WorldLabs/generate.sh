#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
fetch_spec -o openapi.yaml https://docs.worldlabs.ai/api/reference/openapi.yaml
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
