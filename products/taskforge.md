# TaskForge Agent Assurance

**by Black Knight Technology**

**✓ First Verified x402 Sale** · **✓ Customer Delivery Verified** · **✓ Direct x402 Payment Enabled**

## Verified Execution for Structured Jobs

TaskForge Agent Assurance is a developer-oriented execution layer for structured, machine-run assurance jobs. **Start by auditing up to 100 public API endpoints for $0.01 USDC.** No account, subscription, or manual approval is required: pay on Base and receive the verified machine-readable report in the same request.

**[Use TaskForge Agent Assurance — services from $0.01](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway?source=github-product-page&campaign=taskforge-trust-launch)**

[OpenAPI specification](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/openapi.json?source=github-product-page&campaign=taskforge-trust-launch)

### Fastest way to try it

An unpaid request safely returns the machine-readable HTTP 402 payment requirements:

```bash
curl -i -X POST \
  "https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/CATALOG_ENDPOINT_HEALTH_AUDIT?source=github-product-page&campaign=taskforge-trust-launch" \
  -H "content-type: application/json" \
  -d '{"catalog_entries":[{"id":"my-api","url":"https://example.com"}]}'
```

After paying the returned requirement, retry the same request with the x402 payment signature. TaskForge returns the audit and verification evidence directly in the successful response.

### Verified first sale

On September 2, 2026, this $0.01 service completed a real Base USDC payment, audited four submitted endpoints, returned the report to the buyer, passed verification at 100, and settled successfully.

[View the verified Base transaction](https://basescan.org/tx/0x6fb48f3ee8ee57b5a162ebdbf515061b9defc30a58106555d500553eaba0e9f3)

### Direct paid services

| Service | Price | x402 endpoint |
|---|---:|---|
| Endpoint Health Trust Launch | **$0.01 USDC** | [CATALOG_ENDPOINT_HEALTH_AUDIT](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/CATALOG_ENDPOINT_HEALTH_AUDIT?source=github-product-page&campaign=taskforge-catalog) |
| Machine Service Health Report | **$0.10 USDC** | [MACHINE_SERVICE_HEALTH_REPORT](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/MACHINE_SERVICE_HEALTH_REPORT?source=github-product-page&campaign=taskforge-catalog) |
| MCP Security Preflight | **$0.25 USDC** | [MCP_SECURITY_PERMISSION_AUDIT](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/MCP_SECURITY_PERMISSION_AUDIT?source=github-product-page&campaign=taskforge-catalog) |
| CI/CD Supply-Chain Preflight | **$0.25 USDC** | [CICD_SUPPLY_CHAIN_AUDIT](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/CICD_SUPPLY_CHAIN_AUDIT?source=github-product-page&campaign=taskforge-catalog) |
| AI Agent Permission Preflight | **$0.25 USDC** | [AGENT_PERMISSION_AUDIT](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/AGENT_PERMISSION_AUDIT?source=github-product-page&campaign=taskforge-catalog) |
| x402 Commerce Integrity Preflight | **$0.25 USDC** | [X402_COMMERCE_INTEGRITY_AUDIT](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/X402_COMMERCE_INTEGRITY_AUDIT?source=github-product-page&campaign=taskforge-catalog) |
| Release Readiness Workflow Audit | **$0.50 USDC** | [RELEASE_READINESS_WORKFLOW_AUDIT](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/RELEASE_READINESS_WORKFLOW_AUDIT?source=github-product-page&campaign=taskforge-catalog) |
| Agent Stack Security Audit | **$0.75 USDC** | [AGENT_STACK_SECURITY_AUDIT](https://qaegxjxaavxdqihfgzhr.supabase.co/functions/v1/taskforge-x402-gateway/AGENT_STACK_SECURITY_AUDIT?source=github-product-page&campaign=taskforge-catalog) |

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

TaskForge has active worker, verifier, settlement-watching, marketplace, RapidAPI, and x402 surfaces. Its first verified customer payment and synchronous delivery completed on September 2, 2026. The runtime also continues to process machine-service and marketplace traffic.

Marketplace exposure and runtime volume are not represented as customer revenue unless a paid settlement is independently verified.

[See Black Knight Technology Proof of Operation](../PROOF_OF_OPERATION.md)
