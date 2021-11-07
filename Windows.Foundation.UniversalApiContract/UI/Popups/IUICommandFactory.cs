// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.IUICommandFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  [Guid(2719646089, 9904, 18038, 174, 148, 84, 4, 27, 193, 37, 232)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UICommand))]
  internal interface IUICommandFactory
  {
    UICommand Create(string label);

    UICommand CreateWithHandler(string label, UICommandInvokedHandler action);

    UICommand CreateWithHandlerAndId(
      string label,
      UICommandInvokedHandler action,
      [Variant] object commandId);
  }
}
