// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareTargetInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>This class contains information about a share target.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ShareTargetInfo : IShareTargetInfo
  {
    /// <summary>Gets the app user model ID.</summary>
    /// <returns>The app user model ID.</returns>
    public extern string AppUserModelId { [MethodImpl] get; }

    /// <summary>Gets the share provider.</summary>
    /// <returns>The share provider.</returns>
    public extern ShareProvider ShareProvider { [MethodImpl] get; }
  }
}
