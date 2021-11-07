// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.TargetApplicationChosenEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Contains information about the target app the user chose to share content with. To get this object, you must handle the TargetApplicationChosen event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TargetApplicationChosenEventArgs : ITargetApplicationChosenEventArgs
  {
    /// <summary>Contains the name of the app that the user chose to share content with.</summary>
    /// <returns>The name of the app.</returns>
    public extern string ApplicationName { [MethodImpl] get; }
  }
}
