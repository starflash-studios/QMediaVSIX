// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Represents a group of notifications for a particular app.</summary>
  [Activatable(typeof (IToastCollectionFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  public sealed class ToastCollection : IToastCollection
  {
    [MethodImpl]
    public extern ToastCollection(
      string collectionId,
      string displayName,
      string launchArgs,
      Uri iconUri);

    /// <summary>Gets the ID of this notification group.</summary>
    /// <returns>
    /// </returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets or sets the group title that displays in the Action Center.</summary>
    /// <returns>The group title that displays in the Action Center.</returns>
    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the launch arguments provided to app when the notification group title is clicked in the Action Center.</summary>
    /// <returns>The launch arguments provided to app when the notification group title is clicked in the Action Center.</returns>
    public extern string LaunchArgs { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the icon that displays next to the group title in the Action Center.</summary>
    /// <returns>The icon that displays next to the group title in the Action Center.</returns>
    public extern Uri Icon { [MethodImpl] get; [MethodImpl] set; }
  }
}
