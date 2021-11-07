// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.INotificationVisual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (NotificationVisual))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1753439118, 43606, 19985, 134, 211, 95, 154, 105, 87, 188, 91)]
  internal interface INotificationVisual
  {
    string Language { get; set; }

    IVector<NotificationBinding> Bindings { get; }

    NotificationBinding GetBinding(string templateName);
  }
}
