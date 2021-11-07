// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastActivatedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(2877138194, 52321, 22158, 129, 190, 48, 74, 195, 16, 56, 250)]
  [ExclusiveTo(typeof (ToastActivatedEventArgs))]
  internal interface IToastActivatedEventArgs2
  {
    ValueSet UserInput { get; }
  }
}
