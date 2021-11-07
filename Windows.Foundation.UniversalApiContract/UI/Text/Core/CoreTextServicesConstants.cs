// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextServicesConstants
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  /// <summary>Provides constant values for use with the Windows core text APIs and the text input server.</summary>
  [Static(typeof (ICoreTextServicesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class CoreTextServicesConstants
  {
    /// <summary>Gets a value to use to replace hidden data inside a text stream before returning the text to the text input server.</summary>
    /// <returns>A value to use to replace hidden data inside a text stream. The Unicode code point is 0xF8FD.</returns>
    public static extern char HiddenCharacter { [MethodImpl] get; }
  }
}
