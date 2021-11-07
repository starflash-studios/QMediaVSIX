// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(176931760, 57534, 18520, 188, 42, 137, 223, 224, 179, 40, 99)]
  [ExclusiveTo(typeof (ToastCollection))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IToastCollection
  {
    string Id { get; }

    string DisplayName { get; set; }

    string LaunchArgs { get; set; }

    Uri Icon { get; set; }
  }
}
