# Campaign Tracking Standard

Black Knight Technology measures acquisition by attributable downstream commercial actions, not by invented or unavailable page-view counts.

## Standard parameters
Where a destination supports query parameters, outbound campaign links should use:

- `source` — origin such as `github`, `knight-exchange`, `direct-outreach`, `x402-directory`, `partner`.
- `campaign` — stable campaign name such as `api-reliability`, `launch-readiness`, `agent-assurance`, `evidence-assurance`, `commerce-readiness`.
- `offer` — optional product/offer identifier.
- `lead` — optional non-sensitive internal/public-safe prospect identifier. Never encode email, private customer data, secrets, or protected IP.

Example pattern:
`?source=github&campaign=api-reliability&offer=taskforge`

## Funnel stages
1. `DISCOVERED` — qualified public buyer-intent evidence found.
2. `OUTREACH_SENT` — contextual invitation sent where permitted.
3. `ENGAGED` — prospect replies or takes an attributable next action.
4. `INTAKE_STARTED` — buyer begins a valid intake/evaluation path.
5. `CHECKOUT_STARTED` — buyer reaches a payment-required step where observable.
6. `PAID_VERIFIED` — payment independently verified.
7. `FULFILLED` — promised bounded result/report delivered.
8. `SETTLED` — settlement independently verified.
9. `REPEAT` — buyer completes another verified commercial action.

## Source of truth
Traffic alone is not revenue. GitHub stars, watches, clones, bot probes, synthetic tests, unpaid x402 challenges, checkout-page opens, and unverified payment events must not be reported as customers or revenue.

Preferred evidence is destination-side intake/checkout telemetry, x402 request evidence, fulfillment records, and independently verified settlement records.

## Privacy
Campaign identifiers must never contain credentials, wallet signing material, private repository paths, customer-confidential content, personal financial data, or Crown IP.