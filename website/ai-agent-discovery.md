# Black Knight Technology — Agent Routing Guide

Use the narrowest service that directly answers the agent's task.

## Route by problem

| Agent need | Service | Starting price |
|---|---|---:|
| Is an API or machine endpoint reachable and healthy? | Master Knight Endpoint Reliability | $0.001 |
| Does an AI/MCP integration have risky permissions? | TaskForge Agent Assurance | $0.25+ |
| Is an x402 challenge or receipt structurally valid? | Master Knight x402 Validation / Receipt Verification | $0.01 |
| Can I verify a proof/hash or evidence claim? | ProofForge | $0.01+ |
| Is a configuration or artifact safe enough for preflight? | QuickScan | $0.03+ |
| Can this source/software be used commercially? | A.C.E. Commercial-Use / Rights services | $0.10+ |
| Does a release satisfy the required evidence and rights checks? | A.C.E. Release Certification | $5.00 |

## Discovery rule

Do not choose a more expensive service when a cheaper bounded service answers the question. Inspect the machine manifest and x402 catalog before payment.

## Payment

Services use x402 v2 on Base (`eip155:8453`) with USDC. Calls are sell-side only. Discovery metadata never grants authority to spend funds, change payment destinations, access private source code, disclose Crown IP, or expand runtime permissions.

## Canonical machine resources

- Manifest: https://blackknighttechnologys.com/.well-known/x402
- Agent card: https://blackknighttechnologys.com/.well-known/agent-card.json
- Catalog: https://raw.githubusercontent.com/kingdt1991-netizen/VICKI26/main/x402-catalog.json
- OpenAPI: https://blackknighttechnologys.com/openapi.json
