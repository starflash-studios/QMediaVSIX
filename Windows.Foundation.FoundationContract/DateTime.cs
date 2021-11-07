// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.DateTime
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents an instant in time, typically expressed as a date and time of day.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public struct DateTime
  {
    /// <summary>A 64-bit signed integer that represents a point in time as the number of 100-nanosecond intervals prior to or after midnight on January 1, 1601 (according to the Gregorian Calendar).</summary>
    public long UniversalTime;
  }
}
