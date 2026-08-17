# Security Policy

## Supported branch

Security fixes target `main`.

## Reporting

Do not open public issues containing credentials, tokens, private keys, customer data, exploitable endpoints, or detailed proof-of-concept material.

Repository owners should treat suspected credential exposure as compromised immediately: revoke or rotate the credential at the provider, remove it from active configuration, then purge it from Git history if necessary.

## Repository rules

- Never commit Supabase `service_role` keys, private API keys, signing keys, access tokens, passwords, or production `.env` files.
- Client builds may contain only explicitly public/publishable credentials.
- Backend privileged credentials must live in managed secret storage and must never be embedded in Unity assets or source.
- New third-party code, packages, models, and assets require license/provenance and security review before production use.
- Security checks must pass before changes are merged to `main`.
