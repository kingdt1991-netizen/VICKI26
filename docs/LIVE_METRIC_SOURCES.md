# Live Metric Source Rules

Public activity metrics must be derived from evidence appropriate to the claim.

| Public claim | Acceptable evidence | Not sufficient |
|---|---|---|
| Verified paid execution | independently verified payment + corresponding completed fulfillment | HTTP 402 challenge, probe, synthetic test |
| Verified settlement | processor/network settlement evidence reconciled to expected amount/asset/destination | checkout open, payment intent alone |
| Fulfilled order | delivery/fulfillment record tied to a valid paid or approved engagement | worker invocation without customer order |
| Active production endpoint | current successful health/payment-gate validation | README statement alone |
| Proof Receipt issued | stored receipt with proof hash and linked verified workflow | manually typed counter |
| Repeat buyer | distinct later verified commercial action attributable to the same approved buyer identity | repeat page visit |

## Publication
Metrics should publish an `as_of` timestamp and, where practical, the evidence class used. If a source is stale, syncing, unavailable, or ambiguous, suppress or qualify the metric rather than infer a number.

## Exclusions
Do not count synthetic tests, internal QA, owner tests, bots, unpaid x402 challenges, failed payments, refunded transactions, or unverified processor events as revenue/customer activity.