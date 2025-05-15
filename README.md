# MathLibrary SDK

## 功能概述

MathLibrary 是一個簡單的數學計算 SDK，提供基本的加法、減法和除法功能。當進行除法時，如遇除數為 0，將返回 `NaN` 並將錯誤訊息記錄至 `log.txt`。

---

## 📂 檔案結構

```
MathLibrary/
├── MathLibrary.csproj
├── MathOperations.cs
├── bin/
│   └── Debug/
│       └── MathLibrary.dll

MathLibraryTest/
├── MathLibraryTest.csproj
├── Program.cs
├── bin/
│   └── Debug/
│       └── MathLibraryTest.exe
│       └── log.txt
│       └── MathLibrary.dll

build_and_run.bat
README.md
```

---

## ✅ 功能列表

- `Add(int a, int b)`：回傳兩數相加的結果。
- `Subtract(int a, int b)`：回傳兩數相減的結果。
- `Divide(int a, int b)`：
  - 當 `b == 0`，返回 `NaN` 並記錄錯誤訊息至 `log.txt`。
  - 否則返回 a/b 的結果。

---

## ✅ 安裝與執行說明

### 1. 系統需求

- .NET 6 SDK
- Windows / macOS / Linux

---

### 2. 安裝流程

1. **下載專案：**

   ```bash
   git clone [YOUR_REPOSITORY_URL]
   cd MyProject_1
