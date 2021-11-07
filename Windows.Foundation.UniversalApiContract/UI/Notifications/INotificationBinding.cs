// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.INotificationBinding
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (NotificationBinding))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4070460293, 880, 19155, 180, 234, 218, 158, 53, 231, 234, 191)]
  internal interface INotificationBinding
  {
    string Template { get; set; }

    string Language { get; set; }

    IMap<string, string> Hints { get; }

    IVectorView<AdaptiveNotificationText> GetTextElements();
  }
}
