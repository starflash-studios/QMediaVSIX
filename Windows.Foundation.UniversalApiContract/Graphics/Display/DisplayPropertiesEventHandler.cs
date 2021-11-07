// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.DisplayPropertiesEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Represents a method that handles display property events.</summary>
  /// <deprecated type="deprecate">DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.</deprecated>
  /// <param name="sender">The object that raised the event.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [Guid(3688729345, 61857, 18129, 158, 227, 84, 59, 204, 153, 89, 128)]
  public delegate void DisplayPropertiesEventHandler(object sender);
}
