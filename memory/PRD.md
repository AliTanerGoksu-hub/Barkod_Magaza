# Barkod Magaza ERP/POS - Product Requirements Document

## Original Problem Statement
Multi-platform ERP/POS ecosystem with:
1. Desktop VB.NET Windows Forms app (DevExpress, OleDb/SQL Server)
2. C# .NET 8 Web API Mobile Backend (Dapper)
3. .NET MAUI Blazor Mobile App

### Core Requirements:
- AI Infrastructure across all platforms
- AI Dashboard and Risk Indicators for Mobile
- Silent AI Risk Warnings on Desktop ERP
- Standardized cost calculation (FIFO, LIFO, Weighted Average)
- Bug fixes for POS, UI threads, Mobile AI, Image Migration
- B2B management tabs and R2 image upload

## Architecture
```
/app/ (Barkod_Magaza) - Desktop VB.NET
/tmp/New_Backend/ - C# .NET 8 Web API
/tmp/New_Mobile/ - MAUI Blazor Mobile
```

## Completed Work
- [x] Image Migration Tool (Frm_Resim_Cevir.vb) - varbinary fix (74e870b)
- [x] MAUI Demo Mode lock (22f0ef3)
- [x] App Store "demo" word removal (b93c1e6)
- [x] iOS Build Error fix (efd6a43, c273523)
- [x] MAUI Route Auto-Refresh timers (b39b2fa)
- [x] Toplu Maliyet KDV doubling fix (3b02075, 523fa94)
- [x] **Araya Satir Ekle fix** - ORDER BY nEkSaha1 ASC added to sorgu_harekets (bf931cf) - AWAITING USER TEST

## In Progress / Pending
- P0: Araya Satir Ekle - Awaiting user test (bf931cf)

## Backlog (Prioritized)
- P1: Cost calculation standardization (FIFO, LIFO, Weighted Average)
- P1: E-Fatura/E-Arsiv auto-matching logic
- P2: AI usage logs UI (frm_AIKullanimRaporu)

## Key DB Schema
- `tbStokFisiDetayi`: Invoice row details. `nEkSaha1` = physical row order
- `tbStokResmi`: Legacy images (varbinary)

## Critical Notes
- /tmp/ directories volatile (Kubernetes wipes between steps)
- User language: Turkish
- Always push changes via git bash, never ask user to do it
