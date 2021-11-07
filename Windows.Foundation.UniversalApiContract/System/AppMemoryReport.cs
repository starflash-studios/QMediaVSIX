// Decompiled with JetBrains decompiler
// Type: Windows.System.AppMemoryReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Represents app memory usage at a single point in time.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppMemoryReport : IAppMemoryReport, IAppMemoryReport2
  {
    /// <summary>Gets the app's usage of private commit.</summary>
    /// <returns>The app's usage of private commit.</returns>
    public extern ulong PrivateCommitUsage { [MethodImpl] get; }

    /// <summary>Gets the app's peak usage of private commit.</summary>
    /// <returns>The app's peak usage of private commit.</returns>
    public extern ulong PeakPrivateCommitUsage { [MethodImpl] get; }

    /// <summary>Gets the app's total usage of private plus shared commit.</summary>
    /// <returns>The app's total cap for private plus shared commit.</returns>
    public extern ulong TotalCommitUsage { [MethodImpl] get; }

    /// <summary>Gets the app's total cap for private plus shared commit.</summary>
    /// <returns>The app's total usage of private plus shared commit.</returns>
    public extern ulong TotalCommitLimit { [MethodImpl] get; }

    /// <summary>Gets the expected commit limit for the current app.</summary>
    /// <returns>The expected commit limit in bytes.</returns>
    public extern ulong ExpectedTotalCommitLimit { [MethodImpl] get; }
  }
}
