// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.TimeSpan
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents a time interval as a signed 64-bit integer value.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public struct TimeSpan
  {
    /// <summary>A time period expressed in 100-nanosecond units.</summary>
    public long Duration;
  }
}
