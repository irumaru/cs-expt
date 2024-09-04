# Entrypoint

プロジェクト内のどこかの，`static void Main(string[] args)`メソッドがエントリーポイントになる．  
複数`static void Main(string[] args)`がある場合は，エントリーポイントが特定できないためエラーになる．  

## 複数Mainがある場合

```
/workspaces/cs-expt/Entrypoint/Console.cs(5,15): error CS0017: Program has more than one entry point defined. Compile with /main to specify the type that contains the entry point. [/workspaces/cs-expt/Entrypoint/Entrypoint.csproj]

The build failed. Fix the build errors and run again.
```
