// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>This class contains the event args for ShareCompleted.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ShareCompletedEventArgs : IShareCompletedEventArgs
  {
    /// <summary>Gets the share target.</summary>
    /// <returns>The share target.</returns>
    public extern ShareTargetInfo ShareTarget { [MethodImpl] get; }
  }
}
