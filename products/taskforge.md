# TaskForge

**by Black Knight Technologies**

**✓ Runtime Exercised** · **✓ x402 v2 + Bazaar Metadata** · **✓ Direct Base USDC Payment Enabled**

## Verified Execution for Structured Jobs

TaskForge is a developer-oriented execution layer for structured, machine-run jobs. Standard catalog jobs are available through direct USDC payment on Base: no account and no manual approval are required after a valid x402 payment is verified.

**[Open the PayAPI-submitted $0.01 x402 endpoint](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway)**

The live catalog and all eight paid routes advertise canonical HTTPS resource URLs, POST/JSON schemas, structured output examples, Base USDC payment requirements, and Bazaar discovery metadata.\n\n[View the marketplace listing pack](../marketplaces/taskforge-x402-listing-pack.md)\n\n### Direct paid services

| Service | Price | x402 endpoint |
|---|---:|---|
| Endpoint Health Trust Launch | **$0.01 USDC** | [CATALOG_ENDPOINT_HEALTH_AUDIT](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/CATALOG_ENDPOINT_HEALTH_AUDIT) |
| Machine Service Health Report | **$0.10 USDC** | [MACHINE_SERVICE_HEALTH_REPORT](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/MACHINE_SERVICE_HEALTH_REPORT) |
| MCP Security Preflight | **$0.25 USDC** | [MCP_SECURITY_PERMISSION_AUDIT](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/MCP_SECURITY_PERMISSION_AUDIT) |
| CI/CD Supply-Chain Preflight | **$0.25 USDC** | [CICD_SUPPLY_CHAIN_AUDIT](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/CICD_SUPPLY_CHAIN_AUDIT) |
| AI Agent Permission Preflight | **$0.25 USDC** | [AGENT_PERMISSION_AUDIT](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/AGENT_PERMISSION_AUDIT) |
| x402 Commerce Integrity Preflight | **$0.25 USDC** | [X402_COMMERCE_INTEGRITY_AUDIT](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/X402_COMMERCE_INTEGRITY_AUDIT) |
| Release Readiness Workflow Audit | **$0.50 USDC** | [RELEASE_READINESS_WORKFLOW_AUDIT](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/RELEASE_READINESS_WORKFLOW_AUDIT) |
| Agent Stack Security Audit | **$0.75 USDC** | [AGENT_STACK_SECURITY_AUDIT](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/AGENT_STACK_SECURITY_AUDIT) |

### How payment works

1. Send the documented JSON payload to the selected endpoint.
2. An unpaid request receives an HTTP 402 challenge with Base-network USDC payment requirements.
3. Pay the requested amount and retry with the x402 payment signature.
4. TaskForge verifies settlement, executes the bounded job, verifies the result, and returns machine-readable completion evidence.
5. Payment settles to Black Knight Technology's confirmed Coinbase USDC address on Base.

Standard catalog services do **not** require owner approval. Approval remains required only for custom work, expanded scope, privileged access, unsafe requests, or jobs outside the published catalog.

### What it is built for

- Structured agent jobs
- Machine-readable service requests
- Payment-verified execution
- Controlled fulfillment
- Evidence-backed completion

### Safety boundaries

TaskForge accepts only the published scope for each endpoint. It does not authorize outbound spending, paid bidding, purchases, custody, private-network access, arbitrary code execution, or unsupported custom work.

### Proof of operation

TaskForge has active worker, verifier, settlement-watching, marketplace, RapidAPI, and x402 surfaces. Its runtime has processed substantial machine-service traffic and has been exercised against external marketplace-style workflows.

Marketplace exposure and runtime volume are not represented as customer revenue unless a paid settlement is independently verified.

[See Black Knight Technology Proof of Operation](../PROOF_OF_OPERATION.md)
