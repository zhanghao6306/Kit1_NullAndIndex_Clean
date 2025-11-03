# Kit1_NullAndIndex (CLEAN) — Class Library + xUnit

本版本将主项目改为 **类库**（无 Program.cs），避免 “多个入口点 (CS0017)”。
请用 **解决方案模式** 打开 `.sln`，或在仓库根目录运行 `dotnet test`。

```
Kit1_NullAndIndex_Clean.sln
Kit1_NullAndIndex/
  ├─ Kit1_NullAndIndex.csproj   # 类库
  ├─ DangerousOps.cs
Kit1_NullAndIndex.Tests/
  ├─ Kit1_NullAndIndex.Tests.csproj
  └─ NullAndIndexTests.cs
```

## 使用
```bash
dotnet restore
dotnet test                 # 跑所有测试
dotnet test --filter TestCategory=Nulls
dotnet test --filter TestCategory=Index
```
