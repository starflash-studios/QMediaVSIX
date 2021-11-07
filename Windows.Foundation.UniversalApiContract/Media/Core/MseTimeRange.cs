// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MseTimeRange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Describes the start and end of a time range.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct MseTimeRange
  {
    /// <summary>The starting time interval expressed in 100-nanosecond units.</summary>
    public TimeSpan Start;
    /// <summary>The ending time interval expressed in 100-nanosecond units.</summary>
    public TimeSpan End;
  }
}
