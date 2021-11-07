// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextScrollMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the method in which lines of text scroll through the region.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TimedTextScrollMode
  {
    /// <summary>Text lines pop on to the region discretely.</summary>
    Popon,
    /// <summary>Text lines roll up onto the region.</summary>
    Rollup,
  }
}
