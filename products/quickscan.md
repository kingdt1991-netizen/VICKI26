# QuickScan

**by Black Knight Technology**

**✓ Live x402 Endpoints** · **✓ Payment-Gated Execution** · **✓ Measurable Product Funnel**

## Configuration and Artifact Release-Security Preflight

QuickScan runs bounded deterministic checks against caller-supplied text. It helps developers and agents catch common release-risk signals before deployment without requiring an account or subscription.

[Use QuickScan](https://proof-quickscan.bktl-deont.chatgpt.site/quickscan/) • [Read the API documentation](https://proof-quickscan.bktl-deont.chatgpt.site/api/)

### Direct paid services

| Service | Price | Checks for |
|---|---:|---|
| Configuration Security Preflight | **$0.03 USDC** | Possible private keys, secret assignments, permissive CORS, debug mode, insecure HTTP, and invalid JSON |
| Artifact Release-Security Preflight | **$0.10 USDC** | Common secret, configuration, and release-readiness signals |

### Payment and delivery

1. Send the documented JSON payload to the selected endpoint.
2. Receive an HTTP 402 challenge with the exact Base USDC payment requirement.
3. Pay and retry with the x402 payment signature.
4. Receive machine-readable findings, the input hash, the scan boundary, and verification evidence.

### Scope boundaries

QuickScan is a focused deterministic preflight. It is not malware analysis, dependency scanning, penetration testing, release certification, or a comprehensive security audit. A PASS means only that the published checks found no matching signal in the supplied bounded input.

### Safety

The standard services do not authorize outbound spending, purchases, custody, private-network access, arbitrary code execution, or unsupported custom work. Viewing documentation or sending an unpaid request does not initiate payment.

### Marketplace status

Both QuickScan services have been submitted to 402 Index and remain pending review until the marketplace marks them approved or live. Submitted is not the same as approved.
