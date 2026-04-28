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
