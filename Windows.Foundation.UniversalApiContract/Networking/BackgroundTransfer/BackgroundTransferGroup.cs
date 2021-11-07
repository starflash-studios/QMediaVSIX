// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundTransferGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>A named group used to associate multiple download or upload operations. This class makes it easy for your app to create these groups and to complete downloads and uploads simultaneously, in serial, or based on priority.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IBackgroundTransferGroupStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BackgroundTransferGroup : IBackgroundTransferGroup
  {
    /// <summary>Gets the name of the group.</summary>
    /// <returns>The group name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets or sets the property used to specify if transfers within this group run simultaneously or in serial. Possible values are defined by BackgroundTransferBehavior.</summary>
    /// <returns>The group transfer behavior.</returns>
    public extern BackgroundTransferBehavior TransferBehavior { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates a transfer group using the provided group name.</summary>
    /// <param name="name">The name of the group. If a group with the this name already exists, this method will return a reference to the existing group object.</param>
    /// <returns>The new BackgroundTransferGroup.</returns>
    [MethodImpl]
    public static extern BackgroundTransferGroup CreateGroup(string name);
  }
}
