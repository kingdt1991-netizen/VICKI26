# TaskForge x402 Marketplace Listing Pack

**Provider:** Black Knight Technologies  
**Product family:** TaskForge  
**Network:** Base mainnet (`eip155:8453`)  
**Asset:** Native USDC  
**Settlement address:** `0x7fB588901cef1400F114b62FC11e25A83B24f778`  
**Catalog:** https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway

## Provider summary

TaskForge provides small, bounded, machine-readable assurance jobs for AI agents, MCP servers, CI/CD workflows, APIs, and x402 sellers. Each public endpoint advertises x402 v2 payment requirements, accepts Base USDC, performs only the published job, and returns structured evidence after verified settlement.

## Marketplace offers

| Offer | Price | When an agent should use it |
|---|---:|---|
| Endpoint Health Trust Launch | $0.01 | Check up to 100 public catalog endpoints for reachability, status, latency, and launch readiness without making paid calls. |
| Machine Service Health Report | $0.10 | Produce a machine-readable reachability, latency, status, and payment-challenge report for a public HTTPS service. |
| MCP Security Preflight | $0.25 | Inspect MCP configuration for dangerous permissions, command execution, secret exposure, network access, and write-capable tools. |
| CI/CD Supply-Chain Preflight | $0.25 | Detect unsafe workflow permissions, `pull_request_target` risk, and mutable CI action references before release. |
| AI Agent Permission Preflight | $0.25 | Classify agent tools by read, write, network, secret, and execution risk before deployment. |
| x402 Commerce Integrity Preflight | $0.25 | Verify that an x402 endpoint returns a usable payment challenge with network, amount, and payment metadata. |
| Release Readiness Workflow Audit | $0.50 | Identify blocking security signals across agent configuration, MCP permissions, and CI/CD workflows. |
| Agent Stack Security Audit | $0.75 | Audit an agent stack across MCP configuration, tool permissions, workflow security, and side-effect exposure. |

Every offer is a `POST` endpoint under the catalog URL using the capability key shown in [the TaskForge product page](../products/taskforge.md).

## Discovery contract

All eight endpoints currently advertise:

- x402 version 2
- canonical public HTTPS resource URL
- HTTP `POST`
- JSON request-body schema and realistic input example
- JSON output example
- Base mainnet and native USDC
- the confirmed settlement address above
- `extensions.bazaar` discovery metadata
- `Cache-Control: no-store` on payment challenges

## Safety and commercial boundaries

TaskForge is sell-only. It does not purchase services, bid with funds, hold customer funds, access private networks, or execute arbitrary shell commands. Public offers execute without owner approval only after a valid x402 settlement. Custom or privileged work remains outside the public catalog.

## Marketplace submission copy

**Short description:** Machine-payable security, endpoint-health, x402 checkout, MCP permission, supply-chain, and release-readiness audits for autonomous agents.

**Categories:** security, developer-tools, compliance, infrastructure, data-quality, x402, MCP

**Provider website:** https://blackknightstech.com/  
**Public documentation:** https://github.com/kingdt1991-netizen/VICKI26/blob/main/products/taskforge.md

## Publication gates

- Coinbase Bazaar: metadata-ready; official validator and one successful CDP-facilitated settlement still required for indexing.
- Agentic Market: expected to inherit listings after Coinbase Bazaar indexing.
- Agent402: direct registration endpoint is retired; discovery depends on its crawler and Bazaar.
- PayAPI Market: public form is available; provider name, email, company, wallet, and endpoint submission are required.
- Circle Agent Marketplace: curated submission requires a live, validated and health-checked endpoint.
- Agora402: suitable after publishing an AgentCard that represents the TaskForge family.
