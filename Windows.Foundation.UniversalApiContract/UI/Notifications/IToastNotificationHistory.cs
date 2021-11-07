// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationHistory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ToastNotificationHistory))]
  [Guid(1554898019, 467, 19607, 152, 111, 5, 51, 72, 63, 238, 20)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IToastNotificationHistory
  {
    [Overload("RemoveGroup")]
    void RemoveGroup(string group);

    [Overload("RemoveGroupWithId")]
    void RemoveGroup(string group, string applicationId);

    [Overload("RemoveGroupedTagWithId")]
    void Remove(string tag, string group, string applicationId);

    [Overload("RemoveGroupedTag")]
    void Remove(string tag, string group);

    [Overload("Remove")]
    void Remove(string tag);

    [Overload("Clear")]
    void Clear();

    [Overload("ClearWithId")]
    void Clear(string applicationId);
  }
}
