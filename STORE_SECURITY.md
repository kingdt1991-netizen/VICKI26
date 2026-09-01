# VICKI26 Public Storefront Security Boundary

VICKI26 is a public marketing and product-discovery repository for Black Knight Technology.

## Allowed public content

- Product names and descriptions
- Approved pricing
- Public screenshots, flyers, and diagrams
- Public landing-page URLs
- Public checkout URLs
- High-level technical descriptions that do not disclose proprietary implementation

## Prohibited public content

- Secrets, tokens, private keys, passwords, credentials, or `.env` files
- Supabase service-role keys or privileged database credentials
- Private GitHub repository URLs intended for authenticated internal access
- Internal deployment credentials or administrative endpoints
- Crown IP exports, unpublished source code, or proprietary implementation internals
- Customer data, private prospect data, or private operational records

## Isolation model

The storefront is static. It has no privileged bridge into private repositories. A visitor reading this repository receives only the same public content committed here.

Private product implementations remain independently protected by their repository permissions, authentication controls, and application security boundaries.

For Supabase-backed products, Row Level Security and authorization must be enforced in the relevant private application's database/API layer. No storefront link or public page is permitted to rely on obscurity as an authorization mechanism.

## Publication rule

Only material intentionally approved for public disclosure belongs in VICKI26. Finished public products may be listed here without moving their proprietary implementation into this repository.
