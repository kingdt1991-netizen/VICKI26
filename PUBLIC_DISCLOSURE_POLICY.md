# VICKI26 Public Disclosure Policy

VICKI26 is a public storefront and discovery surface for Black Knight Technology. It is not a development repository, architecture repository, operations repository, or Crown IP repository.

## Public-safe rule

Public material may explain:
- what a product does;
- who it is for;
- approved pricing;
- public inputs and outputs;
- approved public endpoints and checkout paths;
- bounded public API schemas needed to invoke a service;
- independently supportable proof/status claims;
- explicit safety and assurance boundaries.

Public material must not explain the proprietary mechanism that produces the result.

## Prohibited disclosures

Do not commit:
- Crown IP, unpublished source, private algorithms, proprietary scoring, orchestration, decision, composition, verification, settlement, learning, or capability-generation logic;
- internal architecture blueprints, roadmaps, operating playbooks, research hypotheses, benchmark recipes, private state machines, dependency graphs, schemas, database structures, worker internals, or deployment topology;
- private repository paths or authenticated internal URLs;
- credentials, secrets, service-role keys, signing material, wallet secrets, privileged database information, administrative endpoints, or environment files;
- customer-confidential information, private evidence, private prospect records, internal financial records, or non-public operational telemetry;
- internal agent prompts, policies, thresholds, authority-routing recipes, exception logic, recovery logic, or Crown decision criteria.

## Endpoint rule

A public endpoint may be listed only when it is intentionally public and authorization is enforced by the service itself. Public discovery must never be treated as an authorization boundary. Only the minimum invocation contract required by a legitimate buyer should be disclosed.

## AI / crawler rule

Files intended for AI discovery (including llms.txt, ai.txt, skill manifests, OpenAPI documents, catalogs, and .well-known resources) are public disclosures. They receive the same Crown review as human-facing pages. Machine readability is never permission to disclose implementation internals.

## Publication gate

Before adding or materially changing public content, classify it:
- GREEN — marketing, approved interface, approved proof/status, public pricing: publishable.
- YELLOW — implementation-adjacent detail or operational information: rewrite to black-box language before publication.
- RED — Crown IP, secrets, privileged internals, private data, or reconstructive architecture detail: prohibited.

When uncertain, classify RED until reviewed.

## History rule

Removing sensitive material from the current branch does not erase Git history. If an actual credential or secret is ever committed, treat it as compromised and rotate/revoke it. If Crown IP is discovered in history, record the exposure and evaluate history remediation separately.

## Crown principle

Public users receive capabilities, interfaces, bounded results, and independently supportable evidence — not the private recipe.
