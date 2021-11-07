// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.UICommandInvokedHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  /// <summary>Represents a callback function that handles the event that is fired when the user invokes a context menu command.</summary>
  /// <param name="command">Represents the invoked command.</param>
  [Guid(3673651791, 49786, 17048, 154, 198, 41, 34, 196, 94, 125, 166)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void UICommandInvokedHandler(IUICommand command);
}
