// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.DateTimeFormatting.MinuteFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.DateTimeFormatting
{
  /// <summary>Specifies the intended format for the minute in a DateTimeFormatter object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MinuteFormat
  {
    /// <summary>Do not display the minute.</summary>
    None,
    /// <summary>Display the minute in the most natural way. This will depend on the context, such as the language or clock that is being used.</summary>
    Default,
  }
}
