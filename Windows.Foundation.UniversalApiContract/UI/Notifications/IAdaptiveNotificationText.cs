// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IAdaptiveNotificationText
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(1188340670, 24730, 17190, 164, 11, 191, 222, 135, 32, 52, 163)]
  [ExclusiveTo(typeof (AdaptiveNotificationText))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAdaptiveNotificationText
  {
    string Text { get; set; }

    string Language { get; set; }
  }
}
