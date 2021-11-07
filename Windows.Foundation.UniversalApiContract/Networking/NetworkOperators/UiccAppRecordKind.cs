// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.UiccAppRecordKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Describes the kinds of UICC application record.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UiccAppRecordKind
  {
    /// <summary>An unknown app record kind. For example, a UICC app that is enumerable by the modem, but is not an app used for cellular registration, would be reported as **Unknown**.</summary>
    Unknown,
    /// <summary>A transparent file - a sequence of bytes without further structure .</summary>
    Transparent,
    /// <summary>A file that consists of a sequence of records.</summary>
    RecordOriented,
  }
}
