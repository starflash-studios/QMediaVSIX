// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotification2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2650513361, 5178, 18702, 144, 191, 185, 251, 167, 19, 45, 231)]
  [ExclusiveTo(typeof (ToastNotification))]
  internal interface IToastNotification2
  {
    string Tag { set; get; }

    string Group { set; get; }

    bool SuppressPopup { set; get; }
  }
}
