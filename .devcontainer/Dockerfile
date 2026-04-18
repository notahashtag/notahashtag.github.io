FROM mcr.microsoft.com/devcontainers/dotnet:2-10.0-noble

ENV PATH="$PATH:/home/vscode/.dotnet/tools" \
    SSL_CERT_DIR="/home/vscode/.aspnet/dev-certs/trust:/usr/lib/ssl/certs"

# Workaround: C# Dev Kit hardcodes a specific .NET runtime version for its language server.
# When the installed SDK ships a newer runtime patch than the extension expects, it ignores
# existingDotnetPath and auto-acquires the wrong version, causing a FileNotFoundException.
# Fix: install the exact runtime version the extension requires alongside the SDK.
# When the extension updates to target a newer runtime, bump this version to match.
# Track: https://github.com/microsoft/vscode-dotnet-runtime/issues
ARG CSDEVKIT_RUNTIME_VERSION=10.0.5
RUN wget -q https://dot.net/v1/dotnet-install.sh -O /tmp/dotnet-install.sh \
    && chmod +x /tmp/dotnet-install.sh \
    && /tmp/dotnet-install.sh \
        --runtime aspnetcore \
        --version ${CSDEVKIT_RUNTIME_VERSION} \
        --install-dir /usr/share/dotnet \
    && rm /tmp/dotnet-install.sh \
    && mkdir -p /home/vscode/.nuget/packages \
    && chown -R vscode:vscode /home/vscode/.nuget