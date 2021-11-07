// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Duration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the duration of time that a Timeline is active, or more generally represents a duration of time that also supports two special values **Automatic** and **Forever**.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public struct Duration
  {
    /// <summary>The **TimeSpan** value component.</summary>
    public TimeSpan TimeSpan;
    /// <summary>The type as a member of the enumeration.</summary>
    public DurationType Type;
  }
}
